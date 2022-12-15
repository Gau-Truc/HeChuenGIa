using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Luat : Form
    {
        private string trieuChung = "";
        private string ketLuan = "";
        private string idMaLuat = "";
        private int idx_row = -1;
        public Luat()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Luat_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            string sql_trieu_chung = "select Ma_Trieu_Chung as Ma, Ten_Trieu_Chung as Ten from Trieu_chung";
            DataTable table_trieu_chung = connect.ExecuteDataTable_SQL(sql_trieu_chung);
            string sql_ket_luan = "select Ma_Ket_Luan as Ma, Ten_Ket_Luan as Ten from Ket_Luan";
            DataTable table_ket_luan = connect.ExecuteDataTable_SQL(sql_ket_luan);
            string sql_luat = "select Ma_Tap_Luat, Cac_Trieu_Chung, Ket_Luan from Luat";
            DataTable table_luat = connect.ExecuteDataTable_SQL(sql_luat);

            DataTable dtCloned = table_trieu_chung.Clone();
            dtCloned.Columns[0].DataType = typeof(string);
            foreach (DataRow row in table_trieu_chung.Rows)
            {
                dtCloned.ImportRow(row);
            }

            dtCloned.Merge(table_ket_luan);
            dgvAddTrieuChung.DataSource = dtCloned;

            dgvAddKetLuan.DataSource = table_ket_luan;
            dgvLuat.DataSource = table_luat;
            txtKetLuan.Text = "";
            txtTrieuChung.Text = "";
            trieuChung = "";
            ketLuan = "";
            idMaLuat = "";
            btnThemLuat.Enabled = true;
            btnXoaLuat.Enabled = false;
            btnSuaLuat.Enabled = false;
            btnHoanTacKetLuan.Enabled = false;
            btnHoanTacTrieuChung.Enabled = false;
        }

        private void dgvAddTrieuChung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                string value = dgvAddTrieuChung.Rows[idx].Cells[0].Value.ToString();
                if (trieuChung == "")
                {
                    trieuChung = trieuChung + value;
                    btnHoanTacTrieuChung.Enabled = true;
                }
                else
                {
                    string[] mang;
                    mang = trieuChung.Split(',');
                    foreach (string item in mang)
                    {
                        if(item == value)
                        {
                            MessageBox.Show("Đã chọn triệu chứng này");
                            return;
                        }
                    }
                    trieuChung = trieuChung + "," + value;
                }
            }
            txtTrieuChung.Text = trieuChung;
        }

        private void btnHoanTacTrieuChung_Click(object sender, EventArgs e)
        {
            string[] mang;
            mang = trieuChung.Split(',');
            List<string> list = mang.ToList();
            //List<string> list = new List<string>();
            //list.AddRange(mang);
            list.RemoveAt(list.Count() - 1);
            trieuChung = String.Join(",", list);
            txtTrieuChung.Text = trieuChung;
            if (trieuChung == "")
                btnHoanTacTrieuChung.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgvAddKetLuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                string value = dgvAddKetLuan.Rows[idx].Cells[0].Value.ToString();
                if (ketLuan == "")
                {
                    ketLuan = ketLuan + value;
                    btnHoanTacKetLuan.Enabled = true;
                }
                else
                {
                    string[] mang;
                    mang = ketLuan.Split(',');
                    foreach (string item in mang)
                    {
                        if (item == value)
                        {
                            MessageBox.Show("Đã chọn kết luận này");
                            return;
                        }
                    }
                    ketLuan = ketLuan + "," + value;
                }
            }
            txtKetLuan.Text = ketLuan;
        }

        private void btnHoanTacKetLuan_Click(object sender, EventArgs e)
        {
            string[] mang;
            mang = ketLuan.Split(',');
            List<string> list = mang.ToList();
            //List<string> list = new List<string>();
            //list.AddRange(mang);
            list.RemoveAt(list.Count() - 1);
            ketLuan = String.Join(",", list);
            txtKetLuan.Text = ketLuan;
            if (ketLuan == "")
                btnHoanTacKetLuan.Enabled = false;
        }

        private void btnThemLuat_Click(object sender, EventArgs e)
        {
            string cacTrieuChung = txtTrieuChung.Text;
            string[] arrCacTrieuChung = cacTrieuChung.Split(',');
            Array.Sort(arrCacTrieuChung);
            string cacKetLuan = txtKetLuan.Text;
            string[] arrCacKetLuan = cacKetLuan.Split(',');
            Array.Sort(arrCacKetLuan);
            if (cacTrieuChung == "" || cacKetLuan == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            int length = (dgvLuat.Rows.Count) + 1;
            int dem = 1;
            for (int i = 0; i < dgvLuat.Rows.Count; i++)
            {
                string[] arrDgvTrieuChung = dgvLuat.Rows[i].Cells[1].Value.ToString().Split(',');
                Array.Sort(arrDgvTrieuChung);
                string[] arrDgvKetLuan = dgvLuat.Rows[i].Cells[2].Value.ToString().Split(',');
                Array.Sort(arrDgvKetLuan);
                if (arrCacTrieuChung.SequenceEqual(arrDgvTrieuChung))
                {
                    MessageBox.Show("Đã tồn tại các triệu chững đã chọn !");
                    dem = 0;
                    break;
                }
                if (arrCacKetLuan.SequenceEqual(arrDgvKetLuan))
                {
                    MessageBox.Show("Đã tồn tại các kết luận đã chọn !");
                    dem = 0;
                    break;
                }
            }
            if (dem == 1)
            {
                string sql = "insert into Luat(Ma_Tap_Luat, Cac_Trieu_Chung, Ket_Luan) values ('L" + length + "', N'" + cacTrieuChung + "', N'" + cacKetLuan + "')";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                btnThemLuat.Enabled = false;
                btnSuaLuat.Enabled = true;
                btnXoaLuat.Enabled = true;
                btnHoanTacKetLuan.Enabled = true;
                btnHoanTacTrieuChung.Enabled = true;
                idx_row = idx;
                idMaLuat = dgvLuat.Rows[idx].Cells[0].Value.ToString();
                txtTrieuChung.Text = dgvLuat.Rows[idx].Cells[1].Value.ToString();
                txtKetLuan.Text = dgvLuat.Rows[idx].Cells[2].Value.ToString();
                trieuChung = txtTrieuChung.Text;
                ketLuan = txtKetLuan.Text;
            }
        }

        private void btnSuaLuat_Click(object sender, EventArgs e)
        {
            string cacTrieuChung = txtTrieuChung.Text;
            string[] arrCacTrieuChung = cacTrieuChung.Split(',');
            Array.Sort(arrCacTrieuChung);
            string cacKetLuan = txtKetLuan.Text;
            string[] arrCacKetLuan = cacKetLuan.Split(',');
            Array.Sort(arrCacKetLuan);
            if (cacTrieuChung == "" || cacKetLuan == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            int dem = 1;
            for (int i = 0; i < dgvLuat.Rows.Count; i++)
            {
                if(i == idx_row)
                {
                    continue;
                }
                string[] arrDgvTrieuChung = dgvLuat.Rows[i].Cells[1].Value.ToString().Split(',');
                Array.Sort(arrDgvTrieuChung);
                string[] arrDgvKetLuan = dgvLuat.Rows[i].Cells[2].Value.ToString().Split(',');
                Array.Sort(arrDgvKetLuan);
                if (arrCacTrieuChung.SequenceEqual(arrDgvTrieuChung))
                {
                    MessageBox.Show("Đã tồn tại các triệu chững đã chọn !");
                    dem = 0;
                    break;
                }
                if (arrCacKetLuan.SequenceEqual(arrDgvKetLuan))
                {
                    MessageBox.Show("Đã tồn tại các kết luận đã chọn !");
                    dem = 0;
                    break;
                }
            }
            if (dem == 1)
            {
                string sql = "update Luat set Cac_Trieu_Chung = N'" + cacTrieuChung + "', Ket_Luan = N'" + cacKetLuan + "' where Ma_Tap_Luat = '" + idMaLuat + "'";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                return;
            }
        }

        private void btnXoaLuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                string sql = "delete from Luat where Ma_Tap_Luat = '" + idMaLuat + "'";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Xóa thành công");
            }
        }
    }
}
