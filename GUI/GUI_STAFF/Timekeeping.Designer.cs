namespace GUI.GUI_STAFF
{
    partial class Timekeeping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChamCong = new GUI.GUI_COMPONENT.ButtonRounded();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnSearch = new GUI.GUI_COMPONENT.ButtonRounded();
            this.panelRounded4 = new GUI.GUI_COMPONENT.PanelRounded();
            this.dateNgayChamCong = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panelRounded3 = new GUI.GUI_COMPONENT.PanelRounded();
            this.textMaChamCong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRounded2 = new GUI.GUI_COMPONENT.PanelRounded();
            this.textTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRounded1 = new GUI.GUI_COMPONENT.PanelRounded();
            this.textMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataChamCong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NghiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NghiKhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LamNgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LamNgayLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRounded4.SuspendLayout();
            this.panelRounded3.SuspendLayout();
            this.panelRounded2.SuspendLayout();
            this.panelRounded1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CHẤM CÔNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnChamCong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChamCong.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnChamCong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChamCong.BorderRadius = 40;
            this.btnChamCong.BorderSize = 0;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.ForegroundColor = System.Drawing.Color.White;
            this.btnChamCong.Location = new System.Drawing.Point(1105, 5);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(140, 51);
            this.btnChamCong.TabIndex = 12;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bấm vào \"Chấm công\" để tạo phiếu chấm công";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.panelRounded4);
            this.panel2.Controls.Add(this.panelRounded3);
            this.panel2.Controls.Add(this.panelRounded2);
            this.panel2.Controls.Add(this.panelRounded1);
            this.panel2.Location = new System.Drawing.Point(15, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 70);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReset.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 40;
            this.btnReset.BorderSize = 0;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ForegroundColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1131, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 51);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.buttonRounded2_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 40;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ForegroundColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1021, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 50);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.buttonRounded2_Click);
            // 
            // panelRounded4
            // 
            this.panelRounded4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.panelRounded4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panelRounded4.BorderRadius = 0;
            this.panelRounded4.BorderSize = 2;
            this.panelRounded4.Controls.Add(this.dateNgayChamCong);
            this.panelRounded4.Controls.Add(this.label6);
            this.panelRounded4.Location = new System.Drawing.Point(738, 3);
            this.panelRounded4.Name = "panelRounded4";
            this.panelRounded4.Size = new System.Drawing.Size(277, 62);
            this.panelRounded4.TabIndex = 5;
            this.panelRounded4.UnderlinedStyle = false;
            // 
            // dateNgayChamCong
            // 
            this.dateNgayChamCong.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateNgayChamCong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateNgayChamCong.Location = new System.Drawing.Point(160, 21);
            this.dateNgayChamCong.Name = "dateNgayChamCong";
            this.dateNgayChamCong.Size = new System.Drawing.Size(117, 27);
            this.dateNgayChamCong.TabIndex = 2;
            this.dateNgayChamCong.ValueChanged += new System.EventHandler(this.dateNgayChamCong_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày chấm công:";
            // 
            // panelRounded3
            // 
            this.panelRounded3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.panelRounded3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panelRounded3.BorderRadius = 0;
            this.panelRounded3.BorderSize = 2;
            this.panelRounded3.Controls.Add(this.textMaChamCong);
            this.panelRounded3.Controls.Add(this.label5);
            this.panelRounded3.Location = new System.Drawing.Point(495, 3);
            this.panelRounded3.Name = "panelRounded3";
            this.panelRounded3.Size = new System.Drawing.Size(237, 62);
            this.panelRounded3.TabIndex = 4;
            this.panelRounded3.UnderlinedStyle = false;
            // 
            // textMaChamCong
            // 
            this.textMaChamCong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textMaChamCong.Location = new System.Drawing.Point(126, 21);
            this.textMaChamCong.Name = "textMaChamCong";
            this.textMaChamCong.Size = new System.Drawing.Size(111, 27);
            this.textMaChamCong.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã chấm công:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelRounded2
            // 
            this.panelRounded2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.panelRounded2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panelRounded2.BorderRadius = 0;
            this.panelRounded2.BorderSize = 2;
            this.panelRounded2.Controls.Add(this.textTenNV);
            this.panelRounded2.Controls.Add(this.label4);
            this.panelRounded2.Location = new System.Drawing.Point(252, 3);
            this.panelRounded2.Name = "panelRounded2";
            this.panelRounded2.Size = new System.Drawing.Size(237, 62);
            this.panelRounded2.TabIndex = 3;
            this.panelRounded2.UnderlinedStyle = false;
            // 
            // textTenNV
            // 
            this.textTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textTenNV.Location = new System.Drawing.Point(127, 20);
            this.textTenNV.Name = "textTenNV";
            this.textTenNV.Size = new System.Drawing.Size(110, 27);
            this.textTenNV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nhân viên:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelRounded1
            // 
            this.panelRounded1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.panelRounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panelRounded1.BorderRadius = 0;
            this.panelRounded1.BorderSize = 2;
            this.panelRounded1.Controls.Add(this.textMaNV);
            this.panelRounded1.Controls.Add(this.label2);
            this.panelRounded1.Location = new System.Drawing.Point(9, 3);
            this.panelRounded1.Name = "panelRounded1";
            this.panelRounded1.Size = new System.Drawing.Size(237, 62);
            this.panelRounded1.TabIndex = 2;
            this.panelRounded1.UnderlinedStyle = false;
            this.panelRounded1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRounded1_Paint);
            // 
            // textMaNV
            // 
            this.textMaNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textMaNV.Location = new System.Drawing.Point(118, 21);
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(116, 27);
            this.textMaNV.TabIndex = 2;
            this.textMaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataChamCong);
            this.panel3.Location = new System.Drawing.Point(15, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 463);
            this.panel3.TabIndex = 3;
            // 
            // dataChamCong
            // 
            this.dataChamCong.AllowUserToAddRows = false;
            this.dataChamCong.AllowUserToDeleteRows = false;
            this.dataChamCong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataChamCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaChamCong,
            this.TenNV,
            this.ThoiGianChamCong,
            this.DiLam,
            this.DiTre,
            this.NghiPhep,
            this.NghiKhongPhep,
            this.LamNgayNghi,
            this.LamNgayLe});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataChamCong.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataChamCong.EnableHeadersVisualStyles = false;
            this.dataChamCong.Location = new System.Drawing.Point(3, 3);
            this.dataChamCong.Name = "dataChamCong";
            this.dataChamCong.RowHeadersVisible = false;
            this.dataChamCong.RowHeadersWidth = 51;
            this.dataChamCong.RowTemplate.Height = 35;
            this.dataChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChamCong.Size = new System.Drawing.Size(1239, 460);
            this.dataChamCong.TabIndex = 15;
            this.dataChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChamCong_CellContentClick);
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
            // MaChamCong
            // 
            this.MaChamCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaChamCong.HeaderText = "MÃ CHẤM CÔNG";
            this.MaChamCong.MinimumWidth = 6;
            this.MaChamCong.Name = "MaChamCong";
            this.MaChamCong.ReadOnly = true;
            this.MaChamCong.Width = 186;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 178;
            // 
            // ThoiGianChamCong
            // 
            this.ThoiGianChamCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThoiGianChamCong.HeaderText = "THỜI GIAN CHẤM CÔNG";
            this.ThoiGianChamCong.MinimumWidth = 6;
            this.ThoiGianChamCong.Name = "ThoiGianChamCong";
            this.ThoiGianChamCong.ReadOnly = true;
            this.ThoiGianChamCong.Width = 246;
            // 
            // DiLam
            // 
            this.DiLam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiLam.HeaderText = "ĐI LÀM";
            this.DiLam.MinimumWidth = 6;
            this.DiLam.Name = "DiLam";
            this.DiLam.ReadOnly = true;
            this.DiLam.Width = 107;
            // 
            // DiTre
            // 
            this.DiTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiTre.HeaderText = "ĐI TRỄ";
            this.DiTre.MinimumWidth = 6;
            this.DiTre.Name = "DiTre";
            this.DiTre.ReadOnly = true;
            // 
            // NghiPhep
            // 
            this.NghiPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NghiPhep.HeaderText = "NGHỈ PHÉP";
            this.NghiPhep.MinimumWidth = 6;
            this.NghiPhep.Name = "NghiPhep";
            this.NghiPhep.ReadOnly = true;
            this.NghiPhep.Width = 137;
            // 
            // NghiKhongPhep
            // 
            this.NghiKhongPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NghiKhongPhep.DefaultCellStyle = dataGridViewCellStyle3;
            this.NghiKhongPhep.HeaderText = "NGHỈ KHÔNG PHÉP";
            this.NghiKhongPhep.MinimumWidth = 6;
            this.NghiKhongPhep.Name = "NghiKhongPhep";
            this.NghiKhongPhep.ReadOnly = true;
            this.NghiKhongPhep.Width = 204;
            // 
            // LamNgayNghi
            // 
            this.LamNgayNghi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LamNgayNghi.DefaultCellStyle = dataGridViewCellStyle4;
            this.LamNgayNghi.HeaderText = "LÀM NGÀY NGHỈ";
            this.LamNgayNghi.MinimumWidth = 6;
            this.LamNgayNghi.Name = "LamNgayNghi";
            this.LamNgayNghi.ReadOnly = true;
            this.LamNgayNghi.Width = 183;
            // 
            // LamNgayLe
            // 
            this.LamNgayLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LamNgayLe.HeaderText = "LÀM NGÀY LỄ";
            this.LamNgayLe.MinimumWidth = 6;
            this.LamNgayLe.Name = "LamNgayLe";
            this.LamNgayLe.ReadOnly = true;
            this.LamNgayLe.Width = 158;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(15, 617);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1242, 147);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 141);
            this.dataGridView1.TabIndex = 0;
            // 
            // Timekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1263, 769);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Timekeeping";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Chấm công";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelRounded4.ResumeLayout(false);
            this.panelRounded4.PerformLayout();
            this.panelRounded3.ResumeLayout(false);
            this.panelRounded3.PerformLayout();
            this.panelRounded2.ResumeLayout(false);
            this.panelRounded2.PerformLayout();
            this.panelRounded1.ResumeLayout(false);
            this.panelRounded1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GUI_COMPONENT.ButtonRounded btnChamCong;
        private GUI_COMPONENT.PanelRounded panelRounded1;
        private System.Windows.Forms.TextBox textMaNV;
        private GUI_COMPONENT.PanelRounded panelRounded2;
        private System.Windows.Forms.Label label4;
        private GUI_COMPONENT.PanelRounded panelRounded3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMaChamCong;
        private System.Windows.Forms.TextBox textTenNV;
        private System.Windows.Forms.Panel panel3;
        private GUI_COMPONENT.PanelRounded panelRounded4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateNgayChamCong;
        private System.Windows.Forms.DataGridView dataChamCong;
        private GUI_COMPONENT.ButtonRounded btnSearch;
        private GUI_COMPONENT.ButtonRounded btnReset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiTre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NghiPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NghiKhongPhep;
        private System.Windows.Forms.DataGridViewTextBoxColumn LamNgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LamNgayLe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}