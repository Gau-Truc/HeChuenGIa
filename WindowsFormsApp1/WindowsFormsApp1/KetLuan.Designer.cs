namespace WindowsFormsApp1
{
    partial class KetLuan
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
            this.txtTenKetLuan = new System.Windows.Forms.TextBox();
            this.txtMaKetLuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvKetLuan = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.Ma_Ket_luan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Ket_luan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetLuan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenKetLuan
            // 
            this.txtTenKetLuan.Location = new System.Drawing.Point(614, 96);
            this.txtTenKetLuan.Name = "txtTenKetLuan";
            this.txtTenKetLuan.Size = new System.Drawing.Size(337, 22);
            this.txtTenKetLuan.TabIndex = 30;
            // 
            // txtMaKetLuan
            // 
            this.txtMaKetLuan.Location = new System.Drawing.Point(617, 31);
            this.txtMaKetLuan.Name = "txtMaKetLuan";
            this.txtMaKetLuan.Size = new System.Drawing.Size(337, 22);
            this.txtMaKetLuan.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên kết luận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã kết luận";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(819, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 41);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm kết luận";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(819, 226);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 41);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa kết luận";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(614, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 41);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa kết luận";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(614, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(135, 41);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvKetLuan
            // 
            this.dgvKetLuan.AllowUserToAddRows = false;
            this.dgvKetLuan.AllowUserToDeleteRows = false;
            this.dgvKetLuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetLuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Ket_luan,
            this.Ten_Ket_luan});
            this.dgvKetLuan.Location = new System.Drawing.Point(12, 12);
            this.dgvKetLuan.Name = "dgvKetLuan";
            this.dgvKetLuan.ReadOnly = true;
            this.dgvKetLuan.RowHeadersWidth = 51;
            this.dgvKetLuan.RowTemplate.Height = 24;
            this.dgvKetLuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetLuan.Size = new System.Drawing.Size(596, 426);
            this.dgvKetLuan.TabIndex = 22;
            this.dgvKetLuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetLuan_CellClick);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(714, 273);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(135, 41);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Ma_Ket_luan
            // 
            this.Ma_Ket_luan.DataPropertyName = "Ma_Ket_Luan";
            this.Ma_Ket_luan.HeaderText = "Mã kết luận";
            this.Ma_Ket_luan.MinimumWidth = 6;
            this.Ma_Ket_luan.Name = "Ma_Ket_luan";
            this.Ma_Ket_luan.ReadOnly = true;
            this.Ma_Ket_luan.Width = 125;
            // 
            // Ten_Ket_luan
            // 
            this.Ten_Ket_luan.DataPropertyName = "Ten_Ket_Luan";
            this.Ten_Ket_luan.HeaderText = "Tên kết luận";
            this.Ten_Ket_luan.MinimumWidth = 6;
            this.Ten_Ket_luan.Name = "Ten_Ket_luan";
            this.Ten_Ket_luan.ReadOnly = true;
            this.Ten_Ket_luan.Width = 400;
            // 
            // KetLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtTenKetLuan);
            this.Controls.Add(this.txtMaKetLuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvKetLuan);
            this.Name = "KetLuan";
            this.Text = "KetLuan";
            this.Load += new System.EventHandler(this.KetLuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetLuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKetLuan;
        private System.Windows.Forms.TextBox txtMaKetLuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvKetLuan;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Ket_luan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Ket_luan;
    }
}