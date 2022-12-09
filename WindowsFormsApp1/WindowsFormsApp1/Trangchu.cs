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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TuVan_Click(object sender, EventArgs e)
        {
            KetQua.Text = "";
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
            string[] arrKiemTraTonTai = new string[table_luat.Rows.Count];
            //string[] mang_luat = new string[table_luat.Rows.Count];
            for (int i = 0; i < table_luat.Rows.Count; i++)
            {
                DataRow row = table_luat.Rows[i];
                string rowValue = row["Cac_Trieu_Chung"].ToString();
                string[] mang_luat = rowValue.Split(',');
                Array.Sort(mang_luat);
                string KiemTra = KiemTraTonTai(mang,mang_luat);
                string Ket_Luan = row["Ket_Luan"].ToString();
                string rowValue_TenKetLuan = Select_data(Ket_Luan);
                if (KiemTra=="true")
                {
                   
                    KetQua.Text = rowValue_TenKetLuan;
                    GiaiThich.Text = rowValue + "\n==>\n" + Ket_Luan;
                    break;
                }
                else
                {
                    arrKiemTraTonTai[i] = KiemTra +"."+ rowValue+"."+ Ket_Luan+ "." + rowValue_TenKetLuan;

                }
            }
            //MessageBox.Show(arrKiemTraTonTai.Min().ToString());
            int min = 10000;
            if (arrKiemTraTonTai != null && KetQua.Text=="")
            {
                foreach (string i in arrKiemTraTonTai)
                {
                    string[] Kiem_Tra_CT = i.Split('.');
                    if (Kiem_Tra_CT[0].Trim() == "KN")
                    {
                        KetQua.Text = "Nghi ngờ bị " + Kiem_Tra_CT[3];
                        GiaiThich.Text = Kiem_Tra_CT[1] + "\n==>\n" + Kiem_Tra_CT[2];
                        break;
                    }
                    if (Kiem_Tra_CT[0].Trim() == "KNCONGTC")
                    {
                        if (Convert.ToInt32(Kiem_Tra_CT[Kiem_Tra_CT.Length - 4]) <= min)
                        {
                            string Ten_Trieu_Chung = "";
                            min = Convert.ToInt32(Kiem_Tra_CT[Kiem_Tra_CT.Length - 4]);
                            int bd = 1;
                            int kt= 1+min;
                            Ten_Trieu_Chung = Select_Ten_Trieu_Chung(Kiem_Tra_CT[bd].ToString());
                            for (int z =bd+1; z<kt;z++)
                                Ten_Trieu_Chung= Ten_Trieu_Chung+","+ Select_Ten_Trieu_Chung(Kiem_Tra_CT[z].ToString());
                            KetQua.Text = "Nghi ngờ bị " + Kiem_Tra_CT[Kiem_Tra_CT.Length - 1] + "--" + Ten_Trieu_Chung;
                            GiaiThich.Text = Kiem_Tra_CT[Kiem_Tra_CT.Length - 3] + "\n==>\n" + Kiem_Tra_CT[Kiem_Tra_CT.Length - 2];
                        }
                        
                    }

                }
            }

    

        }
        private string Select_Ten_Trieu_Chung(string TrieuChung)
        {
            string Ten_Ket_Luan = "select Ten_Trieu_Chung from Trieu_chung where Ma_Trieu_Chung='" + TrieuChung + "'";
            DataTable Table_TenKetLuan = connect.ExecuteDataTable_SQL(Ten_Ket_Luan);
            DataRow row_TenKetLuan = Table_TenKetLuan.Rows[0];
            string rowValue_TenKetLuan = row_TenKetLuan["Ten_Trieu_Chung"].ToString();
            return rowValue_TenKetLuan;
        }

        private string Select_data(string Ket_Luan)
        {
            string Ten_Ket_Luan = "select Ten_Ket_Luan from Ket_Luan where Ma_Ket_Luan='" + Ket_Luan + "'";
            DataTable Table_TenKetLuan = connect.ExecuteDataTable_SQL(Ten_Ket_Luan);
            DataRow row_TenKetLuan = Table_TenKetLuan.Rows[0];
            string rowValue_TenKetLuan = row_TenKetLuan["Ten_Ket_Luan"].ToString();
            return rowValue_TenKetLuan;
        }
        private string KiemTraTonTai(string[] Trieu_Chung_Chon, string[] Tap_luat)
        {
            int len_trieu_chung_chon = Trieu_Chung_Chon.Length;//len luật sql
            int len_tap_luat = Tap_luat.Length;// len triệu chứng chọn
            int dem_giong = 0;
            string str = "";
            //for (int i=0;i<len1;i++)
            //{
            //    for(int j=0;j<len2;j++)
            //    {
            //        if(string.Compare(a[i],b[j])==0)
            //        {
            //            dem_giong++;
            //            break;
            //        }
                    
            //    }
            //}
            if  (Trieu_Chung_Chon.SequenceEqual(Tap_luat)==true)
            {
                str= "true";
            }
            else
            {
                for (int i = 0; i < len_trieu_chung_chon; i++)
                {
                    for (int j = 0; j < len_tap_luat; j++)
                    {
                        if (string.Compare(Trieu_Chung_Chon[i], Tap_luat[j]) == 0)
                        {
                            dem_giong++;
                            break;
                        }

                    }
                }
                double c = Convert.ToDouble(dem_giong) / Convert.ToDouble(len_tap_luat);
                double d = Convert.ToDouble(dem_giong) / Convert.ToDouble(len_trieu_chung_chon);
                if (c > 0.5 && dem_giong / len_trieu_chung_chon == 1)
                    str= "KN";
                else
                    if(c == 1 && len_trieu_chung_chon>len_tap_luat)
                {
                    str = "KNCONGTC";
                    //So_Sanh_Hai_Mang(Trieu_Chung_Chon, Tap_luat, len_trieu_chung_chon, len_tap_luat);
                    string TonTai = "";
                    string[] arr_Khac = new string[len_trieu_chung_chon];
                    int dem_phan_tu_mang = 0;
                    for (int i = 0; i < len_trieu_chung_chon; i++)
                    {
                        TonTai = "";
                        for (int j = 0; j < len_tap_luat; j++)
                        {
                            if (string.Compare(Trieu_Chung_Chon[i], Tap_luat[j]) == 0)
                            {
                                TonTai = "True";
                                break;
                            }

                        }
                        if (TonTai != "True")
                        {
                            arr_Khac[dem_phan_tu_mang] = Trieu_Chung_Chon[i];
                            str = str + "." + Trieu_Chung_Chon[i];
                            dem_phan_tu_mang++;
                        }
                    }
                    str = str + "." + dem_phan_tu_mang;

                }
            }

            return str;
        }

        //private string[] So_Sanh_Hai_Mang(string[] Trieu_Chung_Chon, string[] Tap_luat,int len_trieu_chung_chon,int len_tap_luat)
        //{
        //    string TonTai = "";
        //    string[] arr_Khac = new string[len_trieu_chung_chon];
        //    int dem_phan_tu_mang = 0;
        //    for (int i = 0; i < len_trieu_chung_chon; i++)
        //    {
        //        for (int j = 0; j < len_tap_luat; j++)
        //        {
        //            if (string.Compare(Trieu_Chung_Chon[i], Tap_luat[j]) == 0)
        //            {
        //                TonTai = "True";
        //                break;
        //            }

        //        }
        //        if(TonTai == "True")
        //        {
        //            arr_Khac[dem_phan_tu_mang] = Trieu_Chung_Chon[i];
        //            dem_phan_tu_mang++;
        //            TonTai = "False";
        //            break;
        //        }
        //        return arr_Khac;
        //    }
        //}

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            if (idx >= 0 && idx < dataGridView2.RowCount - 1)
            {
                idx = idx + 1;
                string sql1 = "select * from Trieu_chung where Ma_Trieu_Chung='" + idx + "'";
                DataTable table = connect.ExecuteDataTable_SQL(sql1);
                DataRow row_TenKetLuan = table.Rows[0];
                string a = row_TenKetLuan["Checkbox"].ToString().Trim();
                string sql = "Update Trieu_chung ";
                if (a == "true")
                {
                    sql += "set Checkbox=\'false\' ";
                }
                else
                {
                    sql += "set Checkbox=\'true\' ";
                }
                sql += " where Ma_Trieu_Chung = " + "\'" + idx + "\'";

                connect.ExecuteNonData(sql);

            }
        }

        private void GiaiThich_TextChanged(object sender, EventArgs e)
        {
            //string sql1 = "select * from Trieu_chung where Ma_Trieu_Chung='" + idx + "'";
        }
    }
}
