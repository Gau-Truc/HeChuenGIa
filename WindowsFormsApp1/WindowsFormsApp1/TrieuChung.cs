using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TrieuChung : Form
    {
        public TrieuChung()
        {
            InitializeComponent();
        }

        private void TrieuChung_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            string sql = "select Ma_Trieu_Chung, Ten_Trieu_Chung from Trieu_chung";
            DataTable table = connect.ExecuteDataTable_SQL(sql);
            dgvTrieuChung.DataSource = table;
            txtMaTrieuChung.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaTrieuChung.Text = "";
            txtTenTrieuChung.Text = "";
            btnThem.Enabled = true;
        }

        private Boolean isNumber(string so)
        {
            try
            {
                int i = int.Parse(so);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTrieuChung = txtTenTrieuChung.Text;
            if(tenTrieuChung == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            int dem = 1;
            for (int i = 0; i < dgvTrieuChung.Rows.Count; i++)
            {
                if (tenTrieuChung.ToLower() == dgvTrieuChung.Rows[i].Cells[1].Value.ToString().ToLower())
                {
                    MessageBox.Show("Đã tồn tại tên triệu chứng !");
                    dem = 0;
                    break;
                }
            }
            if (dem == 1)
            {
                string sql = "insert into Trieu_chung(Ten_Trieu_Chung) values (N'" + tenTrieuChung + "')";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                return;
            }
        }

        private void dgvTrieuChung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

                txtMaTrieuChung.Text = dgvTrieuChung.Rows[idx].Cells[0].Value.ToString();
                txtTenTrieuChung.Text = dgvTrieuChung.Rows[idx].Cells[1].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTrieuChung = txtMaTrieuChung.Text;
            string tenTrieuChung = txtTenTrieuChung.Text;
            if (tenTrieuChung == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            int dem = 1;
            for (int i = 0; i < dgvTrieuChung.Rows.Count; i++)
            {
                if (tenTrieuChung == dgvTrieuChung.Rows[i].Cells[1].Value.ToString())
                {
                    MessageBox.Show("Đã tồn tại tên triệu chứng !");
                    dem = 0;
                    break;
                }
            }
            if (dem == 1)
            {
                string sql = "update Trieu_chung set Ten_Trieu_Chung = N'" + tenTrieuChung + "' where Ma_Trieu_Chung = '" + maTrieuChung + "'";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                string maTrieuChung = txtMaTrieuChung.Text;
                string sql_luat = "select * from Luat";
                DataTable tbLuat = connect.ExecuteDataTable_SQL(sql_luat);
                string[] mang;
                for (int i = 0; i < tbLuat.Rows.Count; i++)
                {
                    DataRow row = tbLuat.Rows[i];
                    string rowValue = row["Cac_Trieu_Chung"].ToString();
                    mang = rowValue.Split(',');
                    foreach (string s in mang)
                    {
                        if(maTrieuChung == s)
                        {
                            MessageBox.Show("Triệu chứng có trong luật, không thể xóa!");
                            return;
                        }
                    }
                }
                string sql = "delete from Trieu_chung where Ma_Trieu_Chung = '" + maTrieuChung + "'";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Trangchu trangchu = new Trangchu();
            trangchu.Show();
            this.Close();
        }
    }
}
