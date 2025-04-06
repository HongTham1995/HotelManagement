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
    public partial class tabthamnien : Form
    {
        ThamnienBUS thambienbus = new ThamnienBUS();
        public tabthamnien()
        {
            InitializeComponent();
            onload();
        }

        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = thambienbus.getthamnien();
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var maTN = dt.Rows[i][0].ToString();
                var sonam = dt.Rows[i][1].ToString();
                var heso = dt.Rows[i][2].ToString();

                var ngayupdate = dt.Rows[i][3].ToString();
                dataNhanVien.Rows.Add(stt, maTN,sonam,heso, ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();

        }
    }
}
