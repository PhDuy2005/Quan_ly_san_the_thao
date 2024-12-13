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
    public partial class Profile : Form
    {
        public Profile(DataRow userData)
        {
            InitializeComponent();

            tb_Fullname.Text = userData["TENKH"].ToString();
            tb_Username.Text = userData["USERNAME"].ToString();
            tb_PhoneNumber.Text = userData["SDT"].ToString();
            tb_Gender.Text = userData["GTINH"].ToString();
            tb_Email.Text = userData["EMAIL"].ToString();
            tb_UserType.Text = userData["LOAI"].ToString();
        }

        private void ChangeProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = "";
            PasswordConfirmation passwordConfirmation = new PasswordConfirmation(username);
            passwordConfirmation.ShowDialog();
            this.Show();
        }
    }
}
