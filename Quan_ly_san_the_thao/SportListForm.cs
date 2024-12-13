using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_san_the_thao
{
    public partial class SportListForm : Form
    {
        string username;
        DataRow userDetail;

        public SportListForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.userDetail = new DatabaseHelper().GetUserDetails(username);
            lb_Greeting.Text = "CHÀO MỪNG" + userDetail["TENKH"].ToString().ToUpper() + " ĐẾN VỚI KHU PHỨC HỢP SE SPORT";
        }

        private void UserInfo_Click(object sender, EventArgs e)
        {
            //string username = this.username;
            //DatabaseHelper dbHelper = new DatabaseHelper();
            //DataRow userData = dbHelper.GetUserDetails(username);

            if (userDetail != null)
            {
                this.Hide();
                Profile profile = new Profile(userDetail);
                profile.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No user data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SportListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu đây không phải form chính
            if (this != Application.OpenForms[0])
            {
                Application.Exit(); // Kết thúc toàn bộ ứng dụng
            }
        }
    }
}
