﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using BUS;

namespace GUI.GUI_STAFF
{
    public partial class Timekeeping : Form
    {
        private ChamCongBUS chamCongBUS; // Định nghĩa đối tượng BUS
        private Timekeeping parentForm;
        public Timekeeping()
        {
            InitializeComponent();
            chamCongBUS = new ChamCongBUS();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panelRounded1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonRounded2_Click(object sender, EventArgs e)
        {

        }

        


        private void buttonRounded2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            // Chuyển form Timekeeping vào form EditTimekeeping khi mở
            frmEditTimekeeping formEditTimeKeeping = new frmEditTimekeeping(this);
            formEditTimeKeeping.ShowDialog();
        }


        private void dateNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            dateNgayChamCong.CustomFormat = "dd/MM/yyyy";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadDataNV()
        {
            try
            {
                // Gọi phương thức lấy dữ liệu từ database
                DataTable dt = chamCongBUS.GetChamCongData();

                // Kiểm tra dữ liệu có tồn tại không
                if (dt != null && dt.Rows.Count > 0)
                {
                   

                    // Gán dữ liệu vào DataGridView
                    dataChamCong.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("Không có dữ liệu chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timekeeping_Load(object sender, EventArgs e)
        {
            LoadDataNV(); // Gọi hàm khi form load
        }
        

            
         
        


        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Load_Chamcong(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataNV(); // Load lại data chấm công

            // Reset các filter nếu có
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtMaChamCong.Text = "";
            dateNgayChamCong.Value = DateTime.Now;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNV = string.IsNullOrEmpty(txtMaNhanVien.Text.Trim()) ? "" : txtMaNhanVien.Text.Trim();
            string tenNV = string.IsNullOrEmpty(txtTenNhanVien.Text.Trim()) ? "" : txtTenNhanVien.Text.Trim();
            string maChamCong = string.IsNullOrEmpty(txtMaChamCong.Text.Trim()) ? "" : txtMaChamCong.Text.Trim();
            try
            {
                // Gọi phương thức lấy dữ liệu từ database
                DataTable dt = chamCongBUS.GetChamCongData(maNV, tenNV, maChamCong);

                // Kiểm tra dữ liệu có tồn tại không
                if (dt != null && dt.Rows.Count > 0)
                {
                    

                    // Gán dữ liệu vào DataGridView
                    dataChamCong.DataSource = dt;
                    //MessageBox.Show($"Tổng dòng: {dt.Rows.Count}");

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}