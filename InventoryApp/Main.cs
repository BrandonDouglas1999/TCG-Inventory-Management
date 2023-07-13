using Microsoft.VisualBasic.Logging;

namespace InventoryApp
{
    public partial class Main : Form
    {

        bool sidebarExpand = false;
        int activeWindowNumber = 1;
        UserControl activeWindow;
        UserControl tempMove;
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
            transitionUC(1, home_page);
        }

        // Card functions
        private void card_button_Click(object sender, EventArgs e)
        {
            transitionUC(2, card_opt_tabs);
        }

        // Handles the transition between UserControls (buttons)
        // UCNumber is the number of the scene transitioning to
        // UCSwitchTo is the UC to become the active window.
        private void transitionUC(int UCNumber, UserControl UCSwitchTo)
        {
            if (activeWindowNumber == UCNumber) { return; }

            tempMove = activeWindow;
            activeWindow = UCSwitchTo;
            UCTransitionTimer.Tag = UCNumber.ToString();
            activeWindow.Show();


            // If active is lower than the one being swapped to, scroll up, else down.
            if (activeWindowNumber < UCNumber)
            {
                activeWindow.Location = new Point(tempMove.Location.X, tempMove.Location.Y + tempMove.Height);
            }
            else
            {
                activeWindow.Location = new Point(tempMove.Location.X, tempMove.Location.Y - tempMove.Height);
            }



            UCTransitionTimer.Start();

        }

        // Transition slide timer tick
        // since it references point y==0, main windows size has to be divisible by 10 plz
        private void UCTransitionTimer_Tick(object sender, EventArgs e)
        {

            int goToUCNum = int.Parse(UCTransitionTimer.Tag.ToString());

            while (activeWindow.Location.Y != 0)
            {

                // If active is lower than the one being swapped to, scroll down, else up.
                if (activeWindowNumber < goToUCNum)
                {
                    tempMove.Location = new Point(tempMove.Location.X, tempMove.Location.Y - 10);
                    activeWindow.Location = new Point(activeWindow.Location.X, activeWindow.Location.Y - 10);
                }
                else
                {
                    tempMove.Location = new Point(tempMove.Location.X, tempMove.Location.Y + 2);
                    activeWindow.Location = new Point(activeWindow.Location.X, activeWindow.Location.Y + 2);
                }
            }

            tempMove.Hide();
            activeWindowNumber = goToUCNum;
            UCTransitionTimer.Stop();

        }
    }
}