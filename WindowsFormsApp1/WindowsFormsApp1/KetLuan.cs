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
    public partial class KetLuan : Form
    {
        public KetLuan()
        {
            InitializeComponent();
        }

        private void KetLuan_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            string sql = "select Ma_Ket_Luan, Ten_Ket_Luan from Ket_Luan";
            DataTable table = connect.ExecuteDataTable_SQL(sql);
            dgvKetLuan.DataSource = table;
            txtMaKetLuan.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTenKetLuan.Text = "";
            txtMaKetLuan.Text = "";
            btnThem.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private Boolean isString(string so)
        {
            try
            {
                float i = float.Parse(so);
                return false;
            }
            catch
            {
                return true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKetLuan = txtMaKetLuan.Text;
            string tenKetLuan = txtTenKetLuan.Text;
            if (maKetLuan == "" || tenKetLuan == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (isString(maKetLuan) == false)
            {
                MessageBox.Show("Mã phải có chữ");
                return;
            }
            if (isString(tenKetLuan) == false)
            {
                MessageBox.Show("Tên phải có chữ");
                return;
            }
            int dem = 1;
            for (int i = 0; i < dgvKetLuan.Rows.Count; i++)
            {
                if (maKetLuan.ToLower() == dgvKetLuan.Rows[i].Cells[0].Value.ToString().ToLower())
                {
                    MessageBox.Show("Đã tồn tại mã kết luận !");
                    dem = 0;
                    break;
                }
                if (tenKetLuan.ToLower() == dgvKetLuan.Rows[i].Cells[1].Value.ToString().ToLower())
                {
                    MessageBox.Show("Đã tồn tại tên kết luận !");
                    dem = 0;
                    break;
                }
            }
            if (dem == 1)
            {
                string sql = "insert into Ket_Luan(Ma_Ket_Luan, Ten_Ket_Luan) values (N'" + maKetLuan.ToUpper() + "', N'" + tenKetLuan + "')";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKetLuan = txtMaKetLuan.Text;
            string tenKetLuan = txtTenKetLuan.Text;
            if (tenKetLuan == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            if (isString(tenKetLuan) == false)
            {
                MessageBox.Show("Tên phải có chữ");
                return;
            }
            int dem = 1;
            for (int i = 0; i < dgvKetLuan.Rows.Count; i++)
            {
                if (tenKetLuan.ToLower() == dgvKetLuan.Rows[i].Cells[1].Value.ToString().ToLower())
                {
                    MessageBox.Show("Đã tồn tại tên kết luận !");
                    dem = 0;
                    break;
                }
            }
            if (dem == 1)
            {
                string sql = "update Ket_Luan set Ten_Ket_Luan = N'" + tenKetLuan + "' where Ma_Ket_Luan = '" + maKetLuan + "'";
                connect.ExecuteNonData(sql);
                load_data();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                return;
            }
        }

        private void dgvKetLuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaKetLuan.Enabled = false;

                txtMaKetLuan.Text = dgvKetLuan.Rows[idx].Cells[0].Value.ToString();
                txtTenKetLuan.Text = dgvKetLuan.Rows[idx].Cells[1].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                string maKetLuan = txtMaKetLuan.Text;
                string sql_luat = "select * from Luat";
                DataTable tbLuat = connect.ExecuteDataTable_SQL(sql_luat);
                string[] mang;
                for (int i = 0; i < tbLuat.Rows.Count; i++)
                {
                    DataRow row = tbLuat.Rows[i];
                    string rowValue = row["Cac_Trieu_Chung"].ToString();
                    if(maKetLuan == row["Ket_Luan"].ToString())
                    {
                        MessageBox.Show("Kết luận có trong luật, không thể xóa!");
                        return;
                    }
                    mang = rowValue.Split(',');
                    foreach (string s in mang)
                    {
                        if (maKetLuan == s)
                        {
                            MessageBox.Show("Kết luận có trong luật, không thể xóa!");
                            return;
                        }
                    }
                }
                string sql = "delete from Ket_Luan where Ma_Ket_Luan = '" + maKetLuan + "'";
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
