using BUS;
using GUI.GUI_COMPONENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.GUI_STAFF
{
    public partial class frmEditTimekeeping: Form
    {
        private Point mouseOffset;
        public frmEditTimekeeping()
        {
            InitializeComponent();
        }

        private void frmEditTimekeeping_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox_Month.Items.Add(i.ToString("D2")); 
            }
            comboBox_Month.SelectedIndex = DateTime.Now.Month - 1; 

            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 20; i <= currentYear; i++)
            {
                comboBox_Year.Items.Add(i.ToString());
            }
            comboBox_Year.SelectedItem = currentYear.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;
            mouseOffset = new Point(-mouseX, -mouseY);
        }

        /// <summary>
        /// Handles the MouseMove event for the pnTop panel to move the form when the left mouse button is held down
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">An EventArgs that contains the event data</param>
        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
