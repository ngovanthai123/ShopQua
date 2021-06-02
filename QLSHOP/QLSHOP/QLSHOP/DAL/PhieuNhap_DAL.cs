using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuNhap_DAL
    {
        static SqlConnection con;
        public static List<PhieuNhap_DTO> LayPN()
        {
            string sTruyVan = "select * from phieunhapsp";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuNhap_DTO> lstPN = new List<PhieuNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuNhap_DTO pn = new PhieuNhap_DTO();
                pn.Id = int.Parse(dt.Rows[i]["id"].ToString());
                pn.Tensp = dt.Rows[i]["TenSP"].ToString();
                pn.Soluong = dt.Rows[i]["soluong"].ToString();
                pn.Ngaynhap = DateTime.Parse(dt.Rows[i]["ngaynhap"].ToString());
                pn.Dongia = dt.Rows[i]["dongia"].ToString();
               
                lstPN.Add(pn);
            }
            return lstPN;
        }
        public static bool ThemPN(int ID, string TenSP, string SL, String Ngaynhap, string DonGia)

        {
            SqlConnection con;
            string sTruyVan = " INSERT INTO phieunhapsp VALUES(N'" + TenSP + "', '" + SL + "', N'" + Ngaynhap + "', N'" + DonGia + "')";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaPN(string ID)
        {
            string sTruyVan = string.Format(@"delete FROM phieunhapsp WHERE ID='{0}'", ID);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
         
            return kq;
        }
        public static bool SuaPn(PhieuNhap_DTO pn)
        {
            var ngay = pn.Ngaynhap.Date;
            string sTruyVan = string.Format($@"UPDATE phieunhapsp SET TenSP=N'{pn.Tensp}', soluong={pn.Soluong}, ngaynhap='{ngay.Year}-{ngay.Month}-{ngay.Day}', dongia={pn.Dongia} WHERE phieunhapsp.ID={pn.Id}");
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            return kq;
        }


    }
}
