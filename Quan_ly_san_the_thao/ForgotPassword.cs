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
                //Random rng = new Random();
                int otpCode = 111111; //OTP mặc định
                OTPCode verify_OTP = new OTPCode(otpCode, tb_PhoneNumber.Text);
                this.Hide();
                verify_OTP.ShowDialog();
                this.DialogResult = DialogResult.OK;

                //try
                //{
                //    string accountSid = "YOUR_TWILIO_ACCOUNT_SID";
                //    string authToken = "YOUR_TWILIO_AUTH_TOKEN";
                //    Twilio.TwilioClient.Init(accountSid, authToken);
                //    var messageSent = Twilio.Rest.Api.V2010.Account.MessageResource.Create(
                //        body: $"Mã OTP của bạn là: {otpCode}",
                //        from: new Twilio.Types.PhoneNumber("YOUR_TWILIO_PHONE_NUMBER"),
                //        to: new Twilio.Types.PhoneNumber(tb_PhoneNumber.Text)
                //    );

                //    MessageBox.Show($"Mã OTP: {otpCode} đã được gửi đến số điện thoại {tb_PhoneNumber.Text}");
                //    OTPCode verify_OTP = new OTPCode(otpCode, tb_PhoneNumber.Text);
                //    this.Hide();
                //    verify_OTP.ShowDialog();
                //    this.Show();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Đã xảy ra lỗi khi gửi SMS: {ex.Message}");
                //}

            }
            else MessageBox.Show("Số điện thoại chưa được đăng ký!");
        }
    }
}
