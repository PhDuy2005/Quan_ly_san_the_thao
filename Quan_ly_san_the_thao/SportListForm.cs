using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_san_the_thao
{
    public partial class SportListForm : Form
    {
        string strCon = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";
        SqlConnection sqlCon = null;
        string username;

        public SportListForm(string username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void UserInfo_Click(object sender, EventArgs e)
        {
            string username = this.username;
            DatabaseHelper dbHelper = new DatabaseHelper();
            DataRow userData = dbHelper.GetUserDetails(username);

            if (userData != null)
            {
                this.Hide();
                Profile profile = new Profile(userData);
                profile.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No user data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
