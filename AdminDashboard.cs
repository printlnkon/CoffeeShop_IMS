using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class AdminDashboard : Form
    {
        bool menuExpand;
        bool userCollapse;
        public AdminDashboard()
        {
            InitializeComponent();
            FormStylingCorners.ApplyRoundedCorners(this, 20, 20); // apply rounded corners
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

            if (menuExpand)
            {
                // if sidebar expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    menuExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    menuExpand = true;
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
                // if sidebar expand, minimize
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

        private void createUser_btn_Click(object sender, EventArgs e)
        {
            createUserContainer.BringToFront();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardContianer.BringToFront();
        }

    }
}
