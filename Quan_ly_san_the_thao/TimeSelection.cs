﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public enum SlotState
    {
        OutOfSlots = 0,
        Available = 1,
    }
    public partial class TimeSelection : Form
    {
        DataRow userData;
        private string currentSport;
        Dictionary<string, DateTime> dates = new Dictionary<string, DateTime>();
        Dictionary<string, string> dateText = new Dictionary<string, string>();
        Dictionary<string, Dictionary<int, Button>> timeDict = 
            new Dictionary<string, Dictionary<int, Button>>();
        private decimal totalPrice = 0m;
        private Dictionary<DateTime, decimal> slotPrices = new Dictionary<DateTime, decimal>();
        private List<DateTime> selectedSlots = new List<DateTime>();
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";
        public TimeSelection(DataRow user, string sport)
        {
            InitializeComponent();
            this.userData = user;
            this.currentSport = sport;
            InitializeTimeDict();
            UpdateDates();
            GetPrice();
            LoadSlotsState();
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
            foreach (var day in timeDict.Keys)
            {
                foreach (var time in timeDict[day].Keys)
                {
                    timeDict[day][time].Click += TimeSlotButton_Click;
                }
            }
        }
        private void UpdateDates()
        {
            // Lấy ngày được chọn từ Calendar Control
            DateTime current_date = mCd_calendar.SelectionStart;

            // Tính toán các ngày từ Thứ Hai (Mon) đến Chủ Nhật (Sun)
            DateTime monday = current_date.AddDays(-(int)current_date.DayOfWeek + 
                (current_date.DayOfWeek == DayOfWeek.Sunday ? -6 : 1));
            MessageBox.Show(monday.ToString());
            dates["Mon"] = monday;
            for (int i = 1; i <= 6; i++)
            {
                dates[((DayOfWeek)((i + 1) % 7)).ToString().Substring(0, 3)] = monday.AddDays(i);
            }
            updateDateText();
            lb_Monday.Text = "Thứ 2\r\n" + dateText["Mon"];
            lb_Tuesday.Text = "Thứ 3\r\n" + dateText["Tue"];
            lb_Wednesday.Text = "Thứ 4\r\n" + dateText["Wed"];
            lb_Thursday.Text = "Thứ 5\r\n" + dateText["Thu"];
            lb_Friday.Text = "Thứ 6\r\n" + dateText["Fri"];
            lb_Saturnday.Text = "Thứ 7\r\n" + dateText["Sat"];
            lb_sunday.Text = "Chủ nhật\r\n" + dateText["Sun"];
        }
        private void updateDateText()
        {
            // Cập nhật Dictionary `dateText` với chuỗi "dd/MM" từ Dictionary `dates`
            foreach (var day in dates.Keys)
            {
                DateTime date = dates[day];
                dateText[day] = date.Day.ToString("D2") + "/" + date.Month.ToString("D2");
            }
        }
        void LoadSlotsState() { 
            int totalFieldsForSport = GetTotalFieldsForSport();

            foreach (var day in dates.Keys)
            {
                DateTime date = dates[day];
                Dictionary<DateTime, int> bookingsCount = GetBookingsCountForDate(date);

                foreach (var time in timeDict[day].Keys)
                {
                    Button btn = timeDict[day][time];
                    DateTime slotDateTime = date.Date.AddHours(time);

                    int bookedFields = bookingsCount.ContainsKey(slotDateTime) ? bookingsCount[slotDateTime] : 0;
                    if (bookedFields >= totalFieldsForSport)
                    {
                        btn.BackColor = Color.Red;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = true;
                    }
                }
            }
        }
        private int GetTotalFieldsForSport()
        {
            int totalFields = 0;
            string query = "SELECT COUNT(*) FROM SANTHETHAO WHERE MALOAITT = @currentSport";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentSport", currentSport);
                    try
                    {
                        connection.Open();
                        totalFields = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving total fields: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return totalFields;
        }
        private Dictionary<DateTime, int> GetBookingsCountForDate(DateTime date)
        {
            Dictionary<DateTime, int> bookingsCount = new Dictionary<DateTime, int>();
            DateTime dayStart = date.Date;
            DateTime dayEnd = date.Date.AddDays(1);

            string query = @"
                SELECT CTHD.NGHDHLUC, COUNT(*) AS BookedFields
                FROM CTHD
                JOIN SANTHETHAO ON CTHD.MASANTT = SANTHETHAO.MASANTT
                WHERE SANTHETHAO.MALOAITT = @currentSport 
                AND CTHD.NGHDHLUC >= CAST(@dayStart AS smalldatetime) 
                AND CTHD.NGHDHLUC < CAST(@dayEnd AS smalldatetime)
                GROUP BY CTHD.NGHDHLUC
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@currentSport", currentSport);
                    command.Parameters.AddWithValue("@dayStart", dayStart);
                    command.Parameters.AddWithValue("@dayEnd", dayEnd);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime slotTime = reader.GetDateTime(0);
                                int count = reader.GetInt32(1);
                                bookingsCount[slotTime] = count;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return bookingsCount;
        }
        private void mCd_calendarDateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDates();
            GetPrice();
            LoadSlotsState();
            UpdateVerifyButtonState();
        }
        void GetPrice()
        {
            string query = @"
                select MALOAITT, GTSANG, GTTRUA, GTTOI
                from LOAITHETHAO
                where MALOAITT = @Sport";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sport", currentSport);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            decimal GTSang = 0m;
                            decimal GTTrua = 0m;
                            decimal GTToi = 0m;
                            int count = 0;

                            while (reader.Read())
                            {
                                decimal gtsang = reader.GetDecimal(1);
                                decimal gttrua = reader.GetDecimal(2);
                                decimal gttoi = reader.GetDecimal(3);

                                GTSang = gtsang;
                                GTTrua = gttrua;
                                GTToi = gttoi;
                                count++;
                            }

                            if (count > 0)
                            {
                                // Calculate average prices
                                slotPrices.Clear();
                                foreach (var day in dates.Keys)
                                {
                                    DateTime date = dates[day];
                                    foreach (var time in timeDict[day].Keys)
                                    {
                                        int hour = time;
                                        DateTime slotDateTime = date.Date.AddHours(hour);
                                        decimal price = 0m;

                                        if (hour >= 7 && hour < 13)
                                        {
                                            price = GTSang;
                                        }
                                        else if (hour >= 13 && hour < 18)
                                        {
                                            price = GTTrua;
                                        }
                                        else if (hour >= 18 && hour < 22)
                                        {
                                            price = GTToi;
                                        }

                                        slotPrices[slotDateTime] = price;
                                    }
                                }

                                // Update labels
                                lb_MorningPrice.Text = $"{GTSang:C}";
                                lb_AfternoonPrice.Text = $"{GTTrua:C}";
                                lb_EveningPrice.Text = $"{GTToi:C}";

                            }
                            else
                            {
                                lb_MorningPrice.Text = "N/A";
                                lb_AfternoonPrice.Text = "N/A";
                                lb_EveningPrice.Text = "N/A";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Đã xảy ra lỗi khi tải thông tin giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
 
        private void TimeSlotButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;
        }
        private void UpdateVerifyButtonState()
        {
            btn_Verify.Enabled = selectedSlots.Count > 0;
        }
        private string GenerateInvoiceNumber()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
        }
        private string GetAvailableField(DateTime slot, SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
                SELECT TOP 1 MASANTT
                FROM SANTHETHAO
                WHERE MALOAITT = @Sport AND MASANTT NOT IN (
                    SELECT MASANTT FROM CTHD WHERE NGHDHLUC = @Slot
                )
            ";

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Sport", currentSport);
                cmd.Parameters.AddWithValue("@Slot", slot);

                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
        }
}
