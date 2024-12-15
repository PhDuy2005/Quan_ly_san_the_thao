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
    public partial class MakeNewPassword : Form
    {
        string phoneNumber;
        DataRow user;
        public MakeNewPassword(string phone)
        {
            InitializeComponent();
            this.phoneNumber = phone;
            this.user = new DatabaseHelper().GetUsernameAndPwdByPhoneNumber(phone);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().ShowDialog();
        }

        private void btn_ChangePw_Click(object sender, EventArgs e)
        {
            if (tb_NewPw.Text != tb_NewPwConfirm.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (new DatabaseHelper().UpdatePassword(user["USERNAME"].ToString(), tb_NewPw.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
