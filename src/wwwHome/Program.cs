namespace wwwHome
{
    public static class Program
    {
        static public DialogResult result = DialogResult.Cancel;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginF logF = new LoginF();
            logF.ShowDialog();
            if (result == DialogResult.OK)
                Application.Run(new MF());
        }
    }
}