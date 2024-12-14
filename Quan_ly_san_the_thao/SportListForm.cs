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
            lb_Greeting.Text = "CHÀO MỪNG " + userDetail["TENKH"].ToString().ToUpper() + "\r\nĐẾN VỚI KHU PHỨC HỢP SE SPORT";
        }

        private void AdjustFontSize(Label label)
        {
            Graphics g = label.CreateGraphics();
            Font currentFont = label.Font;
            SizeF textSize = g.MeasureString(label.Text, currentFont);

            while (textSize.Width > label.Width || textSize.Height > label.Height)
            {
                currentFont = new Font(currentFont.FontFamily, currentFont.Size - 0.5f, currentFont.Style);
                textSize = g.MeasureString(label.Text, currentFont);
            }

            label.Font = currentFont;
            g.Dispose();
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

        private void lb_Greeting_TextChanged(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            AdjustFontSize(lb);
        }

        private void lb_Greeting_Resize(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            AdjustFontSize(lb);
        }

        private void ChangePwd_click(object sender, EventArgs e)
        {
            ChangePassword cwd = new ChangePassword(username);
            this.Visible = false;
            cwd.ShowDialog();
            this.Visible = true;
        }
    }
}
