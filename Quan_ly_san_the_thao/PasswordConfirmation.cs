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
    public partial class PasswordConfirmation : Form
    {
        public PasswordConfirmation()
        {
            InitializeComponent();
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text == "Nhập mật khẩu...")
            {
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Password.Text))
            {
                tb_Password.Text = "Nhập mật khẩu...";
                tb_Password.ForeColor = Color.LightGray;
            }
        }
    }
}
