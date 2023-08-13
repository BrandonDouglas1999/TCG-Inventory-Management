using Microsoft.VisualBasic.Logging;
using System.Drawing.Design;

namespace InventoryApp
{
    public partial class Main : Form
    {

        public string user = "test user";
        public string uid = null;
        bool sidebarExpand = false;
        int activeWindowNumber = 1;
        UserControl activeWindow;
        Point sidebarCollapsedLocation;
        Point sidebarExpandedLocation;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Set sizes for objects
            sidebar.MaximumSize = new Size(200, int.MaxValue);
            Size UCSize = new Size(this.Width - 50, this.Height);


            sidebarCollapsedLocation = new Point(50, 0);
            sidebarExpandedLocation = new Point(200, 0);

            activeWindow = home_page;
            activeWindow.Size = UCSize;
            activeWindow.Location = sidebarCollapsedLocation;

            home_page.update_username(user);
            home_page.uid = uid;
            //passing uid to other control
            card_opt_tabs.uid = uid;
            catalog_uc.uid = uid;
            home_page.load_dashboard();
            catalog_uc.paging_catalog();
            cart_uc.paging_catalog();
            sales_uc.load_sales();
            // Change size of all UC's to windows size

            card_opt_tabs.Size = UCSize;
            catalog_uc.Size = UCSize;
            cart_uc.Size = UCSize;
            sales_uc.Size = UCSize;

            // Set the colour schemes
            set_colours();
        }

        private void set_colours()
        {
            // Sidebar colours
            sidebar.BackColor = Color.FromArgb(255, 26, 28, 60);
            // Backdrop of the UC's
            // Anything specific to the UC's, probably change their colours there.
            home_page.BackColor = Color.FromArgb(255, 50, 55, 143);
            card_opt_tabs.BackColor = Color.FromArgb(255, 50, 55, 143);
            cart_uc.BackColor = Color.FromArgb(255, 50, 55, 143);
            sales_uc.BackColor = Color.FromArgb(255, 50, 55, 143);

        }

        // Menu functions
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                activeWindow.Location = new Point(activeWindow.Location.X - 10, activeWindow.Location.Y);
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                activeWindow.Location = new Point(activeWindow.Location.X + 10, activeWindow.Location.Y);
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        // Short function to change active size window depending on sidebar state
        private void resizeActiveWindow()
        {
            if (sidebarExpand)
            {
                activeWindow.Location = sidebarExpandedLocation;
            }
            else
            {
                activeWindow.Location = sidebarCollapsedLocation;
            }
        }


        private void home_button_Click(object sender, EventArgs e)
        {
            transitionUC(home_page);
            home_page.load_dashboard();
        }

        private void card_button_Click(object sender, EventArgs e)
        {
            transitionUC(card_opt_tabs);
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            transitionUC(catalog_uc);
            //need to load twice for the proper look
            catalog_uc.paging_catalog();
            activeWindow.SendToBack();
        }
        private void cart_button_Click(object sender, EventArgs e)
        {
            transitionUC(cart_uc);
            //need to load twice for the proper look
            cart_uc.paging_catalog();
            activeWindow.SendToBack();
        }
        private void sales_button_Click(object sender, EventArgs e)
        {
            transitionUC(sales_uc);
            sales_uc.load_sales();
        }

        // Handles the transition between UserControls (buttons)
        // UCSwitchTo is the UC to become the active window.
        private void transitionUC(UserControl UCSwitchTo)
        {
            if (activeWindow == UCSwitchTo) { return; }

            activeWindow.Hide();
            activeWindow = UCSwitchTo;
            resizeActiveWindow();
            activeWindow.Show();

            // This is here to hide the white border since colour cant be changed in tab control.
            if (activeWindow == catalog_uc)
            {
                activeWindow.Location = new Point(activeWindow.Location.X - 4, activeWindow.Location.Y - 5); ;
            }

        }


    }
}