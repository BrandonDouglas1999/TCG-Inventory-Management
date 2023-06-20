namespace InventoryApp
{
    public partial class Main : Form
    {

        bool sidebarExpand;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Set sizes for certain objects
            sidebar.MaximumSize = new Size(200, int.MaxValue);
            logo.Location = new Point(this.Width / 3 + 50, logo.Location.Y);
        }

        // Menu click
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

        // Home Click
        private void home_button_Click(object sender, EventArgs e)
        {
            logo.Show();
        }

        // Cards click
        private void card_button_Click(object sender, EventArgs e)
        {
            logo.Hide();
        }
    }
}