namespace WindowsFormsApp1
{
    partial class Luat
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
            this.dgvAddTrieuChung = new System.Windows.Forms.DataGridView();
            this.dgvAddKetLuan = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ma_ket_luan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_ket_luan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.txtKetLuan = new System.Windows.Forms.TextBox();
            this.btnHoanTacTrieuChung = new System.Windows.Forms.Button();
            this.btnHoanTacKetLuan = new System.Windows.Forms.Button();
            this.btnThemLuat = new System.Windows.Forms.Button();
            this.btnSuaLuat = new System.Windows.Forms.Button();
            this.btnXoaLuat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLuat = new System.Windows.Forms.DataGridView();
            this.Ma_luat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cac_trieu_chung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ket_luạn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTrieuChung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddKetLuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddTrieuChung
            // 
            this.dgvAddTrieuChung.AllowUserToAddRows = false;
            this.dgvAddTrieuChung.AllowUserToDeleteRows = false;
            this.dgvAddTrieuChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddTrieuChung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.dgvAddTrieuChung.Location = new System.Drawing.Point(12, 28);
            this.dgvAddTrieuChung.Name = "dgvAddTrieuChung";
            this.dgvAddTrieuChung.ReadOnly = true;
            this.dgvAddTrieuChung.RowHeadersWidth = 51;
            this.dgvAddTrieuChung.RowTemplate.Height = 24;
            this.dgvAddTrieuChung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddTrieuChung.Size = new System.Drawing.Size(654, 212);
            this.dgvAddTrieuChung.TabIndex = 0;
            this.dgvAddTrieuChung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddTrieuChung_CellClick);
            // 
            // dgvAddKetLuan
            // 
            this.dgvAddKetLuan.AllowUserToAddRows = false;
            this.dgvAddKetLuan.AllowUserToDeleteRows = false;
            this.dgvAddKetLuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddKetLuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_ket_luan,
            this.Ten_ket_luan});
            this.dgvAddKetLuan.Location = new System.Drawing.Point(672, 28);
            this.dgvAddKetLuan.Name = "dgvAddKetLuan";
            this.dgvAddKetLuan.ReadOnly = true;
            this.dgvAddKetLuan.RowHeadersWidth = 51;
            this.dgvAddKetLuan.RowTemplate.Height = 24;
            this.dgvAddKetLuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddKetLuan.Size = new System.Drawing.Size(479, 212);
            this.dgvAddKetLuan.TabIndex = 1;
            this.dgvAddKetLuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddKetLuan_CellClick);
            this.dgvAddKetLuan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bảng thêm triệu chứng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bảng thêm kết luận";
            // 
            // Ma_ket_luan
            // 
            this.Ma_ket_luan.DataPropertyName = "Ma";
            this.Ma_ket_luan.HeaderText = "Mã kết luận";
            this.Ma_ket_luan.MinimumWidth = 6;
            this.Ma_ket_luan.Name = "Ma_ket_luan";
            this.Ma_ket_luan.ReadOnly = true;
            this.Ma_ket_luan.Width = 125;
            // 
            // Ten_ket_luan
            // 
            this.Ten_ket_luan.DataPropertyName = "Ten";
            this.Ten_ket_luan.HeaderText = "Tên kết luận";
            this.Ten_ket_luan.MinimumWidth = 6;
            this.Ten_ket_luan.Name = "Ten_ket_luan";
            this.Ten_ket_luan.ReadOnly = true;
            this.Ten_ket_luan.Width = 250;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Triệu chứng đã chọn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết luận đã chọn:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Enabled = false;
            this.txtTrieuChung.Location = new System.Drawing.Point(149, 246);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(517, 22);
            this.txtTrieuChung.TabIndex = 6;
            // 
            // txtKetLuan
            // 
            this.txtKetLuan.Enabled = false;
            this.txtKetLuan.Location = new System.Drawing.Point(786, 246);
            this.txtKetLuan.Name = "txtKetLuan";
            this.txtKetLuan.Size = new System.Drawing.Size(365, 22);
            this.txtKetLuan.TabIndex = 7;
            // 
            // btnHoanTacTrieuChung
            // 
            this.btnHoanTacTrieuChung.Location = new System.Drawing.Point(15, 274);
            this.btnHoanTacTrieuChung.Name = "btnHoanTacTrieuChung";
            this.btnHoanTacTrieuChung.Size = new System.Drawing.Size(171, 36);
            this.btnHoanTacTrieuChung.TabIndex = 8;
            this.btnHoanTacTrieuChung.Text = "Hoàn tác triệu chứng";
            this.btnHoanTacTrieuChung.UseVisualStyleBackColor = true;
            this.btnHoanTacTrieuChung.Click += new System.EventHandler(this.btnHoanTacTrieuChung_Click);
            // 
            // btnHoanTacKetLuan
            // 
            this.btnHoanTacKetLuan.Location = new System.Drawing.Point(672, 274);
            this.btnHoanTacKetLuan.Name = "btnHoanTacKetLuan";
            this.btnHoanTacKetLuan.Size = new System.Drawing.Size(146, 36);
            this.btnHoanTacKetLuan.TabIndex = 9;
            this.btnHoanTacKetLuan.Text = "Hoàn tác kết luận";
            this.btnHoanTacKetLuan.UseVisualStyleBackColor = true;
            this.btnHoanTacKetLuan.Click += new System.EventHandler(this.btnHoanTacKetLuan_Click);
            // 
            // btnThemLuat
            // 
            this.btnThemLuat.Location = new System.Drawing.Point(192, 274);
            this.btnThemLuat.Name = "btnThemLuat";
            this.btnThemLuat.Size = new System.Drawing.Size(146, 36);
            this.btnThemLuat.TabIndex = 10;
            this.btnThemLuat.Text = "Thêm luật";
            this.btnThemLuat.UseVisualStyleBackColor = true;
            this.btnThemLuat.Click += new System.EventHandler(this.btnThemLuat_Click);
            // 
            // btnSuaLuat
            // 
            this.btnSuaLuat.Location = new System.Drawing.Point(344, 274);
            this.btnSuaLuat.Name = "btnSuaLuat";
            this.btnSuaLuat.Size = new System.Drawing.Size(146, 36);
            this.btnSuaLuat.TabIndex = 11;
            this.btnSuaLuat.Text = "Sửa luật";
            this.btnSuaLuat.UseVisualStyleBackColor = true;
            this.btnSuaLuat.Click += new System.EventHandler(this.btnSuaLuat_Click);
            // 
            // btnXoaLuat
            // 
            this.btnXoaLuat.Location = new System.Drawing.Point(496, 274);
            this.btnXoaLuat.Name = "btnXoaLuat";
            this.btnXoaLuat.Size = new System.Drawing.Size(146, 36);
            this.btnXoaLuat.TabIndex = 12;
            this.btnXoaLuat.Text = "Xóa luật";
            this.btnXoaLuat.UseVisualStyleBackColor = true;
            this.btnXoaLuat.Click += new System.EventHandler(this.btnXoaLuat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1005, 274);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(146, 36);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Danh sách luật";
            // 
            // dgvLuat
            // 
            this.dgvLuat.AllowUserToAddRows = false;
            this.dgvLuat.AllowUserToDeleteRows = false;
            this.dgvLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_luat,
            this.Cac_trieu_chung,
            this.Ket_luạn});
            this.dgvLuat.Location = new System.Drawing.Point(672, 332);
            this.dgvLuat.Name = "dgvLuat";
            this.dgvLuat.ReadOnly = true;
            this.dgvLuat.RowHeadersWidth = 51;
            this.dgvLuat.RowTemplate.Height = 24;
            this.dgvLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuat.Size = new System.Drawing.Size(479, 248);
            this.dgvLuat.TabIndex = 15;
            this.dgvLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuat_CellClick);
            // 
            // Ma_luat
            // 
            this.Ma_luat.DataPropertyName = "Ma_Tap_Luat";
            this.Ma_luat.HeaderText = "Mã luật";
            this.Ma_luat.MinimumWidth = 6;
            this.Ma_luat.Name = "Ma_luat";
            this.Ma_luat.ReadOnly = true;
            this.Ma_luat.Width = 125;
            // 
            // Cac_trieu_chung
            // 
            this.Cac_trieu_chung.DataPropertyName = "Cac_Trieu_Chung";
            this.Cac_trieu_chung.HeaderText = "Các triệu chứng";
            this.Cac_trieu_chung.MinimumWidth = 6;
            this.Cac_trieu_chung.Name = "Cac_trieu_chung";
            this.Cac_trieu_chung.ReadOnly = true;
            this.Cac_trieu_chung.Width = 125;
            // 
            // Ket_luạn
            // 
            this.Ket_luạn.DataPropertyName = "Ket_Luan";
            this.Ket_luạn.HeaderText = "Kết luận";
            this.Ket_luạn.MinimumWidth = 6;
            this.Ket_luạn.Name = "Ket_luạn";
            this.Ket_luạn.ReadOnly = true;
            this.Ket_luạn.Width = 125;
            // 
            // Luat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 592);
            this.Controls.Add(this.dgvLuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaLuat);
            this.Controls.Add(this.btnSuaLuat);
            this.Controls.Add(this.btnThemLuat);
            this.Controls.Add(this.btnHoanTacKetLuan);
            this.Controls.Add(this.btnHoanTacTrieuChung);
            this.Controls.Add(this.txtKetLuan);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAddKetLuan);
            this.Controls.Add(this.dgvAddTrieuChung);
            this.Name = "Luat";
            this.Text = "Luat";
            this.Load += new System.EventHandler(this.Luat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddTrieuChung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddKetLuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddTrieuChung;
        private System.Windows.Forms.DataGridView dgvAddKetLuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_ket_luan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_ket_luan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.TextBox txtKetLuan;
        private System.Windows.Forms.Button btnHoanTacTrieuChung;
        private System.Windows.Forms.Button btnHoanTacKetLuan;
        private System.Windows.Forms.Button btnThemLuat;
        private System.Windows.Forms.Button btnSuaLuat;
        private System.Windows.Forms.Button btnXoaLuat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_luat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cac_trieu_chung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ket_luạn;
    }
}