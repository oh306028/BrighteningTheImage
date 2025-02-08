namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// Oskar Hamerla
        /// Semester 5
        /// 2024 / 2025
        /// Brighten image filter project
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());   
        }
    }
}