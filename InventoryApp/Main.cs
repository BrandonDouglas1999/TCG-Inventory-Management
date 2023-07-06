using Microsoft.VisualBasic.Logging;

namespace InventoryApp
{
    public partial class Main : Form
    {

        bool sidebarExpand = false;
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

            // Change size of all UC's to windows size

            card_opt_tabs.Size = UCSize;
        }


        private void Main_Resize(object sender, EventArgs e)
        {

            // Should decide soon if sidebar open causes everything to scale, or if 
            // Interaction only occurs when sidebar is closed.
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

        // Home functions
        private void home_button_Click(object sender, EventArgs e)
        {
            activeWindow.Hide();
            activeWindow = home_page;
            resizeActiveWindow();
            activeWindow.Show();

        }

        // Card functions
        private void card_button_Click(object sender, EventArgs e)
        {
            activeWindow.Hide();
            activeWindow = card_opt_tabs;
            resizeActiveWindow();
            activeWindow.Show();


        }


    }
}