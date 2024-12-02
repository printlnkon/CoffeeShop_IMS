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
            ((System.ComponentModel.ISupportInitialize)(this.userListsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userListsDataGridView
            // 
            this.userListsDataGridView.AllowUserToAddRows = false;
            this.userListsDataGridView.AllowUserToDeleteRows = false;
            this.userListsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListsDataGridView.Location = new System.Drawing.Point(68, 70);
            this.userListsDataGridView.Name = "userListsDataGridView";
            this.userListsDataGridView.ReadOnly = true;
            this.userListsDataGridView.Size = new System.Drawing.Size(619, 357);
            this.userListsDataGridView.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(702, 11);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(64, 58);
            this.close_btn.TabIndex = 64;
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // UserLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 463);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.userListsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLists";
            this.Load += new System.EventHandler(this.UserLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userListsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userListsDataGridView;
        private System.Windows.Forms.Button close_btn;
    }
}