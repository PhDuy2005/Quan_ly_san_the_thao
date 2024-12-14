using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public partial class PasswordConfirmation : Form
    {
        string username;
        public PasswordConfirmation(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void ShowPassword_Checked(object sender, EventArgs e)
        {
            if (ckBox_ShowPassword.Checked == true)
            {
                tb_Password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Password.UseSystemPasswordChar = true;
            }
        }

        private void ForgotPassword_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
            this.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string enteredPassword = tb_Password.Text; // Get the text from the textbox

            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper dbHelper = new DatabaseHelper();
            bool isValid = dbHelper.VerifyCredentials(username, enteredPassword);

            if (isValid)
            {
                ChangeProfile changeProfile = new ChangeProfile(username);
                changeProfile.ShowDialog();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
