namespace WindowsFormsApp1
{
    partial class TrieuChung
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
            this.dgvTrieuChung = new System.Windows.Forms.DataGridView();
            this.Ma_trieu_chung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Trieu_chung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTrieuChung = new System.Windows.Forms.TextBox();
            this.txtTenTrieuChung = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrieuChung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrieuChung
            // 
            this.dgvTrieuChung.AllowUserToAddRows = false;
            this.dgvTrieuChung.AllowUserToDeleteRows = false;
            this.dgvTrieuChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrieuChung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_trieu_chung,
            this.Ten_Trieu_chung});
            this.dgvTrieuChung.Location = new System.Drawing.Point(12, 12);
            this.dgvTrieuChung.Name = "dgvTrieuChung";
            this.dgvTrieuChung.ReadOnly = true;
            this.dgvTrieuChung.RowHeadersWidth = 51;
            this.dgvTrieuChung.RowTemplate.Height = 24;
            this.dgvTrieuChung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrieuChung.Size = new System.Drawing.Size(596, 426);
            this.dgvTrieuChung.TabIndex = 0;
            this.dgvTrieuChung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrieuChung_CellClick);
            // 
            // Ma_trieu_chung
            // 
            this.Ma_trieu_chung.DataPropertyName = "Ma_Trieu_Chung";
            this.Ma_trieu_chung.HeaderText = "Mã triệu chứng";
            this.Ma_trieu_chung.MinimumWidth = 6;
            this.Ma_trieu_chung.Name = "Ma_trieu_chung";
            this.Ma_trieu_chung.ReadOnly = true;
            this.Ma_trieu_chung.Width = 125;
            // 
            // Ten_Trieu_chung
            // 
            this.Ten_Trieu_chung.DataPropertyName = "Ten_Trieu_Chung";
            this.Ten_Trieu_chung.HeaderText = "Tên triệu chứng";
            this.Ten_Trieu_chung.MinimumWidth = 6;
            this.Ten_Trieu_chung.Name = "Ten_Trieu_chung";
            this.Ten_Trieu_chung.ReadOnly = true;
            this.Ten_Trieu_chung.Width = 400;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(614, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(135, 41);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(614, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 41);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa triệu chứng";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(819, 226);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 41);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa triệu chứng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(819, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 41);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm triệu chứng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã triệu chứng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên triệu chứng";
            // 
            // txtMaTrieuChung
            // 
            this.txtMaTrieuChung.Location = new System.Drawing.Point(617, 31);
            this.txtMaTrieuChung.Name = "txtMaTrieuChung";
            this.txtMaTrieuChung.Size = new System.Drawing.Size(337, 22);
            this.txtMaTrieuChung.TabIndex = 20;
            // 
            // txtTenTrieuChung
            // 
            this.txtTenTrieuChung.Location = new System.Drawing.Point(614, 96);
            this.txtTenTrieuChung.Name = "txtTenTrieuChung";
            this.txtTenTrieuChung.Size = new System.Drawing.Size(337, 22);
            this.txtTenTrieuChung.TabIndex = 21;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(716, 273);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(135, 41);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // TrieuChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtTenTrieuChung);
            this.Controls.Add(this.txtMaTrieuChung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvTrieuChung);
            this.Name = "TrieuChung";
            this.Text = "TrieuChung";
            this.Load += new System.EventHandler(this.TrieuChung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrieuChung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrieuChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_trieu_chung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Trieu_chung;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTrieuChung;
        private System.Windows.Forms.TextBox txtTenTrieuChung;
        private System.Windows.Forms.Button btnDong;
    }
}