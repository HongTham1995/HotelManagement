using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class Database
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public string serverName = "HOANG\\MSSQLSERVERHOANG";
        public string dbName = "QLKS_DN";
        public string userName = "sa";
        public string password = "";
        private string connectionString;


        public Database()
        {
            connectionString = $"Server={serverName}; Database={dbName}; Integrated Security=True; TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);
        }

        public string GetConnectionString()
        {
            return connectionString;
        }
        public SqlConnection OpenConnection()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string is not initialized.");
            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }


        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return rowsAffected;
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public DataTable getList(string query)
        {
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

    

        public int ExecuteNonQuery_getInteger(string query)
        {
            int num;
            conn.Open(); query += " SELECT SCOPE_IDENTITY() as int";
            SqlCommand cmd = new SqlCommand(query, conn);
            num = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return num;
        }

        public List<PhongDTO> getListPhong_DTO(string query)
        {
            List<PhongDTO> list = new List<PhongDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PhongDTO phong = new PhongDTO();
                phong.MaP = reader[0].ToString();
                phong.TenP = reader[1].ToString();
                phong.LoaiP = int.Parse(reader[2].ToString());
                phong.GiaP = int.Parse(reader[3].ToString());
                phong.ChiTietLoaiP = int.Parse(reader[4].ToString());
                phong.TinhTrang = int.Parse(reader[5].ToString());
                phong.HienTrang = int.Parse(reader[6].ToString());
                phong.XuLy = int.Parse(reader[7].ToString());
                list.Add(phong);
            }
            conn.Close();
            return list;
        }
        public List<ChiTietThueDTO> getListCTT_DTO(string query)
        {
            List<ChiTietThueDTO> list = new List<ChiTietThueDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietThueDTO ctt = new ChiTietThueDTO();
                ctt.MaCTT = reader[0].ToString();
                ctt.MaKH = reader[1].ToString();
                ctt.MaNV = reader[2].ToString();
                ctt.NgayLapPhieu = DateTime.Parse(reader[3].ToString());
                ctt.TienDatCoc = int.Parse(reader[4].ToString());
                ctt.TinhTrangXuLy = int.Parse(reader[5].ToString());
                ctt.XuLy = int.Parse(reader[6].ToString());
                list.Add(ctt);
            }
            conn.Close();
            return list;
        }
        public List<NhanVienDTO> getListNV_DTO(string query)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = reader[0].ToString();
                nv.TenNV = reader[1].ToString();
                nv.MaL = int.Parse(reader[2].ToString());
                nv.MaTL = int.Parse(reader[3].ToString());
                nv.MaPC = int.Parse(reader[4].ToString());
                nv.Luong = float.Parse(reader[5].ToString());
                nv.GioiTinh = int.Parse(reader[6].ToString());
                nv.SoNgayPhep = int.Parse(reader[7].ToString());
                nv.ChucVu = int.Parse(reader[8].ToString());
                nv.NgaySinh = DateTime.Parse(reader[9].ToString());
                nv.NgayVaoLam = DateTime.Parse(reader[10].ToString());
                nv.Email = reader[11].ToString();
                nv.XuLy = int.Parse(reader[12].ToString());

                list.Add(nv);
            }

            conn.Close();
            return list;
        }

        public List<KhachHangDTO> getListKH_DTO(string query)
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = reader[0].ToString();
                kh.TenKH = reader[1].ToString();
                kh.CMND = reader[2].ToString();
                kh.GioiTinh = int.Parse(reader[3].ToString());
                kh.SDT = reader[4].ToString();
                kh.QueQuan = reader[5].ToString();
                kh.QuocTich = reader[6].ToString();
                kh.NgaySinh = DateTime.Parse(reader[7].ToString());
                kh.XuLy = int.Parse(reader[8].ToString());
                list.Add(kh);
            }
            conn.Close();
            return list;
        }
        public List<DichVuDTO> getListDV_DTO(string query)
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DichVuDTO dv = new DichVuDTO();
                dv.MaDV = reader[0].ToString();
                dv.TenDV = reader[1].ToString();
                dv.LoaiDV = reader[2].ToString();
                dv.GiaDV = int.Parse(reader[3].ToString());
                dv.XuLy = int.Parse(reader[5].ToString());
                list.Add(dv);
            }
            conn.Close();
            return list;
        }
        public List<ChiTietThueDichVuDTO> getListCTTDV_DTO(string query)
        {
            List<ChiTietThueDichVuDTO> list = new List<ChiTietThueDichVuDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietThueDichVuDTO dv = new ChiTietThueDichVuDTO();
                dv.MaCTT = reader[0].ToString();
                dv.MaDV = reader[1].ToString();
                dv.NgaySuDung = DateTime.Parse(reader[2].ToString());
                dv.SoLuong = int.Parse(reader[3].ToString());
                dv.GiaDV = int.Parse(reader[4].ToString());
                list.Add(dv);
            }
            conn.Close();
            return list;
        }
        public List<ChiTietThuePhongDTO> getListCTTP_DTO(string query)
        {
            List<ChiTietThuePhongDTO> list = new List<ChiTietThuePhongDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietThuePhongDTO cttp = new ChiTietThuePhongDTO();
                cttp.MaCTT = reader[0].ToString();
                cttp.MaP = reader[1].ToString();
                cttp.NgayThue = DateTime.Parse(reader[2].ToString());
                if (!reader.IsDBNull(3))
                {
                    cttp.NgayTra = DateTime.Parse(reader[3].ToString());
                }
                else
                {
                    cttp.NgayTra = null;
                }
                if (!reader.IsDBNull(4))
                {
                    cttp.NgayCheckOut = DateTime.Parse(reader[4].ToString());
                }
                else
                {
                    cttp.NgayCheckOut = null;
                }
                cttp.LoaiHinhThue = int.Parse(reader[5].ToString());
                cttp.GiaThue = int.Parse(reader[6].ToString());
                cttp.TinhTrang = int.Parse(reader[7].ToString());
                list.Add(cttp);
            }
            conn.Close();
            return list;
        }
        public ChiTietThueDTO getCTT_DTO(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ChiTietThueDTO ctt = new ChiTietThueDTO();
            ctt.MaCTT = reader[0].ToString();
            ctt.MaKH = reader[1].ToString();
            ctt.MaNV = reader[2].ToString();
            ctt.NgayLapPhieu = DateTime.Parse(reader[3].ToString());
            ctt.TienDatCoc = int.Parse(reader[4].ToString());
            ctt.TinhTrangXuLy = int.Parse(reader[5].ToString());
            ctt.XuLy = int.Parse(reader[6].ToString());
            conn.Close();
            return ctt;
        }
        public List<TaiKhoanDTO> GetListTK_DTO(string query)
        {
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TaiKhoan = reader[0].ToString();
                if (reader[1] != null)
                {
                    tk.MaNV = reader[1].ToString();
                }
                else
                {
                    tk.MaNV = "";
                }
                if (reader[4] != null)
                {
                    tk.MaPQ = reader[4].ToString();
                }
                else
                {
                    tk.MaPQ = "";
                }
                tk.MatKhau = reader[2].ToString();
                tk.TinhTrang = int.Parse(reader[3].ToString());
                tk.XuLy = int.Parse(reader[5].ToString());
                list.Add(tk);
            }
            conn.Close();
            return list;
        }
        public class TimekeepingDAL
        {
            private Database db;

            public TimekeepingDAL()
            {
                db = new Database();
            }

            public void SaveAttendance(int employeeId, DateTime date, string status)
            {
                string query = "INSERT INTO CHAMCONG (maNV, Thoigian, MaLC) VALUES (@maNV, @Thoigian, @MaLC)";
                using (SqlConnection conn = new SqlConnection(db.connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maNV", employeeId);
                    cmd.Parameters.AddWithValue("@Thoigian", date);
                    cmd.Parameters.AddWithValue("@MaLC", status);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            public DataTable GetTimekeeping(int month, int year)
            {
                string query = @"SELECT * FROM CHAMCONG WHERE MONTH(Thoigian) = @Month AND YEAR(Thoigian) = @Year";
                using (SqlConnection conn = new SqlConnection(db.connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            public List<ChamCongDTO> GetAllChamCong()
            {
                List<ChamCongDTO> list = new List<ChamCongDTO>();
                using (SqlConnection conn = new SqlConnection(db.connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM CHAMCONG";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ChamCongDTO chamCong = new ChamCongDTO()
                        {
                            MaCC = reader["MaCC"].ToString(),
                            MaNV = reader["maNV"].ToString(),
                            MaLC = reader["MaLC"].ToString(),
                            MaCT = reader["MaCT"].ToString(),
                            ThoiGian = reader["Thoigian"].ToString(),
                            GhiChu = reader["GhiChu"].ToString()
                        };
                        list.Add(chamCong);
                    }
                }
                return list;
            }

            // 🔹 Thêm mới chấm công
            public bool InsertChamCong(ChamCongDTO chamCong)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(db.connectionString))
                    {
                        conn.Open();
                        string query = "INSERT INTO CHAMCONG (MaCC, maNV, MaLC, MaCT, Thoigian, GhiChu) VALUES (@MaCC, @MaNV, @MaLC, @MaCT, @Thoigian, @GhiChu)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaCC", chamCong.MaCC);
                        cmd.Parameters.AddWithValue("@MaNV", chamCong.MaNV);
                        cmd.Parameters.AddWithValue("@MaLC", chamCong.MaLC);
                        cmd.Parameters.AddWithValue("@MaCT", chamCong.MaCT);
                        cmd.Parameters.AddWithValue("@Thoigian", chamCong.ThoiGian);
                        cmd.Parameters.AddWithValue("@GhiChu", chamCong.GhiChu);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                    // Ghi lại lỗi hoặc ném lại với thông tin chi tiết
                    Console.WriteLine($"Lỗi SQL: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Ghi lại lỗi hoặc ném lại với thông tin chi tiết
                    Console.WriteLine($"Lỗi tổng quát: {ex.Message}");
                    return false;
                }
            }

            // 🔹 Xóa chấm công
            public bool DeleteChamCong(string maCC)
            {
                using (SqlConnection conn = new SqlConnection(db.connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM CHAMCONG WHERE MaCC = @MaCC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaCC", maCC);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}