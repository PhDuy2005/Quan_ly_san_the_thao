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
        Dictionary<string, DateTime> dates = new Dictionary<string, DateTime>();
        Dictionary<string, string> dateText = new Dictionary<string, string>();
        public TimeSelection()
        {
            InitializeComponent();

            UpdateDates();
        }

        /// <summary>
        /// Hàm này được gọi trong constructor và sự kiện thay đổi lựa chọn ngày trong mCd
        /// </summary>
        private void UpdateDates()
        {
            // Lấy ngày được chọn từ Calendar Control
            DateTime current_date = mCd_calendar.SelectionStart;

            // Tính toán các ngày từ Thứ Hai (Mon) đến Chủ Nhật (Sun)
            DateTime monday = current_date.AddDays(-(int)current_date.DayOfWeek + 1);
            if (current_date.DayOfWeek == DayOfWeek.Sunday)
            {
                monday = current_date.AddDays(-6);
            }

            // Điền vào Dictionary `dates`
            dates["Mon"] = monday;
            for (int i = 1; i < 7; i++)
            {
                dates[((DayOfWeek)i).ToString().Substring(0, 3)] = monday.AddDays(i);
            }
            dates["Sun"] = monday.AddDays(6);

            // Cập nhật chuỗi ngày dạng "dd/MM"
            updateDateText();

            // Hiển thị thông tin lên các label
            lb_Monday.Text = "Thứ 2\r\n" + dateText["Mon"];
            lb_Tuesday.Text = "Thứ 3\r\n" + dateText["Tue"];
            lb_Wednesday.Text = "Thứ 4\r\n" + dateText["Wed"];
            lb_Thursday.Text = "Thứ 5\r\n" + dateText["Thu"];
            lb_Friday.Text = "Thứ 6\r\n" + dateText["Fri"];
            lb_Saturnday.Text = "Thứ 7\r\n" + dateText["Sat"];
            lb_sunday.Text = "Chủ nhật\r\n" + dateText["Sun"];
        }
        /// <summary>
        /// Cập nhật dateText
        /// </summary>
        private void updateDateText()
        {
            // Cập nhật Dictionary `dateText` với chuỗi "dd/MM" từ Dictionary `dates`
            foreach (var day in dates.Keys)
            {
                DateTime date = dates[day];
                dateText[day] = date.Day.ToString("D2") + "/" + date.Month.ToString("D2");
            }
        }

        private void mCd_calendarDateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDates();
        }
    }
}
