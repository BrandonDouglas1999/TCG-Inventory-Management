namespace InventoryApp
{
    public partial class Main : Form
    {

        bool sidebarExpand = true;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Set sizes for certain objects
            sidebar.MaximumSize = new Size(200, int.MaxValue);
            logo.Location = new Point((this.Width / 2) - (logo.Width / 2), logo.Location.Y);
            card_opt_tabs.Size = new Size(this.Width - 220, this.Height);
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
            card_opt_tabs.Hide();
            logo.Show();
        }

        // Card functions
        private void card_button_Click(object sender, EventArgs e)
        {
            logo.Hide();
            card_opt_tabs.Show();
        }

    }
}