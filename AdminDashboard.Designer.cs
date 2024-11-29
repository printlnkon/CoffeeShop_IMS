namespace CoffeeShop_IMS
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.userContainer = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.editUser_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.createUser_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userButton = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.userTimer = new System.Windows.Forms.Timer(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.usersCatalog_btn = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel6.SuspendLayout();
            this.userContainer.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.userContainer);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(306, 719);
            this.sidebar.MinimumSize = new System.Drawing.Size(71, 719);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(306, 719);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 114);
            this.panel1.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.Location = new System.Drawing.Point(77, 47);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(59, 24);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::CoffeeShop_IMS.Properties.Resources.white_menu_bar;
            this.menuButton.Location = new System.Drawing.Point(9, 34);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(49, 49);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dashboard_btn);
            this.panel6.Location = new System.Drawing.Point(3, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(335, 55);
            this.panel6.TabIndex = 5;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 3);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(335, 48);
            this.dashboard_btn.TabIndex = 0;
            this.dashboard_btn.Text = "            Dashboard";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.UseVisualStyleBackColor = false;
            // 
            // userContainer
            // 
            this.userContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.userContainer.Controls.Add(this.panel11);
            this.userContainer.Controls.Add(this.panel8);
            this.userContainer.Controls.Add(this.panel7);
            this.userContainer.Controls.Add(this.panel2);
            this.userContainer.Location = new System.Drawing.Point(3, 184);
            this.userContainer.MaximumSize = new System.Drawing.Size(335, 220);
            this.userContainer.MinimumSize = new System.Drawing.Size(335, 55);
            this.userContainer.Name = "userContainer";
            this.userContainer.Size = new System.Drawing.Size(335, 55);
            this.userContainer.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.editUser_btn);
            this.panel8.Location = new System.Drawing.Point(0, 103);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(335, 57);
            this.panel8.TabIndex = 9;
            // 
            // editUser_btn
            // 
            this.editUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.editUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editUser_btn.FlatAppearance.BorderSize = 0;
            this.editUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUser_btn.ForeColor = System.Drawing.Color.White;
            this.editUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUser_btn.Location = new System.Drawing.Point(0, 0);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(335, 48);
            this.editUser_btn.TabIndex = 8;
            this.editUser_btn.Text = "                Edit User";
            this.editUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editUser_btn.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.createUser_btn);
            this.panel7.Location = new System.Drawing.Point(0, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 57);
            this.panel7.TabIndex = 8;
            // 
            // createUser_btn
            // 
            this.createUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.createUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createUser_btn.FlatAppearance.BorderSize = 0;
            this.createUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUser_btn.ForeColor = System.Drawing.Color.White;
            this.createUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createUser_btn.Location = new System.Drawing.Point(0, -1);
            this.createUser_btn.Name = "createUser_btn";
            this.createUser_btn.Size = new System.Drawing.Size(335, 48);
            this.createUser_btn.TabIndex = 8;
            this.createUser_btn.Text = "                Create User";
            this.createUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createUser_btn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.userButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 61);
            this.panel2.TabIndex = 7;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.userButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.White;
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.Location = new System.Drawing.Point(0, 2);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(335, 48);
            this.userButton.TabIndex = 8;
            this.userButton.Text = "            User Management";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // userTimer
            // 
            this.userTimer.Interval = 10;
            this.userTimer.Tick += new System.EventHandler(this.userTimer_Tick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.usersCatalog_btn);
            this.panel10.Location = new System.Drawing.Point(3, 245);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(335, 55);
            this.panel10.TabIndex = 6;
            // 
            // usersCatalog_btn
            // 
            this.usersCatalog_btn.BackColor = System.Drawing.Color.Transparent;
            this.usersCatalog_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usersCatalog_btn.FlatAppearance.BorderSize = 0;
            this.usersCatalog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersCatalog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersCatalog_btn.ForeColor = System.Drawing.Color.White;
            this.usersCatalog_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersCatalog_btn.Location = new System.Drawing.Point(0, 3);
            this.usersCatalog_btn.Name = "usersCatalog_btn";
            this.usersCatalog_btn.Size = new System.Drawing.Size(335, 48);
            this.usersCatalog_btn.TabIndex = 0;
            this.usersCatalog_btn.Text = "            Users Catalog";
            this.usersCatalog_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersCatalog_btn.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.Controls.Add(this.deleteUser_btn);
            this.panel11.Location = new System.Drawing.Point(0, 160);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(335, 57);
            this.panel11.TabIndex = 10;
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.deleteUser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteUser_btn.FlatAppearance.BorderSize = 0;
            this.deleteUser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser_btn.ForeColor = System.Drawing.Color.White;
            this.deleteUser_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteUser_btn.Location = new System.Drawing.Point(0, 0);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(335, 48);
            this.deleteUser_btn.TabIndex = 8;
            this.deleteUser_btn.Text = "                Delete User";
            this.deleteUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteUser_btn.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 719);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel6.ResumeLayout(false);
            this.userContainer.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Panel userContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button createUser_btn;
        private System.Windows.Forms.Timer userTimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button editUser_btn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button usersCatalog_btn;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button deleteUser_btn;
    }
}