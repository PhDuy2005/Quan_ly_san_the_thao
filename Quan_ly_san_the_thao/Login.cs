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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataRow dr = dbHelper.GetUserDetails(tb_Username.Text);
            int i = 0;
            while (true)
            {
                try
                {
                    string temp = dr[i].ToString();
                    MessageBox.Show(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    break;
                }
            }
        }
    }
}
