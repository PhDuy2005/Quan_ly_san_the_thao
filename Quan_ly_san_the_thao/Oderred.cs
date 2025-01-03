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
    public partial class Oderred : Form
    {
        DataRow userData;
        public Oderred(DataRow user)
        {
            InitializeComponent();
            this.userData = user;
            LoadData();
        }
        void LoadData()
        {
            // Load data from database
            string DBquery = @"select hd.MAHD, TENSANTT, TENLOAITT, NGHDHLUC, TRIGIA from KHACHHANG kh join HOADON hd on kh.USERNAME = hd.USERNAME
                join CTHD ct on hd.MAHD = ct.MAHD
                join SANTHETHAO stt on stt.MASANTT = ct.MASANTT
                join LOAITHETHAO ltt on ltt.MALOAITT = stt.MALOAITT
                where kh.USERNAME = @USERNAME";
            string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(DBquery, connection);
                command.Parameters.AddWithValue("@USERNAME", userData["USERNAME"].ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_OderredInfo.DataSource = dataTable;
                dgv_OderredInfo.Columns["MAHD"].HeaderText = "Mã hóa đơn";
                dgv_OderredInfo.Columns["TENSANTT"].HeaderText = "Tên sân";
                dgv_OderredInfo.Columns["TENLOAITT"].HeaderText = "Môn thể thao";
                dgv_OderredInfo.Columns["NGHDHLUC"].HeaderText = "Giờ thuê";
                dgv_OderredInfo.Columns["TRIGIA"].HeaderText = "Trị giá";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
