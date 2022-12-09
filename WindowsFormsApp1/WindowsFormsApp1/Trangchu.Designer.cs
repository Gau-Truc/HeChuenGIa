
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
            this.kếtLuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triệuChứngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtLuậnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.luậtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TuVan = new System.Windows.Forms.Button();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GiaiThich = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpToolStripMenuItem,
            this.kếtLuậnToolStripMenuItem});
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
            // kếtLuậnToolStripMenuItem
            // 
            this.kếtLuậnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triệuChứngToolStripMenuItem1,
            this.kếtLuậnToolStripMenuItem1,
            this.luậtToolStripMenuItem1});
            this.kếtLuậnToolStripMenuItem.Name = "kếtLuậnToolStripMenuItem";
            this.kếtLuậnToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.kếtLuậnToolStripMenuItem.Text = "Quản lý";
            // 
            // triệuChứngToolStripMenuItem1
            // 
            this.triệuChứngToolStripMenuItem1.Name = "triệuChứngToolStripMenuItem1";
            this.triệuChứngToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.triệuChứngToolStripMenuItem1.Text = "Triệu chứng";
            // 
            // kếtLuậnToolStripMenuItem1
            // 
            this.kếtLuậnToolStripMenuItem1.Name = "kếtLuậnToolStripMenuItem1";
            this.kếtLuậnToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.kếtLuậnToolStripMenuItem1.Text = "Kết luận";
            // 
            // luậtToolStripMenuItem1
            // 
            this.luậtToolStripMenuItem1.Name = "luậtToolStripMenuItem1";
            this.luậtToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.luậtToolStripMenuItem1.Text = "Luật";
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
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTC,
            this.TenTC,
            this.Checkbox});
            this.dataGridView2.Location = new System.Drawing.Point(12, 31);
            this.dataGridView2.Name = "dataGridView2";
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
            this.MaTC.Width = 125;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "Ten_Trieu_Chung";
            this.TenTC.HeaderText = "Tên triệu chứng";
            this.TenTC.MinimumWidth = 6;
            this.TenTC.Name = "TenTC";
            this.TenTC.Width = 800;
            // 
            // Checkbox
            // 
            this.Checkbox.DataPropertyName = "Checkbox";
            this.Checkbox.HeaderText = "";
            this.Checkbox.MinimumWidth = 6;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Width = 20;
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
            this.GiaiThich.Location = new System.Drawing.Point(12, 414);
            this.GiaiThich.Multiline = true;
            this.GiaiThich.Name = "GiaiThich";
            this.GiaiThich.Size = new System.Drawing.Size(626, 254);
            this.GiaiThich.TabIndex = 9;
            this.GiaiThich.TextChanged += new System.EventHandler(this.GiaiThich_TextChanged);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1307, 680);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtLuậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triệuChứngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kếtLuậnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem luậtToolStripMenuItem1;
        private System.Windows.Forms.Button TuVan;
        private System.Windows.Forms.TextBox KetQua;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GiaiThich;
    }
}

