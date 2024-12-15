using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quan_ly_san_the_thao
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void Phone_Enter(object sender, EventArgs e)
        {
            if (tb_PhoneNumber.Text == "Nhập số điện thoại...")
            {
                tb_PhoneNumber.Text = "";
                tb_PhoneNumber.ForeColor = Color.Black;
            }
        }

        private void Phone_Leave(object sender, EventArgs e)
        {
            PlaceholderShow();
        }

        private void PlaceholderShow()
        {
            if (string.IsNullOrWhiteSpace(tb_PhoneNumber.Text))
            {
                tb_PhoneNumber.Text = "Nhập số điện thoại...";
                tb_PhoneNumber.ForeColor = Color.LightGray;
            }
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            int length = tb_PhoneNumber.Text.Trim().Length;
            if (length != 10 && length != 11 || tb_PhoneNumber.Text.Trim()[0] != '0')
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                tb_PhoneNumber.Text = string.Empty;
                PlaceholderShow();
                return;
            }

            //Truy vấn
            DatabaseHelper dbHelper = new DatabaseHelper();
            bool isExist = dbHelper.CheckPhoneNumberExists(tb_PhoneNumber.Text);
            if (isExist) 
            {
                MakeNewPassword newPWD = new MakeNewPassword(tb_PhoneNumber.Text);
                this.Visible = false;
                newPWD.ShowDialog();
                this.DialogResult = DialogResult.OK;

            }
            else MessageBox.Show("Số điện thoại chưa được đăng ký!");
        }
    }
}
