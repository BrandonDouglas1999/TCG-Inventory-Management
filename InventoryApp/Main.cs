using Microsoft.VisualBasic.Logging;

namespace InventoryApp
{
    public partial class Main : Form
    {

        bool sidebarExpand = false;
        UserControl activeWindow;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Set sizes for objects
            sidebar.MaximumSize = new Size(200, int.MaxValue);

            activeWindow = home_page;
            activeWindow.Size = new Size(this.Width - 50, this.Height);
            activeWindow.Location = new Point(50, 0);
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
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        // Home functions
        private void home_button_Click(object sender, EventArgs e)
        {
            activeWindow.Hide();
            activeWindow = home_page;

            activeWindow.Show();

        }

        // Card functions
        private void card_button_Click(object sender, EventArgs e)
        {
            activeWindow.Hide();
            activeWindow = card_opt_tabs;

            activeWindow.Show();
        }


    }
}