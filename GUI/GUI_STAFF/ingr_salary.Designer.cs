namespace GUI.GUI_STAFF
{
    partial class ingr_salary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhuCap;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.TabPage tabThamNien;
        private System.Windows.Forms.TabPage tabLoaiCong;

        private void InitializeComponent()
        {
            this.panel21 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhuCap = new System.Windows.Forms.TabPage();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.tabThamNien = new System.Windows.Forms.TabPage();
            this.tabLoaiCong = new System.Windows.Forms.TabPage();

            this.panel21.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();

            // panel21
            this.panel21.Controls.Add(this.label1);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(11, 12);
            this.panel21.Size = new System.Drawing.Size(925, 43);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Text = "THÀNH PHẦN LƯƠNG";

            // panel2
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(11, 55);
            this.panel2.Size = new System.Drawing.Size(925, 500);

            // TabControl
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Controls.Add(this.tabPhuCap);
            this.tabControl1.Controls.Add(this.tabLuong);
            this.tabControl1.Controls.Add(this.tabThamNien);
            this.tabControl1.Controls.Add(this.tabLoaiCong);

            // Tab pages
            this.tabPhuCap.Text = "Phụ cấp";
            this.tabLuong.Text = "Lương";
            this.tabThamNien.Text = "Thâm niên";
            this.tabLoaiCong.Text = "Loại công";

            // Thêm TabControl vào panel2
            this.panel2.Controls.Add(this.tabControl1);

            // ingr_salary (Form)
            this.ClientSize = new System.Drawing.Size(947, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }


        #endregion
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel2;
    }


}