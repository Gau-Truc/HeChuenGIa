
namespace WindowsFormsApp1
{
    partial class Trangchu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TuVan = new System.Windows.Forms.Button();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GiaiThich = new System.Windows.Forms.TextBox();
            this.GVTapLuat = new System.Windows.Forms.DataGridView();
            this.MaL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVLuat = new System.Windows.Forms.DataGridView();
            this.MaKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTrieuChung = new System.Windows.Forms.Button();
            this.btnKetLuan = new System.Windows.Forms.Button();
            this.btnLuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTapLuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVLuat)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpToolStripMenuItem
            // 
            this.tậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tậpToolStripMenuItem.Name = "tậpToolStripMenuItem";
            this.tậpToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tậpToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // TuVan
            // 
            this.TuVan.Location = new System.Drawing.Point(12, 301);
            this.TuVan.Name = "TuVan";
            this.TuVan.Size = new System.Drawing.Size(167, 41);
            this.TuVan.TabIndex = 3;
            this.TuVan.Text = "Tư vấn";
            this.TuVan.UseVisualStyleBackColor = true;
            this.TuVan.Click += new System.EventHandler(this.TuVan_Click);
            // 
            // KetQua
            // 
            this.KetQua.Enabled = false;
            this.KetQua.Location = new System.Drawing.Point(12, 348);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(1283, 34);
            this.KetQua.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTC,
            this.TenTC,
            this.Checkbox});
            this.dataGridView2.Location = new System.Drawing.Point(12, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1283, 264);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // MaTC
            // 
            this.MaTC.DataPropertyName = "Ma_Trieu_Chung";
            this.MaTC.HeaderText = "Mã triệu chứng";
            this.MaTC.MinimumWidth = 6;
            this.MaTC.Name = "MaTC";
            this.MaTC.ReadOnly = true;
            this.MaTC.Width = 125;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "Ten_Trieu_Chung";
            this.TenTC.HeaderText = "Tên triệu chứng";
            this.TenTC.MinimumWidth = 6;
            this.TenTC.Name = "TenTC";
            this.TenTC.ReadOnly = true;
            this.TenTC.Width = 800;
            // 
            // Checkbox
            // 
            this.Checkbox.DataPropertyName = "Checkbox";
            this.Checkbox.HeaderText = "";
            this.Checkbox.MinimumWidth = 6;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.ReadOnly = true;
            this.Checkbox.Width = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giải thích:";
            // 
            // GiaiThich
            // 
            this.GiaiThich.Enabled = false;
            this.GiaiThich.Location = new System.Drawing.Point(12, 414);
            this.GiaiThich.Multiline = true;
            this.GiaiThich.Name = "GiaiThich";
            this.GiaiThich.Size = new System.Drawing.Size(386, 254);
            this.GiaiThich.TabIndex = 9;
            this.GiaiThich.TextChanged += new System.EventHandler(this.GiaiThich_TextChanged);
            // 
            // GVTapLuat
            // 
            this.GVTapLuat.AllowUserToAddRows = false;
            this.GVTapLuat.AllowUserToDeleteRows = false;
            this.GVTapLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVTapLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaL,
            this.TenL,
            this.KL});
            this.GVTapLuat.Location = new System.Drawing.Point(420, 414);
            this.GVTapLuat.Name = "GVTapLuat";
            this.GVTapLuat.ReadOnly = true;
            this.GVTapLuat.RowHeadersWidth = 51;
            this.GVTapLuat.RowTemplate.Height = 24;
            this.GVTapLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTapLuat.Size = new System.Drawing.Size(416, 254);
            this.GVTapLuat.TabIndex = 10;
            // 
            // MaL
            // 
            this.MaL.DataPropertyName = "Ma_Tap_Luat";
            this.MaL.HeaderText = "Mã tập luật";
            this.MaL.MinimumWidth = 6;
            this.MaL.Name = "MaL";
            this.MaL.Width = 125;
            // 
            // TenL
            // 
            this.TenL.DataPropertyName = "Cac_Trieu_Chung";
            this.TenL.HeaderText = "Các triệu chứng";
            this.TenL.MinimumWidth = 6;
            this.TenL.Name = "TenL";
            this.TenL.Width = 125;
            // 
            // KL
            // 
            this.KL.DataPropertyName = "Ket_Luan";
            this.KL.HeaderText = "Kết luận";
            this.KL.MinimumWidth = 6;
            this.KL.Name = "KL";
            this.KL.Width = 125;
            // 
            // GVLuat
            // 
            this.GVLuat.AllowUserToAddRows = false;
            this.GVLuat.AllowUserToDeleteRows = false;
            this.GVLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKL,
            this.TenKL});
            this.GVLuat.Location = new System.Drawing.Point(874, 414);
            this.GVLuat.Name = "GVLuat";
            this.GVLuat.ReadOnly = true;
            this.GVLuat.RowHeadersWidth = 51;
            this.GVLuat.RowTemplate.Height = 24;
            this.GVLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVLuat.Size = new System.Drawing.Size(400, 254);
            this.GVLuat.TabIndex = 11;
            // 
            // MaKL
            // 
            this.MaKL.DataPropertyName = "Ma_Ket_Luan";
            this.MaKL.HeaderText = "Mã kết luận";
            this.MaKL.MinimumWidth = 6;
            this.MaKL.Name = "MaKL";
            this.MaKL.Width = 125;
            // 
            // TenKL
            // 
            this.TenKL.DataPropertyName = "Ten_Ket_Luan";
            this.TenKL.HeaderText = "Tên kết luận";
            this.TenKL.MinimumWidth = 6;
            this.TenKL.Name = "TenKL";
            this.TenKL.Width = 125;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(185, 301);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(174, 41);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTrieuChung
            // 
            this.btnTrieuChung.Location = new System.Drawing.Point(365, 301);
            this.btnTrieuChung.Name = "btnTrieuChung";
            this.btnTrieuChung.Size = new System.Drawing.Size(135, 41);
            this.btnTrieuChung.TabIndex = 13;
            this.btnTrieuChung.Text = "Triệu chứng";
            this.btnTrieuChung.UseVisualStyleBackColor = true;
            this.btnTrieuChung.Click += new System.EventHandler(this.btnTrieuChung_Click);
            // 
            // btnKetLuan
            // 
            this.btnKetLuan.Location = new System.Drawing.Point(506, 301);
            this.btnKetLuan.Name = "btnKetLuan";
            this.btnKetLuan.Size = new System.Drawing.Size(135, 41);
            this.btnKetLuan.TabIndex = 14;
            this.btnKetLuan.Text = "Kết luận";
            this.btnKetLuan.UseVisualStyleBackColor = true;
            this.btnKetLuan.Click += new System.EventHandler(this.btnKetLuan_Click);
            // 
            // btnLuat
            // 
            this.btnLuat.Location = new System.Drawing.Point(647, 301);
            this.btnLuat.Name = "btnLuat";
            this.btnLuat.Size = new System.Drawing.Size(135, 41);
            this.btnLuat.TabIndex = 15;
            this.btnLuat.Text = "Luật";
            this.btnLuat.UseVisualStyleBackColor = true;
            this.btnLuat.Click += new System.EventHandler(this.btnLuat_Click);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1307, 680);
            this.Controls.Add(this.btnLuat);
            this.Controls.Add(this.btnKetLuan);
            this.Controls.Add(this.btnTrieuChung);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.GVLuat);
            this.Controls.Add(this.GVTapLuat);
            this.Controls.Add(this.GiaiThich);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.TuVan);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVTapLuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVLuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button TuVan;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GiaiThich;
        private System.Windows.Forms.DataGridView GVTapLuat;
        private System.Windows.Forms.DataGridView GVLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTrieuChung;
        private System.Windows.Forms.Button btnKetLuan;
        private System.Windows.Forms.Button btnLuat;
    }
}

