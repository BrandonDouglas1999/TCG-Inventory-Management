namespace InventoryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            Login login_screen = new Login();
            Application.Run(login_screen);
            if (login_screen.authenticated)
            {
                Application.Run(new Main());
            }
        }
    }
}