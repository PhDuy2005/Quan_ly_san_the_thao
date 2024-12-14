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
        private string username, currentSport;
        Dictionary<string, DateTime> dates = new Dictionary<string, DateTime>();
        Dictionary<string, string> dateText = new Dictionary<string, string>();
        Dictionary<string, Dictionary<int, Button>> timeDict = 
            new Dictionary<string, Dictionary<int, Button>>();
        public TimeSelection(string user, string sport)
        {
            InitializeComponent();
            InitializeTimeDict();
            UpdateDates();
            this.username = user;
            this.currentSport = sport;
        }

        private void InitializeTimeDict()
        {
            // Monday
            Dictionary<int, Button> item = new Dictionary<int, Button>();
            item.Add(7, btn_Monday7AM);
            item.Add(8, btn_Monday8AM);
            item.Add(9, btn_Monday9AM);
            item.Add(10, btn_Monday10AM);
            item.Add(13, btn_Monday1PM);
            item.Add(14, btn_Monday2PM);
            item.Add(15, btn_Monday3PM);
            item.Add(16, btn_Monday4PM);
            item.Add(18, btn_Monday6PM);
            item.Add(19, btn_Monday7PM);
            item.Add(20, btn_Monday8PM);
            item.Add(21, btn_Monday9PM);
            timeDict.Add("Mon", item);

            // Tuesday
            item = new Dictionary<int, Button>();
            item.Add(7, btn_Tuesday7AM);
            item.Add(8, btn_Tuesday8AM);
            item.Add(9, btn_Tuesday9AM);
            item.Add(10, btn_Tuesday10AM);
            item.Add(13, btn_Tuesday1PM);
            item.Add(14, btn_Tuesday2PM);
            item.Add(15, btn_Tuesday3PM);
            item.Add(16, btn_Tuesday4PM);
            item.Add(18, btn_Tuesday6PM);
            item.Add(19, btn_Tuesday7PM);
            item.Add(20, btn_Tuesday8PM);
            item.Add(21, btn_Tuesday9PM);
            timeDict.Add("Tue", item);

            // Wednesday
            item = new Dictionary<int, Button>();
            item.Add(7, btn_Wednesday7AM);
            item.Add(8, btn_Wednesday8AM);
            item.Add(9, btn_Wednesday9AM);
            item.Add(10, btn_Wednesday10AM);
            item.Add(13, btn_Wednesday1PM);
            item.Add(14, btn_Wednesday2PM);
            item.Add(15, btn_Wednesday3PM);
            item.Add(16, btn_Wednesday4PM);
            item.Add(18, btn_Wednesday6PM);
            item.Add(19, btn_Wednesday7PM);
            item.Add(20, btn_Wednesday8PM);
            item.Add(21, btn_Wednesday9PM);
            timeDict.Add("Wed", item);

            // Thursday
            item = new Dictionary<int, Button>();
            item.Add(7, btn_Thursday7AM);
            item.Add(8, btn_Thursday8AM);
            item.Add(9, btn_Thursday9AM);
            item.Add(10, btn_Thursday10AM);
            item.Add(13, btn_Thursday1PM);
            item.Add(14, btn_Thursday2PM);
            item.Add(15, btn_Thursday3PM);
            item.Add(16, btn_Thursday4PM);
            item.Add(18, btn_Thursday6PM);
            item.Add(19, btn_Thursday7PM);
            item.Add(20, btn_Thursday8PM);
            item.Add(21, btn_Thursday9PM);
            timeDict.Add("Thu", item);

            // Friday
            item = new Dictionary<int, Button>();
            item.Add(7, btn_Friday7AM);
            item.Add(8, btn_Friday8AM);
            item.Add(9, btn_Friday9AM);
            item.Add(10, btn_Friday10AM);
            item.Add(13, btn_Friday1PM);
            item.Add(14, btn_Friday2PM);
            item.Add(15, btn_Friday3PM);
            item.Add(16, btn_Friday4PM);
            item.Add(18, btn_Friday6PM);
            item.Add(19, btn_Friday7PM);
            item.Add(20, btn_Friday8PM);
            item.Add(21, btn_Friday9PM);
            timeDict.Add("Fri", item);

            // Saturday
            item = new Dictionary<int, Button>();
            item.Add(7, btn_Saturnday7AM);
            item.Add(8, btn_Saturnday8AM);
            item.Add(9, btn_Saturnday9AM);
            item.Add(10, btn_Saturnday10AM);
            item.Add(13, btn_Saturnday1PM);
            item.Add(14, btn_Saturnday2PM);
            item.Add(15, btn_Saturnday3PM);
            item.Add(16, btn_Saturnday4PM);
            item.Add(18, btn_Saturnday6PM);
            item.Add(19, btn_Saturnday7PM);
            item.Add(20, btn_Saturnday8PM);
            item.Add(21, btn_Saturnday9PM);
            timeDict.Add("Sat", item);

            // Sunday
            item = new Dictionary<int, Button>();
            item.Add(7, btn_Sunday7AM);
            item.Add(8, btn_Sunday8AM);
            item.Add(9, btn_Sunday9AM);
            item.Add(10, btn_Sunday10AM);
            item.Add(13, btn_Sunday1PM);
            item.Add(14, btn_Sunday2PM);
            item.Add(15, btn_Sunday3PM);
            item.Add(16, btn_Sunday4PM);
            item.Add(18, btn_Sunday6PM);
            item.Add(19, btn_Sunday7PM);
            item.Add(20, btn_Sunday8PM);
            item.Add(21, btn_Sunday9PM);
            timeDict.Add("Sun", item);
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
