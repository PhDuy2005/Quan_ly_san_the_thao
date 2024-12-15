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
            LoadSlotsInfo();
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
            LoadSlotsInfo();
            UpdateVerifyButtonState();
        }
        void GetPrice()
        {
            string query = @"
           SELECT MASANTT, GTSANG, GTTRUA, GTTOI
           FROM SANTHETHAO
           WHERE MALOAITT = @Sport";
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

                                GTSang += gtsang;
                                GTTrua += gttrua;
                                GTToi += gttoi;
                                count++;
                            }

                            if (count > 0)
                            {
                                // Calculate average prices
                                decimal avgGTSang = GTSang / count;
                                decimal avgGTTrua = GTTrua / count;
                                decimal avgGTToi = GTToi / count;

                                // Update labels
                                lb_MorningPrice.Text = $"{avgGTSang:C}";
                                lb_AfternoonPrice.Text = $"{avgGTTrua:C}";
                                lb_EveningPrice.Text = $"{avgGTToi:C}";
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
        private void LoadSlotsInfo()
        {
            slotPrices.Clear();
            DateTime startDate = dates["Mon"];
            DateTime endDate = dates["Sun"];
            string query = @"
           SELECT MASANTT, GTSANG, GTTRUA, GTTOI
           FROM SANTHETHAO
           WHERE MALOAITT = @Sport";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Sport", currentSport);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        decimal totalGTSang = 0m;
                        decimal totalGTTrua = 0m;
                        decimal totalGTToi = 0m;
                        int count = 0;

                        while (reader.Read())
                        {
                            decimal gtsang = reader.GetDecimal(1);
                            decimal gttrua = reader.GetDecimal(2);
                            decimal gttoi = reader.GetDecimal(3);

                            totalGTSang += gtsang;
                            totalGTTrua += gttrua;
                            totalGTToi += gttoi;
                            count++;
                        }

                        if (count > 0)
                        {
                            // Calculate average prices
                            decimal avgGTSang = totalGTSang / count;
                            decimal avgGTTrua = totalGTTrua / count;
                            decimal avgGTToi = totalGTToi / count;

                            // Update labels
                            lb_MorningPrice.Text = $"{avgGTSang:C}";
                            lb_AfternoonPrice.Text = $"{avgGTTrua:C}";
                            lb_EveningPrice.Text = $"{avgGTToi:C}";
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
            UpdateTotalPrice();
            UpdateVerifyButtonState();
        }
        private void TimeSlotButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;

            // Xác định ngày và giờ từ tên nút
            // Giả sử tên nút theo định dạng btn_DayTime, ví dụ: btn_Monday7AM
            string buttonName = clickedButton.Name; // Ví dụ: btn_Monday7AM

            string[] parts = { buttonName.Substring(4, 3), buttonName.Substring(buttonName.Length - 4, 4) };
            if (char.IsDigit(parts[1][0]) == false)
            {
                parts[1] = parts[1].Substring(1, 3);
            }
            string dayAbbr = parts[0].Substring(0, 3); // Ví dụ: "Mon"
            string timePart = parts[1]; // Ví dụ: "7AM"
            int hour = -1;

            // Tách số giờ và phần AM/PM
            string hourPart = timePart.Substring(0, timePart.Length - 2); // Lấy số giờ
            string meridian = timePart.Substring(timePart.Length - 2).ToUpper(); // Lấy AM/PM

            // Kiểm tra và chuyển đổi giờ
            try
            {
                if (int.TryParse(hourPart, out hour))
                {
                    if (meridian == "PM" && hour != 12) // Thêm 12 giờ cho PM (trừ 12PM)
                    {
                        hour += 12;
                    }
                    else if (meridian == "AM" && hour == 12) // Chuyển 12AM thành 0 giờ
                    {
                        hour = 0;
                    }
                }
                else
                {
                    // Xử lý lỗi nếu không thể parse
                    throw new FormatException("Invalid time format: " + timePart);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Lỗi: " + ee.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            // Lấy ngày tương ứng từ dictionary
            if (!dates.ContainsKey(dayAbbr))
                return;

            DateTime slotDate = dates[dayAbbr];
            DateTime fullDateTime = slotDate.Date.AddHours(hour);

            if (!slotPrices.ContainsKey(fullDateTime))
            {
                MessageBox.Show("Không tìm thấy thông tin giá cho slot này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedSlots.Contains(fullDateTime))
            {
                selectedSlots.Remove(fullDateTime);
                clickedButton.BackColor = SystemColors.Control;
            }
            else
            {
                selectedSlots.Add(fullDateTime);
                clickedButton.BackColor = Color.LightGreen;
            }
            UpdateTotalPrice();
            UpdateVerifyButtonState();
        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0m;
            foreach (var slot in selectedSlots)
            {
                if (slotPrices.ContainsKey(slot))
                {
                    totalPrice += slotPrices[slot];
                }
            }
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
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            if (selectedSlots.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một khung giờ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mahd = GenerateInvoiceNumber();
            totalPrice = selectedSlots.Sum(slot => slotPrices.ContainsKey(slot) ? slotPrices[slot] : 0m);
            string insertHoaDonQuery = @"
                INSERT INTO HOADON (MAHD, USERNAME, NGTTOAN, TRIGIA)
                VALUES (@MAHD, @USERNAME, @NGTTOAN, @TRIGIA)
            ";

            string insertCTHDQuery = @"
                INSERT INTO CTHD (MAHD, MASANTT, NGHDHLUC, TTGTSANG, TTGTTRUA, TTGTTOI)
                VALUES (@MAHD, @MASANTT, @NGHDHLUC, @TTGTSANG, @TTGTTRUA, @TTGTTOI)
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdHoaDon = new SqlCommand(insertHoaDonQuery, connection);
                SqlCommand cmdCTHD = new SqlCommand(insertCTHDQuery, connection);

                cmdHoaDon.Parameters.AddWithValue("@MAHD", mahd);
                cmdHoaDon.Parameters.AddWithValue("@USERNAME", userData["USERNAME"].ToString());
                cmdHoaDon.Parameters.AddWithValue("@NGTTOAN", DateTime.Now);
                cmdHoaDon.Parameters.AddWithValue("@TRIGIA", totalPrice);

                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    cmdHoaDon.Transaction = transaction;
                    cmdCTHD.Transaction = transaction;
                    cmdHoaDon.ExecuteNonQuery();
                    foreach (var slot in selectedSlots)
                    {
                        bool isMorning = slot.Hour >= 7 && slot.Hour < 13;
                        bool isAfternoon = slot.Hour >= 13 && slot.Hour < 18;
                        bool isEvening = slot.Hour >= 18 && slot.Hour < 22;
                        string masantt = GetAvailableField(slot, connection, transaction);

                        if (string.IsNullOrEmpty(masantt))
                        {
                            MessageBox.Show("Không có sân nào khả dụng cho thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        cmdCTHD.Parameters.Clear();
                        cmdCTHD.Parameters.AddWithValue("@MAHD", mahd);
                        cmdCTHD.Parameters.AddWithValue("@MASANTT", masantt);
                        cmdCTHD.Parameters.AddWithValue("@NGHDHLUC", slot);
                        cmdCTHD.Parameters.AddWithValue("@TTGTSANG", isMorning ? 1 : 0);
                        cmdCTHD.Parameters.AddWithValue("@TTGTTRUA", isAfternoon ? 1 : 0);
                        cmdCTHD.Parameters.AddWithValue("@TTGTTOI", isEvening ? 1 : 0);

                        cmdCTHD.ExecuteNonQuery();
                    }

                    // Commit transaction
                    transaction.Commit();

                    // Proceed to payment form
                    Payment paymentForm = new Payment(userData, mahd);
                    this.Hide();
                    paymentForm.ShowDialog();
                    this.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi lưu thông tin đặt sân: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TimeSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
