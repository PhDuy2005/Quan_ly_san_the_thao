using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public partial class Payment : Form
    {
        List<BookingDetail> bookingDetails = new List<BookingDetail>();
        private DataRow userData;
        private string mahd;
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";

        public Payment(DataRow user, string mahd)
        {
            InitializeComponent();
            this.userData = user;
            this.mahd = mahd;
            DisplayInformation();
            ExportBill();
        }

        private void DisplayInformation()
        {
            // Set user information
            lb_Name.Text = userData["TENKH"].ToString();
            lb_Phone.Text = userData["SDT"].ToString();

            // Query the database to get invoice and booking details
            string queryInvoice = @"
                SELECT HOADON.MAHD, HOADON.NGTTOAN, HOADON.TRIGIA
                FROM HOADON
                WHERE MAHD = @MAHD
            ";

            string queryBookingDetails = @"
                SELECT CTHD.MASANTT, CTHD.NGHDHLUC, SANTHETHAO.TENSANTT, 
                        LOAITHETHAO.GTSANG, LOAITHETHAO.GTTRUA, LOAITHETHAO.GTTOI
                FROM CTHD
                INNER JOIN SANTHETHAO ON CTHD.MASANTT = SANTHETHAO.MASANTT
                JOIN LOAITHETHAO on LOAITHETHAO.MALOAITT = SANTHETHAO.MALOAITT
                WHERE CTHD.MAHD = @MAHD
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get invoice information
                    SqlCommand cmdInvoice = new SqlCommand(queryInvoice, connection);
                    cmdInvoice.Parameters.AddWithValue("@MAHD", mahd);

                    SqlDataReader readerInvoice = cmdInvoice.ExecuteReader();
                    DateTime ngttoan = DateTime.Now;
                    decimal trigia = 0m;

                    if (readerInvoice.Read())
                    {
                        ngttoan = readerInvoice.GetDateTime(readerInvoice.GetOrdinal("NGTTOAN"));
                        trigia = readerInvoice.GetDecimal(readerInvoice.GetOrdinal("TRIGIA"));

                        lb_ReserveDate.Text = ngttoan.ToString("dd/MM/yyyy");
                        lb_Total.Text = trigia.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    readerInvoice.Close();

                    // Get booking details
                    SqlCommand cmdBooking = new SqlCommand(queryBookingDetails, connection);
                    cmdBooking.Parameters.AddWithValue("@MAHD", mahd);

                    SqlDataReader readerBooking = cmdBooking.ExecuteReader();
                    List<DateTime> slotTimes = new List<DateTime>();
                    bookingDetails = new List<BookingDetail>();

                    while (readerBooking.Read())
                    {
                        string masantt = readerBooking.GetString(readerBooking.GetOrdinal("MASANTT"));
                        string tensantt = readerBooking.GetString(readerBooking.GetOrdinal("TENSANTT"));
                        DateTime nghdhluc = readerBooking.GetDateTime(readerBooking.GetOrdinal("NGHDHLUC"));

                        decimal unitPrice = 0m;
                        int hour = nghdhluc.Hour;

                        // Determine unit price based on time of day
                        if (hour >= 7 && hour < 13)
                        {
                            unitPrice = readerBooking.GetDecimal(readerBooking.GetOrdinal("GTSANG"));
                        }
                        else if (hour >= 13 && hour < 18)
                        {
                            unitPrice = readerBooking.GetDecimal(readerBooking.GetOrdinal("GTTRUA"));
                        }
                        else if (hour >= 18 && hour < 22)
                        {
                            unitPrice = readerBooking.GetDecimal(readerBooking.GetOrdinal("GTTOI"));
                        }

                        bookingDetails.Add(new BookingDetail
                        {
                            Field = tensantt,
                            RentTime = nghdhluc,
                            UnitPrice = unitPrice,
                            Discount = 0m
                        });

                        slotTimes.Add(nghdhluc);
                    }
                    readerBooking.Close();

                    if (slotTimes.Count > 0)
                    {
                        DateTime earliestSlot = slotTimes.Min();
                        lb_ChkInDate.Text = earliestSlot.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        lb_ChkInDate.Text = "N/A";
                    }

                    // Configure and populate DataGridView
                    ConfigureDataGridView();
                    PopulateDataGridView(bookingDetails);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi tải thông tin: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigureDataGridView()
        {
            dgv_FieldInfo.Columns.Clear();

            DataGridViewTextBoxColumn cl_Field = new DataGridViewTextBoxColumn
            {
                Name = "cl_Field",
                HeaderText = "Sân",
                ReadOnly = true
            };
            dgv_FieldInfo.Columns.Add(cl_Field);

            DataGridViewTextBoxColumn cl_RentTime = new DataGridViewTextBoxColumn
            {
                Name = "cl_RentTime",
                HeaderText = "Thời gian thuê",
                ReadOnly = true
            };
            dgv_FieldInfo.Columns.Add(cl_RentTime);

            DataGridViewTextBoxColumn cl_UnitPrice = new DataGridViewTextBoxColumn
            {
                Name = "cl_UnitPrice",
                HeaderText = "Đơn giá",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            };
            dgv_FieldInfo.Columns.Add(cl_UnitPrice);

            DataGridViewTextBoxColumn cl_Discount = new DataGridViewTextBoxColumn
            {
                Name = "cl_Discount",
                HeaderText = "Giảm giá",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
            };
            dgv_FieldInfo.Columns.Add(cl_Discount);

            dgv_FieldInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PopulateDataGridView(List<BookingDetail> bookingDetails)
        {
            dgv_FieldInfo.Rows.Clear();

            foreach (var detail in bookingDetails)
            {
                dgv_FieldInfo.Rows.Add(
                    detail.Field,
                    detail.RentTime.ToString("dd/MM/yyyy HH:mm"),
                    detail.UnitPrice.ToString("C0"),
                    detail.Discount.ToString("C0")
                );
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xác nhận thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Display booking code (invoice number)
                MessageBox.Show($"Hãy đến thanh toán trực tiếp tại sân và trình ra mã hóa đơn:\n{mahd}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                // Navigate back to the sport selection form
                SportListForm sportListForm = new SportListForm(userData["USERNAME"].ToString());
                sportListForm.Show();
            }
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        void ExportBill()
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;

                if (Path.GetExtension(filePath) == "")
                {
                    filePath = Path.Combine(filePath, "exportData.xlsx");
                }
            }
            else
            {
                MessageBox.Show("Mở file thất bại");
                return;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn hóa đơn không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    string sheetName = "Báo cáo";
                    p.Workbook.Properties.Author = "Duy Pham Tran Khanh";
                    p.Workbook.Worksheets.Add(sheetName);

                    ExcelWorksheet ws = p.Workbook.Worksheets[sheetName];
                    ws.Name = sheetName;
                    ws.Cells.Style.Font.Size = 11;
                    ws.Cells.Style.Font.Name = "Times New Roman";

                    List<string> columnHeaders = new List<string>();
                    columnHeaders.AddRange(new string[]
                        {
                            "Sân thể thao",
                            "Thời gian thuê",
                            "Đơn giá",
                            "Chiết khấu",
                        });

                    int headerRow = 2;
                    int columnIndex = 1;
                    int headerCount = columnHeaders.Count;
                    foreach (var header in columnHeaders)
                    {
                        var cell = ws.Cells[headerRow, columnIndex];
                        cell.Value = header;
                        columnIndex++;
                    }
                    string head = "HÓA ĐƠN " + mahd;
                    ws.Cells[1, 1].Value = head;
                    ws.Cells[1, 1, 1, headerCount].Merge = true;
                    ws.Cells[1, 1, 1, headerCount].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, headerCount].Style.Font.Size = 16;
                    ws.Cells[1, 1, 1, headerCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    
                    int rowIndex = headerRow + 1;
                    int sum = 0;
                    foreach (var question in bookingDetails)
                    {
                        ws.Cells[rowIndex, 1].Value = question.Field;
                        ws.Cells[rowIndex, 2].Value = question.RentTime.ToString();
                        sum += (int)question.UnitPrice;
                        ws.Cells[rowIndex, 3].Value = question.UnitPrice;
                        ws.Cells[rowIndex, 4].Value = question.Discount;
                        //ws.Cells[rowIndex, 5].Value = question.OptionC;
                        //ws.Cells[rowIndex, 6].Value = question.OptionD;

                        //ws.Cells[rowIndex, 7].Value = question.GetStudentAnswer();
                        //ws.Cells[rowIndex, 8].Value = question.GetCorrectAnswer();
                        //ws.Cells[rowIndex, 9].Value = question.getScore();
                        //ws.Cells[rowIndex, 10].Value = question.GetMaxScore();
                        //ws.Cells[rowIndex, 11].Value = question.Note;
                        rowIndex++;
                    }
                    ws.Cells[rowIndex, 1].Value = "Tổng cộng";
                    ws.Cells[rowIndex, 1, rowIndex, 2].Merge = true;
                    ws.Cells[rowIndex, 3].Value = sum;

                    ws.Cells[ws.Dimension.Address].AutoFitColumns();

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                    MessageBox.Show($"Xuất file thành công! tại {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi lưu file {ex.Message}");
            }

        }

        // Helper class to store booking details
        private class BookingDetail
        {
            public string Field { get; set; }
            public DateTime RentTime { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Discount { get; set; }
        }
        
    }
}
