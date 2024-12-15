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
    public partial class OTPCode : Form
    {
        private int otpGenerated;
        private string phoneNumber;
        public OTPCode(int otp, string phone)
        {
            InitializeComponent();
            this.otpGenerated = otp;
            this.phoneNumber = phone;
        }

        private void OTP_Enter(object sender, EventArgs e)
        {
            if (tb_OTP.Text == "Nhập mã xác nhận...")
            {
                tb_OTP.Text = "";
                tb_OTP.ForeColor = Color.Black;
            }
        }

        private void OTP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_OTP.Text))
            {
                tb_OTP.Text = "Nhập mã xác nhận...";
                tb_OTP.ForeColor = Color.LightGray;
            }
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            int otpEntered;
            if (int.TryParse(tb_OTP.Text, out otpEntered))
            {
                if (otpEntered == otpGenerated)
                {
                    MessageBox.Show("Xác thực thành công! Bạn có thể đặt lại mật khẩu.");
                    this.Hide();
                    MakeNewPassword newPW = new MakeNewPassword(phoneNumber);
                    newPW.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mã OTP không chính xác!");
                    tb_OTP.Text = string.Empty;
                    tb_OTP.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã OTP không hợp lệ!");
                tb_OTP.Text = string.Empty;
                tb_OTP.Focus();
            }
        }
    }
}
