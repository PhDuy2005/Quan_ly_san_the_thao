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
    public partial class Payment : Form
    {
        private DataRow userData;
        private string currentSport;
        private List<DateTime> selectedSlots;
        private Dictionary<DateTime, decimal> slotPrices;
        private decimal totalPrice;
        private string bookingCode;
        public Payment(DataRow user, string sport, List<DateTime> slots, Dictionary<DateTime, decimal> prices, decimal price)
        {
            InitializeComponent();
            this.userData = user;
            this.currentSport = sport;
            this.selectedSlots = slots;
            this.slotPrices = prices;
            this.totalPrice = price;
            DisplayInformation();
        }
        private void DisplayInformation()
        {
            lb_Name.Text = userData["USERNAME"].ToString();
            lb_Phone.Text = userData["SDT"].ToString();
            if (selectedSlots.Count > 0)
            {
                DateTime reserveDate = selectedSlots.Min();
                DateTime checkInDate = selectedSlots.Max();

                lb_ReserveDate.Text = reserveDate.ToString("dd/MM/yyyy");
                lb_ChkInDate.Text = checkInDate.ToString("dd/MM/yyyy");
            }
            else
            {
                lb_ReserveDate.Text = "N/A";
                lb_ChkInDate.Text = "N/A";
            }
            ConfigureDataGridView();
            PopulateDataGridView();
            lb_Total.Text = totalPrice.ToString();
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
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }
            };
            dgv_FieldInfo.Columns.Add(cl_UnitPrice);

            DataGridViewTextBoxColumn cl_Discount = new DataGridViewTextBoxColumn
            {
                Name = "cl_Discount",
                HeaderText = "Giảm giá",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C" }
            };
            dgv_FieldInfo.Columns.Add(cl_Discount);
            dgv_FieldInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PopulateDataGridView()
        {
            dgv_FieldInfo.Rows.Clear();

            foreach (var slot in selectedSlots)
            {
                string fieldName = currentSport;
                string rentTime = slot.ToString("dd/MM/yyyy HH:mm");
                decimal unitPrice = slotPrices.ContainsKey(slot) ? slotPrices[slot] : 0m;
                decimal discount = 0m;

                dgv_FieldInfo.Rows.Add(fieldName, rentTime, unitPrice, discount);
            }
        }
        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private string GenerateBookingCode()
        {
            return "BK" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xác nhận thanh toán không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bookingCode = GenerateBookingCode();
                MessageBox.Show($"Hãy đến thanh toán trực tiếp tại sân và trình ra mã đặt sân:\n{bookingCode}", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                SportListForm sportListForm = new SportListForm(userData["USERNAME"].ToString());
                sportListForm.Show();
            }
        }
    }
}
