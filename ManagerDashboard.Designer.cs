namespace CoffeeShop_IMS
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menu_btn = new System.Windows.Forms.PictureBox();
            this.dashboardContainer = new System.Windows.Forms.Panel();
            this.m_dashboard = new System.Windows.Forms.Button();
            this.userContainer = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.editUser_btn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.createUser_btn = new System.Windows.Forms.Button();
            this.userManagementPanel = new System.Windows.Forms.Panel();
            this.user_M = new System.Windows.Forms.Button();
            this.usersCatalogContainer = new System.Windows.Forms.Panel();
            this.itemLists = new System.Windows.Forms.Button();
            this.greetingPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helloGreeting = new System.Windows.Forms.Label();
            this.addItemPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.addItemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.adddataGridView = new System.Windows.Forms.DataGridView();
            this.addProduct = new System.Windows.Forms.Button();
            this.addQuantity = new System.Windows.Forms.TextBox();
            this.addId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addType = new System.Windows.Forms.ComboBox();
            this.headerPanel.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            this.dashboardContainer.SuspendLayout();
            this.userContainer.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.userManagementPanel.SuspendLayout();
            this.usersCatalogContainer.SuspendLayout();
            this.greetingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Sienna;
            this.headerPanel.Controls.Add(this.logout_btn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(280, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1090, 96);
            this.headerPanel.TabIndex = 76;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.Location = new System.Drawing.Point(829, 7);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(77, 58);
            this.logout_btn.TabIndex = 66;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.dashboardContainer);
            this.sidebar.Controls.Add(this.userContainer);
            this.sidebar.Controls.Add(this.usersCatalogContainer);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(280, 794);
            this.sidebar.MinimumSize = new System.Drawing.Size(71, 795);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(280, 795);
            this.sidebar.TabIndex = 75;
            // 
            // menuContainer
            // 
            this.menuContainer.Controls.Add(this.menuLabel);
            this.menuContainer.Controls.Add(this.menu_btn);
            this.menuContainer.Location = new System.Drawing.Point(3, 3);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(335, 96);
            this.menuContainer.TabIndex = 0;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(77, 38);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(59, 24);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_btn.Image = global::CoffeeShop_IMS.Properties.Resources.white_menu_bar;
            this.menu_btn.Location = new System.Drawing.Point(9, 24);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(49, 49);
            this.menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_btn.TabIndex = 0;
            this.menu_btn.TabStop = false;
            // 
            // dashboardContainer
            // 
            this.dashboardContainer.Controls.Add(this.m_dashboard);
            this.dashboardContainer.Location = new System.Drawing.Point(3, 105);
            this.dashboardContainer.Name = "dashboardContainer";
            this.dashboardContainer.Size = new System.Drawing.Size(335, 55);
            this.dashboardContainer.TabIndex = 5;
            // 
            // m_dashboard
            // 
            this.m_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.m_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_dashboard.FlatAppearance.BorderSize = 0;
            this.m_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dashboard.ForeColor = System.Drawing.Color.White;
            this.m_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_dashboard.Location = new System.Drawing.Point(0, 3);
            this.m_dashboard.Name = "m_dashboard";
            this.m_dashboard.Size = new System.Drawing.Size(335, 55);
            this.m_dashboard.TabIndex = 0;
            this.m_dashboard.Text = "            Dashboard";
            this.m_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_dashboard.UseVisualStyleBackColor = false;
            // 
            // userContainer
            // 
            this.userContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.userContainer.Controls.Add(this.panel11);
            this.userContainer.Controls.Add(this.panel8);
            this.userContainer.Controls.Add(this.panel7);
            this.userContainer.Controls.Add(this.userManagementPanel);
            this.userContainer.Location = new System.Drawing.Point(3, 166);
            this.userContainer.MaximumSize = new System.Drawing.Size(335, 220);
            this.userContainer.MinimumSize = new System.Drawing.Size(335, 45);
            this.userContainer.Name = "userContainer";
            this.userContainer.Size = new System.Drawing.Size(335, 220);
            this.userContainer.TabIndex = 6;
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
            this.deleteUser_btn.Location = new System.Drawing.Point(0, -2);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(335, 57);
            this.deleteUser_btn.TabIndex = 8;
            this.deleteUser_btn.Text = "                Delete Item";
            this.deleteUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteUser_btn.UseVisualStyleBackColor = false;
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
            this.editUser_btn.Location = new System.Drawing.Point(0, 5);
            this.editUser_btn.Name = "editUser_btn";
            this.editUser_btn.Size = new System.Drawing.Size(335, 48);
            this.editUser_btn.TabIndex = 8;
            this.editUser_btn.Text = "                Edit Item";
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
            this.createUser_btn.Text = "                Add Item";
            this.createUser_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createUser_btn.UseVisualStyleBackColor = false;
            this.createUser_btn.Click += new System.EventHandler(this.createUser_btn_Click);
            // 
            // userManagementPanel
            // 
            this.userManagementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.userManagementPanel.Controls.Add(this.user_M);
            this.userManagementPanel.Location = new System.Drawing.Point(0, 0);
            this.userManagementPanel.Name = "userManagementPanel";
            this.userManagementPanel.Size = new System.Drawing.Size(335, 61);
            this.userManagementPanel.TabIndex = 7;
            // 
            // user_M
            // 
            this.user_M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.user_M.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.user_M.FlatAppearance.BorderSize = 0;
            this.user_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_M.ForeColor = System.Drawing.Color.White;
            this.user_M.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_M.Location = new System.Drawing.Point(0, -8);
            this.user_M.Name = "user_M";
            this.user_M.Size = new System.Drawing.Size(335, 56);
            this.user_M.TabIndex = 8;
            this.user_M.Text = "            Item Management";
            this.user_M.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_M.UseVisualStyleBackColor = false;
            // 
            // usersCatalogContainer
            // 
            this.usersCatalogContainer.Controls.Add(this.itemLists);
            this.usersCatalogContainer.Location = new System.Drawing.Point(3, 392);
            this.usersCatalogContainer.Name = "usersCatalogContainer";
            this.usersCatalogContainer.Size = new System.Drawing.Size(335, 47);
            this.usersCatalogContainer.TabIndex = 6;
            // 
            // itemLists
            // 
            this.itemLists.BackColor = System.Drawing.Color.Transparent;
            this.itemLists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.itemLists.FlatAppearance.BorderSize = 0;
            this.itemLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLists.ForeColor = System.Drawing.Color.White;
            this.itemLists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemLists.Location = new System.Drawing.Point(0, -3);
            this.itemLists.Name = "itemLists";
            this.itemLists.Size = new System.Drawing.Size(335, 48);
            this.itemLists.TabIndex = 0;
            this.itemLists.Text = "            Item Lists";
            this.itemLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemLists.UseVisualStyleBackColor = false;
            // 
            // greetingPanel
            // 
            this.greetingPanel.BackColor = System.Drawing.Color.Tan;
            this.greetingPanel.Controls.Add(this.pictureBox1);
            this.greetingPanel.Controls.Add(this.helloGreeting);
            this.greetingPanel.Location = new System.Drawing.Point(1205, -1);
            this.greetingPanel.Margin = new System.Windows.Forms.Padding(2);
            this.greetingPanel.Name = "greetingPanel";
            this.greetingPanel.Size = new System.Drawing.Size(115, 130);
            this.greetingPanel.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // helloGreeting
            // 
            this.helloGreeting.AutoSize = true;
            this.helloGreeting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloGreeting.ForeColor = System.Drawing.Color.White;
            this.helloGreeting.Location = new System.Drawing.Point(1, 105);
            this.helloGreeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloGreeting.Name = "helloGreeting";
            this.helloGreeting.Size = new System.Drawing.Size(56, 19);
            this.helloGreeting.TabIndex = 3;
            this.helloGreeting.Text = "Hello, ";
            // 
            // addItemPanel
            // 
            this.addItemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemPanel.Controls.Add(this.addType);
            this.addItemPanel.Controls.Add(this.label6);
            this.addItemPanel.Controls.Add(this.addItemName);
            this.addItemPanel.Controls.Add(this.label11);
            this.addItemPanel.Controls.Add(this.adddataGridView);
            this.addItemPanel.Controls.Add(this.addProduct);
            this.addItemPanel.Controls.Add(this.addQuantity);
            this.addItemPanel.Controls.Add(this.addId);
            this.addItemPanel.Controls.Add(this.label13);
            this.addItemPanel.Controls.Add(this.label16);
            this.addItemPanel.Controls.Add(this.label17);
            this.addItemPanel.Location = new System.Drawing.Point(280, 149);
            this.addItemPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addItemPanel.MaximumSize = new System.Drawing.Size(1311, 645);
            this.addItemPanel.MinimumSize = new System.Drawing.Size(1102, 645);
            this.addItemPanel.Name = "addItemPanel";
            this.addItemPanel.Size = new System.Drawing.Size(1102, 645);
            this.addItemPanel.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(566, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 33);
            this.label6.TabIndex = 36;
            this.label6.Text = "Type:";
            // 
            // addItemName
            // 
            this.addItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemName.Location = new System.Drawing.Point(765, 157);
            this.addItemName.Multiline = true;
            this.addItemName.Name = "addItemName";
            this.addItemName.Size = new System.Drawing.Size(275, 26);
            this.addItemName.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(566, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 33);
            this.label11.TabIndex = 34;
            this.label11.Text = "Item Name:";
            // 
            // adddataGridView
            // 
            this.adddataGridView.AllowUserToAddRows = false;
            this.adddataGridView.AllowUserToDeleteRows = false;
            this.adddataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adddataGridView.Location = new System.Drawing.Point(37, 73);
            this.adddataGridView.Name = "adddataGridView";
            this.adddataGridView.ReadOnly = true;
            this.adddataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adddataGridView.Size = new System.Drawing.Size(468, 524);
            this.adddataGridView.TabIndex = 32;
            this.adddataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdddataGridView_CellContentClick);
            // 
            // addProduct
            // 
            this.addProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProduct.BackColor = System.Drawing.Color.Sienna;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.Color.Transparent;
            this.addProduct.Location = new System.Drawing.Point(765, 386);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(275, 48);
            this.addProduct.TabIndex = 5;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // addQuantity
            // 
            this.addQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuantity.Location = new System.Drawing.Point(765, 313);
            this.addQuantity.Multiline = true;
            this.addQuantity.Name = "addQuantity";
            this.addQuantity.Size = new System.Drawing.Size(275, 26);
            this.addQuantity.TabIndex = 2;
            // 
            // addId
            // 
            this.addId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addId.Location = new System.Drawing.Point(765, 79);
            this.addId.Multiline = true;
            this.addId.Name = "addId";
            this.addId.Size = new System.Drawing.Size(79, 26);
            this.addId.TabIndex = 0;
            this.addId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Sienna;
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 56);
            this.label13.TabIndex = 20;
            this.label13.Text = "Add Item";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Sienna;
            this.label16.Location = new System.Drawing.Point(566, 310);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 33);
            this.label16.TabIndex = 9;
            this.label16.Text = "Quantity:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Sienna;
            this.label17.Location = new System.Drawing.Point(566, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 33);
            this.label17.TabIndex = 5;
            this.label17.Text = "I.D:";
            // 
            // addType
            // 
            this.addType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addType.FormattingEnabled = true;
            this.addType.Items.AddRange(new object[] {
            "Consumables",
            "Equipment and Tools",
            "Raw Materials"});
            this.addType.Location = new System.Drawing.Point(765, 235);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(275, 28);
            this.addType.TabIndex = 37;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 795);
            this.Controls.Add(this.addItemPanel);
            this.Controls.Add(this.greetingPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.headerPanel.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            this.dashboardContainer.ResumeLayout(false);
            this.userContainer.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.userManagementPanel.ResumeLayout(false);
            this.usersCatalogContainer.ResumeLayout(false);
            this.greetingPanel.ResumeLayout(false);
            this.greetingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addItemPanel.ResumeLayout(false);
            this.addItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adddataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel menuContainer;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.PictureBox menu_btn;
        private System.Windows.Forms.Panel dashboardContainer;
        private System.Windows.Forms.Button m_dashboard;
        private System.Windows.Forms.Panel userContainer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button editUser_btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button createUser_btn;
        private System.Windows.Forms.Panel userManagementPanel;
        private System.Windows.Forms.Button user_M;
        private System.Windows.Forms.Panel usersCatalogContainer;
        private System.Windows.Forms.Button itemLists;
        private System.Windows.Forms.Panel greetingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label helloGreeting;
        private System.Windows.Forms.Panel addItemPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addItemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView adddataGridView;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.TextBox addQuantity;
        private System.Windows.Forms.TextBox addId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox addType;
    }
}