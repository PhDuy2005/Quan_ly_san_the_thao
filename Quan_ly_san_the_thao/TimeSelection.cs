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
    public partial class TimeSelection : Form
    {
        public TimeSelection()
        {
            InitializeComponent();
            DateTime current_date = mCd_calendar.SelectionStart;
            DateTime monday = current_date.AddDays(-(int)current_date.DayOfWeek + 1);

            if (current_date.DayOfWeek == DayOfWeek.Sunday)
            {
                monday = current_date.AddDays(-6);
            }
            //MessageBox.Show(monday.ToShortDateString());
        }
    }
}
