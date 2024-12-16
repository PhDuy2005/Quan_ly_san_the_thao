using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_san_the_thao
{
    public class DatabaseHelper
    {
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";

        /// <summary>
        /// <para>Get the username and password of a user</para>
        /// </summary>
        /// <param name="username">string, username</param>
        /// <returns>DataRow, gồm 2 trường là USERNAME và PSSWRD</returns>
        public DataRow GetUsernameAndPwd(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT USERNAME, PASSWRD FROM KHACHHANG WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                    return dataTable.Rows[0];
                return null;
            }
        }
        public DataRow GetUsernameAndPwdByPhoneNumber(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT USERNAME, PASSWRD FROM KHACHHANG WHERE SDT = @PhoneNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                    return dataTable.Rows[0];
                return null;
            }
        }

        public DataRow GetUserDetails(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenKH, USERNAME, SDT, GTinh, EMAIL FROM KHACHHANG WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                    return dataTable.Rows[0];
                return null;
            }
        }
        public DataRow GetUserDetailsByPhoneNumber(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KHACHHANG WHERE SDT = @PhoneNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                    return dataTable.Rows[0];
                return null;
            }
        }

        public bool VerifyCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE USERNAME = @Username AND PASSWRD = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool UpdateCustomerInfo(string fullname, string phoneNumber, bool gender, string email, string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE KHACHHANG
                                 SET TENKH = @FullName, 
                                     SDT = @PhoneNumber, 
                                     GTINH = @Gender, 
                                     EMAIL = @Email
                                 WHERE USERNAME = @Username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", fullname);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                //bool bitGender;
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool CheckIfUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE USERNAME = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool InsertNewUser(string username, string password, string fullName, string email, string phoneNumber, bool gender)
        {
            string query = @"
            INSERT INTO KHACHHANG (USERNAME, PASSWRD, TENKH, EMAIL, SDT, GTINH)
            VALUES (@Username, @Password, @FullName, @Email, @PhoneNumber, @Gender)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", gender);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CheckPhoneNumberExists(string phoneNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM KHACHHANG WHERE SDT = @PhoneNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                connection.Open();
                int count = (int)command.ExecuteScalar(); // Return the count of matching records
                return count > 0; // Return true if at least one match is found
            }
        }

        public bool UpdatePassword(string username, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE KHACHHANG
                                 SET PASSWRD = @NewPassword
                                 WHERE USERNAME = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if the update was successful
            }
        }
        public bool[] GetFieldStatus(string MaLoaiTT, DateTime date, int startHour)
        {
            bool[] fieldStatus = new bool[3] {false, false, false };
            string[] MaSanTT = new string[] { "", "", ""};
            //Dữ liệu trong db (select * from SANTHETHAO order by MALOAITT asc, TENSANTT asc):
            //SANTT01 LOAITT01    San bong da so 1
            //SANTT02 LOAITT01    San bong da so 2
            //SANTT03 LOAITT01    San bong da so 3
            //SANTT04 LOAITT02    San bong chuyen so 1
            //SANTT05 LOAITT02    San bong chuyen so 2
            //SANTT06 LOAITT02    San bong chuyen so 3
            //SANTT07 LOAITT03    San bong ro so 1
            //SANTT08 LOAITT03    San bong ro so 2
            //SANTT09 LOAITT03    San bong ro so 3
            //SANTT010 LOAITT04    San cau long so 1
            //SANTT011 LOAITT04    San cau long so 2
            //SANTT012 LOAITT04    San cau long so 3
            switch (MaLoaiTT)
            {
                case "LOAITT01":
                    MaSanTT = new string[] { "SANTT01", "SANTT02", "SANTT03" };
                    break;
                case "LOAITT02":
                    MaSanTT = new string[] { "SANTT04", "SANTT05", "SANTT06" };
                    break;
                case "LOAITT03":
                    MaSanTT = new string[] { "SANTT07", "SANTT08", "SANTT09" };
                    break;
                case "LOAITT04":
                    MaSanTT = new string[] { "SANTT010", "SANTT011", "SANTT012" };
                    break;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"select TTGTSANG, TTGTTRUA, TTGTTOI, NGHDHLUC, MASANTT from CTHD
                where MASANTT in (@San1, @San2, @San3)
                and NGHDHLUC >= CAST(@StartDate as smalldate)
                and NGHDHLUC < CAST(@EndDate as smalldate);";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", date);
                command.Parameters.AddWithValue("@EndDate", date.Date.AddDays(1));
                command.Parameters.AddWithValue("@San1", MaSanTT[0]);
                command.Parameters.AddWithValue("@San2", MaSanTT[1]);
                command.Parameters.AddWithValue("@San3", MaSanTT[2]);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                byte[] bytes;
                int index;

                foreach (DataRow row in dataTable.Rows)
                {
                    
                    if (startHour >= 7 && startHour <= 10)
                    {
                        bytes = row["TTGTSANG"] as byte[];
                        index = startHour - 7;
                    }
                    else if (startHour >= 13 && startHour <= 16)
                    {
                        bytes = row["TTGTTRUA"] as byte[];
                        index = startHour - 13;
                    }
                    else
                    {
                        bytes = row["TTGTTOI"] as byte[];
                        index = startHour - 18;
                    }

                    if (bytes[index] == '1' && row["MASANTT"] == MaSanTT[0])
                    {
                        fieldStatus[0] = true;
                    }
                    else if (bytes[index] == '1' && row["MASANTT"] == MaSanTT[1])
                    {
                        fieldStatus[1] = true;
                    }
                    else if (bytes[index] == '1' && row["MASANTT"] == MaSanTT[2])
                    {
                        fieldStatus[2] = true;
                    }
                }
                return fieldStatus;
            }
            return null;
        }
        public string ToBinary4Bit(int number)
        {
            // Chuyển số sang chuỗi nhị phân
            string binary = Convert.ToString(number, 2);

            // Nếu chuỗi ngắn hơn 4 ký tự, thêm số 0 ở đầu
            if (binary.Length < 4)
            {
                binary = binary.PadLeft(4, '0');
            }
            // Nếu chuỗi dài hơn 4 ký tự, lấy 4 ký tự cuối
            else if (binary.Length > 4)
            {
                binary = binary.Substring(binary.Length - 4);
            }

            return binary;
        }
        public int FromBinary4Bit(string binary)
        {
            // Kiểm tra chuỗi có đúng 4 ký tự và chỉ chứa '0' hoặc '1'
            if (binary.Length != 4 || !System.Text.RegularExpressions.Regex.IsMatch(binary, "^[01]+$"))
            {
                throw new ArgumentException("Chuỗi phải là nhị phân 4 bit hợp lệ.");
            }

            // Chuyển chuỗi nhị phân sang số nguyên
            return Convert.ToInt32(binary, 2);
        }
        public int ByteArrayToInt(byte[] byteArray)
        {
            // Kiểm tra kích thước mảng (cần <= 4 byte để chuyển sang int)
            if (byteArray.Length > 4)
            {
                throw new ArgumentException("Mảng byte vượt quá kích thước của một số nguyên (4 byte).");
            }

            // Nếu mảng byte nhỏ hơn 4 byte, thêm 0 vào đầu (padding)
            byte[] paddedArray = new byte[4];
            Buffer.BlockCopy(byteArray, 0, paddedArray, 4 - byteArray.Length, byteArray.Length);

            return BitConverter.ToInt32(paddedArray, 0);
        }
    }
}
