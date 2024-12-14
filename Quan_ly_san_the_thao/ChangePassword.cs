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
    public partial class ChangePassword : Form
    {
        private string currentPhoneNumber;
        public ChangePassword(string phone)
        {
            InitializeComponent();
            this.currentPhoneNumber = phone;
        }

    }
}
