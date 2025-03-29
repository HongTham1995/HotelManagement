namespace GUI.GUI_STAFF
{
    partial class tabphucap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panelRounded2 = new GUI.GUI_COMPONENT.PanelRounded();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.buttonRounded7 = new GUI.GUI_COMPONENT.ButtonRounded();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUCPHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIEULUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14.SuspendLayout();
            this.panelRounded2.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panelRounded2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(5, 6, 5, 0);
            this.panel14.Size = new System.Drawing.Size(893, 450);
            this.panel14.TabIndex = 16;
            // 
            // panelRounded2
            // 
            this.panelRounded2.BackColor = System.Drawing.Color.White;
            this.panelRounded2.BorderColor = System.Drawing.Color.White;
            this.panelRounded2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panelRounded2.BorderRadius = 10;
            this.panelRounded2.BorderSize = 2;
            this.panelRounded2.Controls.Add(this.panel15);
            this.panelRounded2.Controls.Add(this.panel16);
            this.panelRounded2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRounded2.Location = new System.Drawing.Point(5, 6);
            this.panelRounded2.Margin = new System.Windows.Forms.Padding(2);
            this.panelRounded2.Name = "panelRounded2";
            this.panelRounded2.Size = new System.Drawing.Size(883, 444);
            this.panelRounded2.TabIndex = 1;
            this.panelRounded2.UnderlinedStyle = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dataNhanVien);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 50);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(12, 0, 12, 12);
            this.panel15.Size = new System.Drawing.Size(883, 394);
            this.panel15.TabIndex = 2;
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AllowUserToAddRows = false;
            this.dataNhanVien.AllowUserToDeleteRows = false;
            this.dataNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dataNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CHUCVU,
            this.TENPHUCAP,
            this.MUCPHUCAP,
            this.HIEULUC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNhanVien.EnableHeadersVisualStyles = false;
            this.dataNhanVien.Location = new System.Drawing.Point(12, 0);
            this.dataNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dataNhanVien.Name = "dataNhanVien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataNhanVien.RowHeadersVisible = false;
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.RowTemplate.Height = 35;
            this.dataNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNhanVien.Size = new System.Drawing.Size(859, 382);
            this.dataNhanVien.TabIndex = 15;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Controls.Add(this.label12);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(883, 50);
            this.panel16.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.buttonRounded7);
            this.panel18.Controls.Add(this.label15);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(883, 50);
            this.panel18.TabIndex = 2;
            // 
            // buttonRounded7
            // 
            this.buttonRounded7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRounded7.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRounded7.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.buttonRounded7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRounded7.BorderRadius = 20;
            this.buttonRounded7.BorderSize = 0;
            this.buttonRounded7.Enabled = false;
            this.buttonRounded7.FlatAppearance.BorderSize = 0;
            this.buttonRounded7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRounded7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRounded7.ForeColor = System.Drawing.Color.White;
            this.buttonRounded7.ForegroundColor = System.Drawing.Color.White;
            this.buttonRounded7.Location = new System.Drawing.Point(626, 9);
            this.buttonRounded7.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.buttonRounded7.Name = "buttonRounded7";
            this.buttonRounded7.Size = new System.Drawing.Size(120, 33);
            this.buttonRounded7.TabIndex = 16;
            this.buttonRounded7.Text = "Sửa phụ cấp";
            this.buttonRounded7.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(252, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "DANH SÁCH NHÂN VIÊN KHÁCH SẠN";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "DANH SÁCH KHÁCH HÀNG";
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
            this.STT.Width = 66;
            // 
            // CHUCVU
            // 
            this.CHUCVU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CHUCVU.HeaderText = "CHỨC VỤ";
            this.CHUCVU.MinimumWidth = 6;
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.ReadOnly = true;
            this.CHUCVU.Width = 103;
            // 
            // TENPHUCAP
            // 
            this.TENPHUCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENPHUCAP.HeaderText = "TÊN PHỤ CẤP";
            this.TENPHUCAP.MinimumWidth = 6;
            this.TENPHUCAP.Name = "TENPHUCAP";
            this.TENPHUCAP.ReadOnly = true;
            this.TENPHUCAP.Width = 130;
            // 
            // MUCPHUCAP
            // 
            this.MUCPHUCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MUCPHUCAP.HeaderText = "MỨC PHỤ CẤP";
            this.MUCPHUCAP.MinimumWidth = 6;
            this.MUCPHUCAP.Name = "MUCPHUCAP";
            this.MUCPHUCAP.ReadOnly = true;
            this.MUCPHUCAP.Width = 136;
            // 
            // HIEULUC
            // 
            this.HIEULUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HIEULUC.HeaderText = "HIỆU LỰC";
            this.HIEULUC.MinimumWidth = 6;
            this.HIEULUC.Name = "HIEULUC";
            this.HIEULUC.ReadOnly = true;
            this.HIEULUC.Width = 103;
            // 
            // tabphucap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.panel14);
            this.Name = "tabphucap";
            this.Text = "Form1";
            this.panel14.ResumeLayout(false);
            this.panelRounded2.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private GUI_COMPONENT.PanelRounded panelRounded2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel18;
        private GUI_COMPONENT.ButtonRounded buttonRounded7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHUCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUCPHUCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIEULUC;
    }
}