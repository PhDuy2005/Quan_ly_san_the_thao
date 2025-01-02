using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.IO;
using OfficeOpenXml;
using System.Data.SqlClient;

namespace Quan_ly_san_the_thao
{
    public partial class AdminStat : Form
    {
        string sportName = "";
        string sportType = "";
        DataTable dataTable = new DataTable();
        public AdminStat()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd 'Tháng' MM 'Năm' yyyy";
            dateTimePicker2.Format = dateTimePicker1.Format;
            dateTimePicker2.CustomFormat = dateTimePicker1.CustomFormat;
            comboBox1.SelectedIndex = 0;
        }

        void getData()
        {
            // Lấy dữ liệu từ database
            string query = @"SELECT LOAITHETHAO.MALOAITT, COALESCE(SUM(HOADON.TRIGIA), 0) AS TotalMoney, COUNT(CTHD.NGHDHLUC) AS TotalHour
                        FROM LOAITHETHAO LEFT JOIN SANTHETHAO ON LOAITHETHAO.MALOAITT = SANTHETHAO.MALOAITT
                        LEFT JOIN CTHD ON SANTHETHAO.MASANTT = CTHD.MASANTT AND CTHD.NGHDHLUC BETWEEN @NGBD AND @NGKT
                        LEFT JOIN HOADON ON CTHD.MAHD = HOADON.MAHD
                        GROUP BY LOAITHETHAO.MALOAITT
                        ORDER BY LOAITHETHAO.MALOAITT";
            string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NGBD", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@NGKT", dateTimePicker2.Value.AddDays(1));
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
        }

        private void AdminStat_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void btn_GetStatFile_Click(object sender, EventArgs e)
        {
            getData();
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
                MessageBox.Show("Đường dẫn không hợp lệ");
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
                            "Bóng đá",
                            "Bóng chuyền",
                            "Bóng rổ",
                            "Cầu lông"
                        });
                    int headerRow = 2;
                    int columnIndex = 2;
                    int headerCount = columnHeaders.Count;
                    foreach (var header in columnHeaders)
                    {
                        var cell = ws.Cells[headerRow, columnIndex];
                        cell.Value = header;
                        columnIndex++;
                    }
                    ws.Cells[1, 1].Value = "BÁO CÁO DOANH THU";
                    ws.Cells[1, 1, 1, headerCount + 1].Merge = true;
                    ws.Cells[1, 1, 1, headerCount + 1].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, headerCount + 1].Style.Font.Size = 12;
                    ws.Cells[1, 1, 1, headerCount + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    ws.Cells[3, 1].Value = "Tổng giờ thuê";
                    ws.Cells[4, 1].Value = "Tổng thu";

                    ws.Cells[3, 2].Value = dataTable.Rows[0]["TotalHour"];
                    ws.Cells[4, 2].Value = dataTable.Rows[0]["TotalMoney"];

                    ws.Cells[3, 3].Value = dataTable.Rows[1]["TotalHour"];
                    ws.Cells[4, 3].Value = dataTable.Rows[1]["TotalMoney"];

                    ws.Cells[3, 4].Value = dataTable.Rows[2]["TotalHour"];
                    ws.Cells[4, 4].Value = dataTable.Rows[2]["TotalMoney"];

                    ws.Cells[3, 5].Value = dataTable.Rows[3]["TotalHour"];
                    ws.Cells[4, 5].Value = dataTable.Rows[3]["TotalMoney"];

                    ws.Cells[1, 7].Value = "Từ ngày " + dateTimePicker1.Value.ToShortDateString();
                    ws.Cells[2, 7].Value = "Đến ngày " + dateTimePicker2.Value.ToShortDateString();

                    ws.Cells[5, 1].Value = "Tổng doanh thu";
                    ws.Cells[5, 1, 5, headerCount].Merge = true;
                    ws.Cells[5, 1, 5, headerCount].Style.Font.Bold = true;
                    ws.Cells[5, 1, 5, headerCount].Style.Font.Size = 12;
                    ws.Cells[5, 1, 5, headerCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                    ws.Cells[5, headerCount + 1].Formula = $"SUM(B4:E4)";
                    ws.Cells[5, headerCount + 1].Style.Font.Bold = true;
                    ws.Cells[5, headerCount + 1].Style.Font.Size = 12;

                    ws.Cells[ws.Dimension.Address].AutoFitColumns();
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                    MessageBox.Show($"Xuất file thành công! tại {filePath}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
