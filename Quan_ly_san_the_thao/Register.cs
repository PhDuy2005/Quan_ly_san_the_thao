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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void FullName_Enter(object sender, EventArgs e)
        {
            if (tb_Fullname.Text == "VD: Nguyễn Văn A")
            {
                tb_Fullname.Text = "";
                tb_Fullname.ForeColor = Color.Black;
            }
        }

        private void FullName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Fullname.Text))
            {
                tb_Fullname.Text = "VD: Nguyễn Văn A";
                tb_Fullname.ForeColor = Color.LightGray;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (tb_Username.Text == "VD: UITTop1VN")
            {
                tb_Username.Text = "";
                tb_Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Username.Text))
            {
                tb_Username.Text = "VD: UITTop1VN";
                tb_Username.ForeColor = Color.LightGray;
            }
        }

        private void PhoneNumber_Enter(object sender, EventArgs e)
        {
            if (tb_PhoneNumber.Text == "VD: 0123456789")
            {
                tb_PhoneNumber.Text = "";
                tb_PhoneNumber.ForeColor = Color.Black;
            }
        }

        private void PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_PhoneNumber.Text))
            {
                tb_PhoneNumber.Text = "VD: 0123456789";
                tb_PhoneNumber.ForeColor = Color.LightGray;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (tb_Email.Text == "VD: NguyenVanA@gmail.com")
            {
                tb_Email.Text = "";
                tb_Email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Email.Text))
            {
                tb_Email.Text = "VD: NguyenVanA@gmail.com";
                tb_Email.ForeColor = Color.LightGray;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
