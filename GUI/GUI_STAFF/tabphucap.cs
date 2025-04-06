using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_STAFF
{
    public partial class tabphucap : Form
    {
        PhucapBUS phucapbus = new PhucapBUS();
        public tabphucap()
        {
            InitializeComponent();
            onload();
        }

        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = phucapbus.getPhucap();
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var cv = dt.Rows[i][0].ToString();
                string chucvu;
                if (cv == "0")
                    chucvu = "Quản lý";
                else if (cv == "1")
                    chucvu = "Lễ tân";
                else if (cv == "2")
                    chucvu = " Kê toán";
                else if (cv == "3")
                    chucvu = "Bếp";
                else if (cv == "4")
                    chucvu = "Phục vụ";
                else
                    chucvu = "Bảo vệ";
                var loaiphucap = dt.Rows[i][1].ToString();
                var sotien = dt.Rows[i][2].ToString();
                
                var ngayupdate = dt.Rows[i][3].ToString();
                dataNhanVien.Rows.Add(stt, chucvu,loaiphucap,sotien,ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();

        }
    }
}
