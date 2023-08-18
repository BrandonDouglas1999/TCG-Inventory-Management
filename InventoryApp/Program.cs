using System.Diagnostics;

namespace InventoryApp
{

    class Global
    {
        public static string uid;

        //public static String path = @"C:\Users\Ken\Documents\Capstone\TCG-Inventory-Management-Application\InventoryApp\CardImage"; //change this too
        //public static string path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage";
        public static string path = @"C:\Users\Brandon\Desktop\TCG-Inventory-Management-Application-main\InventoryApp\CardImage";

        //public static readonly String connectionString = "Server=localhost\\SQLEXPRESS01; Database=TCG_Inventory3; Trusted_Connection=yes";
        public static readonly String connectionString = "Server = DESKTOP-NDGJ14Q\\SQLEXPRESS; Database = TCG_Inventory3; Trusted_Connection = yes";
        //public static readonly String connectionString = "Server = JACKACE-PCMARK1\\MSSQLSERVER01; Database = TCG_Inventory3; Trusted_Connection = yes";
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Full_ImageForm());
            */
            
            
            
            ApplicationConfiguration.Initialize();

            Login login_screen = new Login();
            Main main = new Main();
            Application.Run(login_screen);

            while (true)
            {
                if (login_screen.authenticated)
                {
                    main = new Main();
                    main.user = login_screen.logged_user;
                    main.uid = login_screen.uid;
                    Global.uid = login_screen.uid;
                    Application.Run(main);
                }

                if (main.logout_selected)
                {
                    // Have to re-establish a new object after its closed.
                    login_screen = new Login();
                    Application.Run(login_screen);
                    main.logout_selected = false;
                }
                else
                {
                    break;
                }


            }
            


        }
    }
}