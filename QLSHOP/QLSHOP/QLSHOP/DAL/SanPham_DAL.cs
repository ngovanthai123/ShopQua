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
    public class SanPham_DAL
    {
        static SqlConnection con;

        public static List<SanPham_DTO> LaySanPham()
        {
            string sTruyVan = "select n.*, c.tenloai   from sanpham n, loaisp c   where n.idLoaisp=c.maloai ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                sp.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public static List<SanPham_DTO> LaySanPhamTrongPhieuNhap(int maPhieuNhap)
        {
            string sTruyVan = $"select n.*, c.tenloai from sanpham n, loaisp c   where n.idLoaisp=c.maloai and n.ID = {maPhieuNhap}";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                sp.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public static bool ThemSP(int id, string masp, string tensp, int soluong, int dongiaban, string idloaisp)
        {

            string sTruyVan = " insert into sanpham values(" + id + ", '" + masp + "', N'" + tensp + "', " + soluong + ", " + dongiaban + ", '" + idloaisp + "')";

            SqlConnection con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            return kq;
        }
        //public static bool SuaSP(string ID, string tensp, string soluong, string dongiaban, string IDloaisp)

        //{
        //    SqlConnection con;
        //    string sTruyVan = string.Format("UPDATE sanpham SET tensp=N'" + tensp + "',soluong='" + soluong + "',dongiaban='" + dongiaban + "',IDloaisp='" + IDloaisp + "',WHERE ID='" + ID + "'");
        //    con = DataProvider.MoKetNoi();
        //    bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
        //    DataProvider.DongKetNoi(con);
        //    return kq;
        //}


        public static bool SuaSanPham(int id, string masp, string tensp, int soluong, int dongiaban, string idloaisp)

        {
            SqlConnection con;
            string sTruyVan = string.Format(@"UPDATE sanpham SET   ID = '{1}', tensp = N'{2} ', soluong = '{3}', dongiaban = '{4}',idloaisp='{5}' WHERE masp = '{0}'", masp, id, tensp, soluong, dongiaban,idloaisp);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            return kq;
        }
        public static bool XoaSanPham(string MaSP)
        {
            string sTruyVan = string.Format(@"delete from sanpham where masp=N'{0}'", MaSP);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<SanPham_DTO> TimSPTheoTen(string ten)
        {
            string sTruyVan = @"select * from sanpham where tensp like N'%"+ten+"%'";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }
        public static List<SanPham_DTO> TimSPTheoMa(string ma)
        {
            string sTruyVan = @"select * from sanpham where masp = N'"+ma+"'";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }
    }
}