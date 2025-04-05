using System;
using System.Data;
using System.Data.SqlClient;
using DAO;  // Đảm bảo namespace DAO đã được gọi

namespace BUS
{
    public class TimekeepingBUS
    {
        private readonly string connectionString;
        private TimekeepingDAL timekeepingDAL; // Khai báo DAL

        public TimekeepingBUS()
        {
            Database db = new Database();
            connectionString = db.GetConnectionString();
            timekeepingDAL = new TimekeepingDAL();
        }

        public void MarkAttendance(int year, int month, int day, int employeeId, string status)
        {
            DateTime date = new DateTime(year, month, day);
            timekeepingDAL.SaveAttendance(employeeId, date, status);
        }

        public DataTable GetTimekeeping(int month, int year)
        {
            return timekeepingDAL.GetTimekeeping(month, year);
        }
    }
}
