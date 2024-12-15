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
        bool isLoggedIn;
        string username;
        DataRow userDetail;
        private string selectedSport;
        public SportListForm(string username)
        {
            InitializeComponent();
            isLoggedIn = true;
            this.username = username;
            this.userDetail = new DatabaseHelper().GetUserDetails(username);
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            lb_Greeting.Text = "CHÀO MỪNG " + userDetail["TENKH"].ToString().ToUpper(new System.Globalization.CultureInfo("vi-VN")) 
                                            + "\r\nĐẾN VỚI KHU PHỨC HỢP SE SPORT";
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
            if (userDetail != null)
            {
                this.Hide();
                Profile profile = new Profile(userDetail);
                profile.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không tồn tại thông tin của user này.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Hide();
            isLoggedIn = false;
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }
        //selected sport:
        //LOAITT01 Bong da
        //LOAITT02    Bong chuyen
        //LOAITT03 Bong ro
        //LOAITT04    Cau long
        private void button1_Click(object sender, EventArgs e)
        {
            selectedSport = "LOAITT04"; //cầu lông
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            //this.Close();
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedSport = "LOAITT03"; //bóng rổ
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            //this.Close();
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //selectedSport = "Bóng chuyền";
            selectedSport = "LOAITT02";
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            //this.Close();
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //selectedSport = "Bóng đá";
            selectedSport = "LOAITT01";
            TimeSelection timeselect = new TimeSelection(userDetail, selectedSport);
            //this.Close();
            this.Visible = false;
            timeselect.ShowDialog();
            this.Visible = true;
        }
    }
}

