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
                if
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

        private int KiemTraTonTai(string[] a, string[] b)
        {
            int len1 = a.Length;
            int len2 = b.Length;
            int dem_giong = 0;
            int dem_khac = 0;
            for (int i=0;i<len1;i++)
            {
                for(int j=0;j<len2;j++)
                {
                    if(string.Compare(a[i],b[j])==0)
                    {
                        dem_giong++;
                        break;
                    }
                    else
                    {
                        dem_khac++;
                    }
                }
            }
            return dem/len2;
            if (dem==len2)
            {
                MessageBox.Show("Chắc chắn bị "+KetLuan);
            }
            else
            {
                if(dem/len1 >0.5)
                {
                    MessageBox.Show("Nghi ngờ bị " + KetLuan);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
        }
    }
}
