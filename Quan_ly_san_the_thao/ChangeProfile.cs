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
    public partial class ChangeProfile : Form
    {
        string username;

        public ChangeProfile(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form
            string fullname = tb_Fullname.Text.Trim();
            string phoneNumber = tb_PhoneNumber.Text.Trim();
            string gender = rdBtn_Male.Checked ? "Male" : rdBtn_Female.Checked ? "Female" : "Other";
            string email = tb_Email.Text.Trim();

            // Update the database
            DatabaseHelper dbHelper = new DatabaseHelper();
            bool isUpdated = dbHelper.UpdateCustomerInfo(fullname, phoneNumber, gender, email, username);

            if (isUpdated)
            {
                MessageBox.Show("Information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to the Profile form
                //Profile profileForm = new Profile(username); // Pass the username to the Profile form
                //profileForm.Show();
                this.Close(); // Close the current form
            }
            else
            {
                MessageBox.Show("Failed to update information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
