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
        private string selectedSport;
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

        private void tsmi_changePw_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changepw = new ChangePassword(username);
            changepw.ShowDialog();
            this.Show();
        }

        private void tsmi_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedSport = "Cầu lông";
            TimeSelection timeselect = new TimeSelection(username, selectedSport);
            this.Close();
            timeselect.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedSport = "Bóng rổ";
            TimeSelection timeselect = new TimeSelection(username, selectedSport);
            this.Close();
            timeselect.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedSport = "Bóng chuyền";
            TimeSelection timeselect = new TimeSelection(username, selectedSport);
            this.Close();
            timeselect.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedSport = "Bóng đá";
            TimeSelection timeselect = new TimeSelection(username, selectedSport);
            this.Close();
            timeselect.ShowDialog();
        }
    }
}
