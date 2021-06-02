using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
   

        public static SqlConnection MoKetNoi()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-R5QB9QIO;Initial Catalog=QLSHOPQUALUUNIEM;Integrated Security=True";
            con.Open();
            return con;
        }
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {

                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public static SqlConnection DongKetNoi(SqlConnection con)
        {
            SqlConnection KetNoi = new SqlConnection(@"Data Source=THAO\SQLEXPRESS;Initial Catalog=QLCH3;Integrated Security=True");
            KetNoi.Close();
            return KetNoi;
        }
		
			}
		}


