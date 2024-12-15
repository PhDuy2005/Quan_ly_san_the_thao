using System;
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
    public partial class Payment : Form
    {
        private DataRow userData;
        private string mahd;
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";

        public Payment(DataRow user, string mahd)
        {
            InitializeComponent();
            this.userData = user;
            this.mahd = mahd;
            DisplayInformation();
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
                       SANTHETHAO.GTSANG, SANTHETHAO.GTTRUA, SANTHETHAO.GTTOI
                FROM CTHD
                INNER JOIN SANTHETHAO ON CTHD.MASANTT = SANTHETHAO.MASANTT
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
                    List<BookingDetail> bookingDetails = new List<BookingDetail>();

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
