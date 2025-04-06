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
    public partial class tabloaicong : Form
    {
        LoaicongBUS loaicongbus = new LoaicongBUS();
        public tabloaicong()
        {
            InitializeComponent();
            onload();
        }

        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = loaicongbus.getloaicong();
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var maLC = dt.Rows[i][0].ToString();
                var tenLC = dt.Rows[i][1].ToString();
                var heso = dt.Rows[i][2].ToString();

                var ngayupdate = dt.Rows[i][3].ToString();
                dataNhanVien.Rows.Add(stt, maLC, tenLC, heso, ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();
        }
    }
}
