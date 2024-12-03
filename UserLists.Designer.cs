namespace CoffeeShop_IMS
{
    partial class UserLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLists));
            this.userListsDataGridView = new System.Windows.Forms.DataGridView();
            this.close_btn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.generatePDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userListsDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userListsDataGridView
            // 
            this.userListsDataGridView.AllowUserToAddRows = false;
            this.userListsDataGridView.AllowUserToDeleteRows = false;
            this.userListsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListsDataGridView.Location = new System.Drawing.Point(35, 118);
            this.userListsDataGridView.Name = "userListsDataGridView";
            this.userListsDataGridView.ReadOnly = true;
            this.userListsDataGridView.Size = new System.Drawing.Size(619, 357);
            this.userListsDataGridView.TabIndex = 0;
            this.userListsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userListsDataGridView_CellContentClick);
            // 
            // close_btn
            // 
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(614, 15);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(64, 58);
            this.close_btn.TabIndex = 64;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Sienna;
            this.headerPanel.Controls.Add(this.logout_btn);
            this.headerPanel.Controls.Add(this.close_btn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(691, 96);
            this.headerPanel.TabIndex = 75;
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
            // 
            // generatePDF
            // 
            this.generatePDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatePDF.BackColor = System.Drawing.Color.Sienna;
            this.generatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePDF.ForeColor = System.Drawing.Color.White;
            this.generatePDF.Location = new System.Drawing.Point(35, 495);
            this.generatePDF.Name = "generatePDF";
            this.generatePDF.Size = new System.Drawing.Size(275, 48);
            this.generatePDF.TabIndex = 76;
            this.generatePDF.Text = "Generate Users List PDF";
            this.generatePDF.UseVisualStyleBackColor = false;
            this.generatePDF.Click += new System.EventHandler(this.generatePDF_Click);
            // 
            // UserLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 563);
            this.Controls.Add(this.generatePDF);
            this.Controls.Add(this.userListsDataGridView);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLists";
            this.Load += new System.EventHandler(this.UserLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListsDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userListsDataGridView;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button generatePDF;
    }
}