namespace InventoryApp
{
    public partial class Main : Form
    {

        bool sidebarExpand = false;
        string active_window = "Home";
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Set sizes for objects
            sidebar.MaximumSize = new Size(200, int.MaxValue);

            logo.Location = new Point((this.Width / 2) - (logo.Width / 2), 0);
            card_opt_tabs.Size = new Size(this.Width - 50, this.Height);
            card_opt_tabs.Location = new Point(50, 0);
        }


        private void Main_Resize(object sender, EventArgs e)
        {
            logo.Location = new Point((this.Width / 2) - (logo.Width / 2), logo.Location.Y);

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
            if (active_window == "Home")
            {
                return;
            }
            active_window = "Home";
            card_opt_tabs.Hide();
            logo.Show();
        }

        // Card functions
        private void card_button_Click(object sender, EventArgs e)
        {

            if (active_window == "Cards")
            {
                return;
            }
            active_window = "Cards";
            logo.Hide();
            card_opt_tabs.Show();
        }


    }
}