using System;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class AdminDashboard : Form
    {
        bool sidebarExpand;
        bool userCollapse;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                // if sidebar expand, minimize
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void userTimer_Tick(object sender, EventArgs e)
        {
            if (userCollapse)
            {
                userContainer.Height += 10;
                if (userContainer.Height == userContainer.MaximumSize.Height)
                {
                    userCollapse = false;
                    userTimer.Stop();
                }
            }
            else
            {
                userContainer.Height -= 10;
                if (userContainer.Height == userContainer.MinimumSize.Height)
                {
                    userCollapse = true;
                    userTimer.Stop();
                }
            }
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            userTimer.Start();
        }
    }
}
