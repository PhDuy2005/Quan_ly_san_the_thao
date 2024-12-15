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
        DataRow userData;
        public Profile(DataRow userData)
        {
            InitializeComponent();
            this.userData = userData;
            ShowProfile();
        }

        void ShowProfile()
        {
            tb_Fullname.Text = userData["TENKH"].ToString();
            tb_Username.Text = userData["USERNAME"].ToString();
            tb_PhoneNumber.Text = userData["SDT"].ToString();
            tb_Gender.Text = (bool)userData["GTINH"] ? "Nam" : "Nữ";
            tb_Email.Text = userData["EMAIL"].ToString();
        }

        private void ChangeProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            string username = userData["USERNAME"].ToString();
            PasswordConfirmation passwordConfirmation = new PasswordConfirmation(username);
            passwordConfirmation.ShowDialog();
            this.Show();
            userData.Delete();
            userData = new DatabaseHelper().GetUserDetails(username);
            ShowProfile();
        }


    }
}
