using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KhachHang_DAL
    {
        static SqlConnection con;
        public static List<KhachHang_DTO> LayKH()
        {
            string sTruyVan = "select * from khachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKH = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Id = dt.Rows[i]["id"].ToString();
                kh.Hoten = dt.Rows[i]["hotenkh"].ToString();
                kh.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();

                lstKH.Add(kh);
            }
            return lstKH;
        }
        public static bool ThemKH(string id, string hoten, string gioitinh, string sdt )
        {
            
            string sTruyVan = " insert into khachhang values (N'"+id+"',N'"+hoten+"',N'"+gioitinh+"','"+sdt+"')";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaKH(string id, string hoten, string gioitinh, string sdt)
        {

            string sTruyVan = " update khachhang set hotenkh=N'" + hoten + "',gioitinh=N'" + gioitinh + "',sdt='" + sdt + "' where ID='"+id+"'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaKhachHang(string ID)
        {
            string sTruyVan = string.Format(@"delete from khachhang where ID=N'{0}'", ID);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }

        //TÌM  THEO TÊN
        public static List<KhachHang_DTO> TimKHTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"Select * from khachhang where hotenkh like N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKH = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Id = dt.Rows[i]["id"].ToString();
                kh.Hoten = dt.Rows[i]["hotenkh"].ToString();
                kh.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();

                lstKH.Add(kh);
            }
            return lstKH;
        }

        //TÌM  THEO Mã
        public static List<KhachHang_DTO> TimTheoID(string id)
        {
            string sTruyVan = string.Format(@"Select * from khachhang where ID like N'%{0}%'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKH = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Id = dt.Rows[i]["id"].ToString();
                kh.Hoten = dt.Rows[i]["hotenkh"].ToString();
                kh.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();

                lstKH.Add(kh);
            }
            return lstKH;
        }
    }
}
