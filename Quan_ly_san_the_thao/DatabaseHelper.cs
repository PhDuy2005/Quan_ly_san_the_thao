﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_san_the_thao
{
    public class DatabaseHelper
    {
        private string connectionString = @"Data Source=.\MSSQLSERVER01;Initial Catalog=IT8_PROJECT_DATABASE;Integrated Security=True";

        public DataRow GetUserDetails(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenKH, USERNAME, SDT, GTinh, EMAIL, LOAI FROM Users WHERE Username = @Username";
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
    }
}
