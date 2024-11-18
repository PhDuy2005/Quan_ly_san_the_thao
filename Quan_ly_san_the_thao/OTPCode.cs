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
        public OTPCode()
        {
            InitializeComponent();
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
    }
}
