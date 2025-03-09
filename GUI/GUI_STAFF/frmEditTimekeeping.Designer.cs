namespace GUI.GUI_STAFF
{
    partial class frmEditTimekeeping
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataNV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnNghiKhongPhep = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnNghiPhep = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnDiTre = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnConfirm = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnClose = new GUI.GUI_COMPONENT.ButtonRounded();
            this.panel_Top.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.White;
            this.panel_Top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Top.Controls.Add(this.btnClose);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1263, 42);
            this.panel_Top.TabIndex = 2;
            this.panel_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseMove);
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Controls.Add(this.panel1);
            this.panel_Main.Controls.Add(this.comboBox_Month);
            this.panel_Main.Controls.Add(this.comboBox_Year);
            this.panel_Main.Location = new System.Drawing.Point(6, 58);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1245, 690);
            this.panel_Main.TabIndex = 12;
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(598, 21);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(121, 30);
            this.comboBox_Year.TabIndex = 1;
            this.comboBox_Year.Text = "Năm";
            this.comboBox_Year.SelectedIndexChanged += new System.EventHandler(this.comboBox_Year_SelectedIndexChanged);
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_Month.FormattingEnabled = true;
            this.comboBox_Month.Location = new System.Drawing.Point(471, 21);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(121, 30);
            this.comboBox_Month.TabIndex = 2;
            this.comboBox_Month.Text = "Tháng";
            this.comboBox_Month.SelectedIndexChanged += new System.EventHandler(this.comboBox_Month_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 614);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataNV);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 608);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnNghiKhongPhep);
            this.panel3.Controls.Add(this.btnNghiPhep);
            this.panel3.Controls.Add(this.btnDiTre);
            this.panel3.Controls.Add(this.tableCalendar);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Location = new System.Drawing.Point(564, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 608);
            this.panel3.TabIndex = 1;
            // 
            // dataNV
            // 
            this.dataNV.AllowUserToAddRows = false;
            this.dataNV.AllowUserToDeleteRows = false;
            this.dataNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNV.BackgroundColor = System.Drawing.Color.White;
            this.dataNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenNV,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNV.EnableHeadersVisualStyles = false;
            this.dataNV.Location = new System.Drawing.Point(3, 0);
            this.dataNV.Name = "dataNV";
            this.dataNV.RowHeadersVisible = false;
            this.dataNV.RowHeadersWidth = 51;
            this.dataNV.RowTemplate.Height = 35;
            this.dataNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNV.Size = new System.Drawing.Size(549, 605);
            this.dataNV.TabIndex = 16;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 77;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.HeaderText = "TRẠNG THÁI";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // tableCalendar
            // 
            this.tableCalendar.AutoSize = true;
            this.tableCalendar.ColumnCount = 8;
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableCalendar.Location = new System.Drawing.Point(3, 3);
            this.tableCalendar.Name = "tableCalendar";
            this.tableCalendar.RowCount = 4;
            this.tableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCalendar.Size = new System.Drawing.Size(666, 306);
            this.tableCalendar.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.ForegroundColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(489, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 56);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnNghiKhongPhep
            // 
            this.btnNghiKhongPhep.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNghiKhongPhep.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnNghiKhongPhep.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNghiKhongPhep.BorderRadius = 20;
            this.btnNghiKhongPhep.BorderSize = 0;
            this.btnNghiKhongPhep.FlatAppearance.BorderSize = 0;
            this.btnNghiKhongPhep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiKhongPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNghiKhongPhep.ForeColor = System.Drawing.Color.Black;
            this.btnNghiKhongPhep.ForegroundColor = System.Drawing.Color.Black;
            this.btnNghiKhongPhep.Location = new System.Drawing.Point(187, 350);
            this.btnNghiKhongPhep.Name = "btnNghiKhongPhep";
            this.btnNghiKhongPhep.Size = new System.Drawing.Size(115, 56);
            this.btnNghiKhongPhep.TabIndex = 18;
            this.btnNghiKhongPhep.Text = "Nghỉ không phép";
            this.btnNghiKhongPhep.UseVisualStyleBackColor = false;
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNghiPhep.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.btnNghiPhep.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNghiPhep.BorderRadius = 20;
            this.btnNghiPhep.BorderSize = 0;
            this.btnNghiPhep.FlatAppearance.BorderSize = 0;
            this.btnNghiPhep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNghiPhep.ForeColor = System.Drawing.Color.Black;
            this.btnNghiPhep.ForegroundColor = System.Drawing.Color.Black;
            this.btnNghiPhep.Location = new System.Drawing.Point(41, 350);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(111, 56);
            this.btnNghiPhep.TabIndex = 17;
            this.btnNghiPhep.Text = "Nghỉ phép";
            this.btnNghiPhep.UseVisualStyleBackColor = false;
            // 
            // btnDiTre
            // 
            this.btnDiTre.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDiTre.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.btnDiTre.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDiTre.BorderRadius = 20;
            this.btnDiTre.BorderSize = 0;
            this.btnDiTre.FlatAppearance.BorderSize = 0;
            this.btnDiTre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDiTre.ForeColor = System.Drawing.Color.Black;
            this.btnDiTre.ForegroundColor = System.Drawing.Color.Black;
            this.btnDiTre.Location = new System.Drawing.Point(339, 350);
            this.btnDiTre.Name = "btnDiTre";
            this.btnDiTre.Size = new System.Drawing.Size(111, 56);
            this.btnDiTre.TabIndex = 16;
            this.btnDiTre.Text = "Đi trễ";
            this.btnDiTre.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.ForegroundColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(534, 538);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 47);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 1;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ForegroundColor = System.Drawing.Color.White;
            this.btnClose.Image = global::GUI.Properties.Resources.icons8_close_24;
            this.btnClose.Location = new System.Drawing.Point(1205, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 38);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEditTimekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 769);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditTimekeeping";
            this.Text = "frmEditTimekeeping";
            this.Load += new System.EventHandler(this.frmEditTimekeeping_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private GUI_COMPONENT.ButtonRounded btnClose;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private GUI_COMPONENT.ButtonRounded btnConfirm;
        private System.Windows.Forms.TableLayoutPanel tableCalendar;
        private GUI_COMPONENT.ButtonRounded btnNghiKhongPhep;
        private GUI_COMPONENT.ButtonRounded btnNghiPhep;
        private GUI_COMPONENT.ButtonRounded btnXoa;
        private GUI_COMPONENT.ButtonRounded btnDiTre;
    }
}