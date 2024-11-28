using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class SendCode : Form
    {
        private string resetCode;
        private string email;
        private readonly object sentCode;

        public SendCode(string email, string sentCode)
        {
            InitializeComponent();
            this.email = email;
            this.sentCode = sentCode;
        }

        public SendCode()
        {
            InitializeComponent();
        }

        private void sendCode_btn_Click(object sender, EventArgs e)
        {
            email = email_txtbox.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                resetCode = new Random().Next(100000, 999999).ToString();

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("kalfonteincruz@gmail.com", "leox ogkx ydps igkv"); // name: smtp 
                    MailMessage mail = new MailMessage("kalfonteincruz@gmail.com", email, "Password Reset Code", $"Your reset code is {resetCode}");
                    smtp.Send(mail);
                }

                MessageBox.Show("Code sent successfully. Please check your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open verification form with resetCode and email
                //var verifyForm = new SendCode(email, resetCode);
                //this.Hide();
                //verifyForm.ShowDialog();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void verifyCode_btn_Click(object sender, EventArgs e)
        {
            string enteredCode = code_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredCode))
            {
                MessageBox.Show("Please enter the code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredCode == resetCode)
            {
                MessageBox.Show("Code verified successfully! You can now reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Reset Password form
                var resetPasswordForm = new ResetPassword(email);
                this.Hide();
                resetPasswordForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
