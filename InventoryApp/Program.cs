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
            Main main = new Main();
            Application.Run(login_screen);
            if (login_screen.authenticated)
            {
                main.user = login_screen.logged_user; 
                Application.Run(main);
            }
        }
    }
}