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
            if (string.IsNullOrWhiteSpace(tb_PhoneNumber.Text))
            {
                tb_PhoneNumber.Text = "Nhập số điện thoại...";
                tb_PhoneNumber.ForeColor = Color.LightGray;
            }
        }
    }
}
