using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Trangchu : Form
    {
        private string Cac_trieu_chung = "";
        public Trangchu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            string sql1 = "update Trieu_chung set Checkbox='false'";
            connect.ExecuteNonData(sql1);
            string sql = "select * from Trieu_chung";
            DataTable table= connect.ExecuteDataTable_SQL(sql);
            dataGridView2.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TuVan_Click(object sender, EventArgs e)
        {
            string sql = "select Ma_Trieu_Chung from Trieu_Chung where Checkbox='true'";
            DataTable table = connect.ExecuteDataTable_SQL(sql);
            string[] mang = new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string rowValue = row["Ma_Trieu_Chung"].ToString();
                mang[i] = rowValue;
                
            }
            string select_luat = "select * from Luat";
            DataTable table_luat = connect.ExecuteDataTable_SQL(select_luat);
            string KL_phu = "";
            //string[] mang_luat = new string[table_luat.Rows.Count];
            for (int i = 0; i < table_luat.Rows.Count; i++)
            {
                DataRow row = table_luat.Rows[i];
                string rowValue = row["Cac_Trieu_Chung"].ToString();
                string[] mang_luat = rowValue.Split(',');
                Array.Sort(mang_luat);
                int KiemTra = KiemTraTonTai(mang_luat, mang);
                if (KiemTra == 1)
                {
                    string Ket_Luan = row["Ket_Luan"].ToString();
                    string rowValue_TenKetLuan = Select_data(Ket_Luan);
                    textBox1.Text = rowValue_TenKetLuan;
                    break;
                }
                else if (KiemTra == 2)
                {
                    string Ket_Luan = row["Ket_Luan"].ToString();
                    string rowValue_TenKetLuan = Select_data(Ket_Luan);
                    textBox1.Text = "Nghi ngờ bị " + rowValue_TenKetLuan;
                    break;
                }
                else
                {
                 
                    textBox1.Text = "false";
                }
               
                //mang_luat[i] = rowValue;
                //MessageBox.Show(mang_luat[i]);
            }



            //SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MAVHB4L2\\SQLEXPRESS;Initial Catalog=ChuanDoanBenhPhoi;user id=sa;password=29102001lun");
            //conn.Open();
            //string sql = "select Ma_Trieu_Chung from Trieu_Chung where Checkbox='true'";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //var reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    // Đọc từng dòng tập kết quả
            //    while (reader.Read())
            //    {

            //        var tendanhmuc = reader["Ma_Trieu_Chung"];

            //        Console.WriteLine(tendanhmuc);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Không có dữ liệu trả về");
            //}

            //conn.Close();
        }

        private string Select_data(string Ket_Luan)
        {
            string Ten_Ket_Luan = "select Ten_Ket_Luan from Ket_Luan where Ma_Ket_Luan='" + Ket_Luan + "'";
            DataTable Table_TenKetLuan = connect.ExecuteDataTable_SQL(Ten_Ket_Luan);
            DataRow row_TenKetLuan = Table_TenKetLuan.Rows[0];
            string rowValue_TenKetLuan = row_TenKetLuan["Ten_Ket_Luan"].ToString();
            return rowValue_TenKetLuan;
        }
        private int KiemTraTonTai(string[] a, string[] b)
        {
            int len1 = a.Length;
            int len2 = b.Length;
            int dem_giong = 0;
            for (int i=0;i<len1;i++)
            {
                for(int j=0;j<len2;j++)
                {
                    if(string.Compare(a[i],b[j])==0)
                    {
                        dem_giong++;
                        break;
                    }
                    
                }
            }
            if (dem_giong / len2 == 1 && dem_giong / len1 == 1)
            {
                return 1;
            }
            else
            {
                double c =  Convert.ToDouble(dem_giong)/ Convert.ToDouble(len1);
                if (c > 0.5 && dem_giong / len2 == 1)
                    return 2;
                else
                    return -1;
            }
               
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            int idx = e.RowIndex;
          
            if (idx >= 0 && idx < dataGridView2.RowCount - 1)
            {
                //string a = dataGridView1.Rows[idx].Cells["MaTrieuChung"].Value.ToString();
                //MessageBox.Show(a);
                string a = dataGridView2.Rows[idx].Cells["Checkbox1"].Value.ToString();
                string b = dataGridView2.Rows[idx].Cells["MaTC"].Value.ToString();
              

                //Cac_trieu_chung += 
                string sql = "Update Trieu_chung ";
                if (a == "true")
                {
                    sql += "set Checkbox=\'false\' ";
                }
                else
                {
                    sql += "set Checkbox=\'true\' ";
                }
                sql += " where Ma_Trieu_Chung = " + "\'" + b + "\'";


                connect.ExecuteNonData(sql);

            }
            string sql1 = "select * from Trieu_chung";
            DataTable table = connect.ExecuteDataTable_SQL(sql1);
            dataGridView2.DataSource = table;
        }
    }
}
