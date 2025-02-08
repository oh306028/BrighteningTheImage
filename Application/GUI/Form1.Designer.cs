namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CppMethodButton = new Button();
            AsmMethodButton = new Button();
            SaveButton = new Button();
            ChooseFileButton = new Button();
            label3 = new Label();
            FilePathTextBox = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ImageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // CppMethodButton
            // 
            CppMethodButton.BackColor = Color.Tan;
            CppMethodButton.Cursor = Cursors.Hand;
            CppMethodButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CppMethodButton.ForeColor = SystemColors.ButtonHighlight;
            CppMethodButton.Location = new Point(34, 321);
            CppMethodButton.Name = "CppMethodButton";
            CppMethodButton.Size = new Size(105, 69);
            CppMethodButton.TabIndex = 2;
            CppMethodButton.Text = " C++";
            CppMethodButton.UseVisualStyleBackColor = false;
            CppMethodButton.Click += CppMethodButtonClick;
            // 
            // AsmMethodButton
            // 
            AsmMethodButton.BackColor = Color.Tan;
            AsmMethodButton.Cursor = Cursors.Hand;
            AsmMethodButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AsmMethodButton.ForeColor = SystemColors.ButtonHighlight;
            AsmMethodButton.Location = new Point(489, 321);
            AsmMethodButton.Name = "AsmMethodButton";
            AsmMethodButton.Size = new Size(105, 69);
            AsmMethodButton.TabIndex = 3;
            AsmMethodButton.Text = "Assembly";
            AsmMethodButton.UseVisualStyleBackColor = false;
            AsmMethodButton.Click += AsmMethodButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Tan;
            SaveButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SaveButton.ForeColor = SystemColors.ButtonHighlight;
            SaveButton.Location = new Point(265, 141);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(100, 50);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save File";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // ChooseFileButton
            // 
            ChooseFileButton.BackColor = Color.Tan;
            ChooseFileButton.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ChooseFileButton.Location = new Point(88, 13);
            ChooseFileButton.Name = "ChooseFileButton";
            ChooseFileButton.Size = new Size(61, 22);
            ChooseFileButton.TabIndex = 5;
            ChooseFileButton.Text = "Open file explorer";
            ChooseFileButton.UseVisualStyleBackColor = false;
            ChooseFileButton.Click += OpenFileExplorerButton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(276, 54);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 8;
            label3.Text = "Threads";
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.BackColor = Color.BurlyWood;
            FilePathTextBox.ForeColor = Color.Black;
            FilePathTextBox.Location = new Point(155, 12);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.Size = new Size(365, 23);
            FilePathTextBox.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.BurlyWood;
            numericUpDown1.ForeColor = Color.Black;
            numericUpDown1.Location = new Point(244, 85);
            numericUpDown1.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(135, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // ImageBox
            // 
            ImageBox.BackColor = Color.Tan;
            ImageBox.BorderStyle = BorderStyle.Fixed3D;
            ImageBox.Location = new Point(172, 197);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(276, 264);
            ImageBox.SizeMode = PictureBoxSizeMode.AutoSize;
            ImageBox.TabIndex = 10;
            ImageBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(634, 461);
            Controls.Add(CppMethodButton);
            Controls.Add(AsmMethodButton);
            Controls.Add(SaveButton);
            Controls.Add(ChooseFileButton);
            Controls.Add(label3);
            Controls.Add(FilePathTextBox);
            Controls.Add(numericUpDown1);
            Controls.Add(ImageBox);
            KeyPreview = true;
            MaximumSize = new Size(650, 500);
            MinimumSize = new Size(650, 400);
            Name = "Form1";
            Text = "Bright The Image - filter";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CppMethodButton;
        private Button SaveButton;
        private Button ChooseFileButton;
        private Button AsmMethodButton;

        private TextBox FilePathTextBox;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private PictureBox ImageBox;
    }
}