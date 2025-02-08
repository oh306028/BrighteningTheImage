using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form     
    {
        [DllImport(@"C:\Users\hamer\Desktop\JAProj\application\x64\Debug\assembly.dll")]
        static extern void BrightenColorsAsm(byte[] imageData, int startIndex, int bytesToProcess, int rowStride);

        [DllImport(@"C:\Users\hamer\Desktop\JAProj\application\x64\Debug\biblioteka_c++.dll")]
        static extern void BrightenImageCpp(byte[] imageData, int startIndex, int bytesToProcess, int rowStride);

        private delegate void ProcessByDllDelegate(byte[] imageData, int startIndex, int bytesToProcess, int rowStride);
        public Form1()  
        {
            InitializeComponent();        
        }   

        private void ProcessImageWithDll(ProcessByDllDelegate processingFunction)   
        {
            if (string.IsNullOrEmpty(FilePathTextBox.Text))
            {
                MessageBox.Show("Choose a correct photo", "Error");
                return;
            }

            Bitmap bitmap = new Bitmap(FilePathTextBox.Text);
            Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr ptr = bitmapData.Scan0;
            int bytesAmount = bitmap.Height * Math.Abs(bitmapData.Stride);
            byte[] imageData = new byte[bytesAmount];
            Marshal.Copy(ptr, imageData, 0, bytesAmount);   

            int threadsAmount = (int)numericUpDown1.Value;      
            Thread[] threads = new Thread[threadsAmount];
            int rowsPerThread = bitmapData.Height / threadsAmount;
            int bytesToProcess = rowsPerThread * bitmapData.Stride;
            int remainder = bitmapData.Height % threadsAmount;


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Parallel.For(0, threadsAmount, i =>
            {
                int startIndex = i * bytesToProcess;
                int extra = i < remainder ? bitmapData.Stride : 0;
                startIndex += i < remainder ? bitmapData.Stride * i : bitmapData.Stride * remainder;
                processingFunction(imageData, startIndex, bytesToProcess + extra, bitmapData.Stride);
            });

                
            
            Marshal.Copy(imageData, 0, ptr, bytesAmount);
            bitmap.UnlockBits(bitmapData);
            ImageBox.Image = bitmap;

            stopWatch.Stop();
            MessageBox.Show($"Processed for: {stopWatch.ElapsedMilliseconds} ms", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CppMethodButtonClick(object sender, EventArgs e)   
        {
            ProcessImageWithDll(BrightenImageCpp);
        }

        private void OpenFileExplorerButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileContent = openFileDialog.FileName;

                    FilePathTextBox.Text = fileContent;

                    ImageBox.Image = Image.FromFile(fileContent);

                    ImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)numericUpDown1.Value;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
            saveFileDialog.Title = "Save file as: ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageBox.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void AsmMethodButton_Click(object sender, EventArgs e)
        {
            ProcessImageWithDll(BrightenColorsAsm);
        }   


    }
}