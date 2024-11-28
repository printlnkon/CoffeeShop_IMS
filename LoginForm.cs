using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void logIn_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM users WHERE username='" + loginUsername.Text.Trim() + "'and password='" + MD5Hash(loginPassword.Text.Trim()) + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username='" + loginUsername.Text.Trim() + "'and password='" + MD5Hash(loginPassword.Text.Trim()) + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        userdetail user = new userdetail();
                        user.setUname((string)reader["username"].ToString());

                        if ((string)reader["usertype"].ToString() == "User")
                        {
                            // ADD MESSAGE BOX TO SHOW USER IS LOGGED IN
                            UserDashboard ud = new UserDashboard();
                            this.Hide();
                            ud.Show();
                        }
                        //if ((string)reader["usertype"].ToString() == "Manager")
                        //{
                        //    ManagerDashboard md = new ManagerDashboard();
                        //    this.Hide();
                        //    md.Show();
                        //}
                        //if ((string)reader["usertype"].ToString() == "Admin")
                        //{
                        //    AdminDashboard ad = new AdminDashboard();
                        //    this.Hide();
                        //    ad.Show();
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("Username or password was incorrect.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void createAcc_btn_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
            this.Hide();
        }
    }
}
