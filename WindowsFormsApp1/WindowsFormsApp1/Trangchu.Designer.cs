﻿
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkbox1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.triệuChứngToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.triệuChứngToolStripMenuItem1.Text = "Triệu chứng";
            // 
            // kếtLuậnToolStripMenuItem1
            // 
            this.kếtLuậnToolStripMenuItem1.Name = "kếtLuậnToolStripMenuItem1";
            this.kếtLuậnToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.kếtLuậnToolStripMenuItem1.Text = "Kết luận";
            // 
            // luậtToolStripMenuItem1
            // 
            this.luậtToolStripMenuItem1.Name = "luậtToolStripMenuItem1";
            this.luậtToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.luậtToolStripMenuItem1.Text = "Luật";
            // 
            // TuVan
            // 
            this.TuVan.Location = new System.Drawing.Point(769, 40);
            this.TuVan.Name = "TuVan";
            this.TuVan.Size = new System.Drawing.Size(167, 41);
            this.TuVan.TabIndex = 3;
            this.TuVan.Text = "Tư vấn";
            this.TuVan.UseVisualStyleBackColor = true;
            this.TuVan.Click += new System.EventHandler(this.TuVan_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(599, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(616, 82);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTC,
            this.TenTC,
            this.Checkbox1});
            this.dataGridView2.Location = new System.Drawing.Point(12, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(565, 405);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // MaTC
            // 
            this.MaTC.DataPropertyName = "Ma_Trieu_Chung";
            this.MaTC.HeaderText = "Mã TC";
            this.MaTC.MinimumWidth = 6;
            this.MaTC.Name = "MaTC";
            this.MaTC.Width = 60;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "Ten_Trieu_Chung";
            this.TenTC.HeaderText = "Tên TC";
            this.TenTC.MinimumWidth = 6;
            this.TenTC.Name = "TenTC";
            this.TenTC.Width = 125;
            // 
            // Checkbox1
            // 
            this.Checkbox1.DataPropertyName = "Checkbox";
            this.Checkbox1.HeaderText = "Checkbox1";
            this.Checkbox1.MinimumWidth = 6;
            this.Checkbox1.Name = "Checkbox1";
            this.Checkbox1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Checkbox1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Checkbox1.Width = 125;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1307, 680);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox1;
    }
}
