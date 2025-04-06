using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TimekeepingDAL
    {
        private readonly string connectionString;

        public TimekeepingDAL()
        {
            Database db = new Database();
            connectionString = db.GetConnectionString();
        }

        public void SaveAttendance(int employeeId, DateTime date, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CHAMCONG (maNV, Thoigian, MaLC) VALUES (@maNV, @Thoigian, @MaLC)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maNV", employeeId);
                    cmd.Parameters.AddWithValue("@Thoigian", date);
                    cmd.Parameters.AddWithValue("@MaLC", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetTimekeeping(int month, int year)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM CHAMCONG WHERE MONTH(Thoigian) = @Month AND YEAR(Thoigian) = @Year";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
