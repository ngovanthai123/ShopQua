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
    public class LoaiSP_DAL
    {
        static SqlConnection con;

        public static List<LoaiSP_DTO> LayLoai()
        {
            string sTruyVan = "select * from loaisp";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiSP_DTO> lstLoaiSP = new List<LoaiSP_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiSP_DTO lsp = new LoaiSP_DTO();
                lsp.Id = int.Parse(dt.Rows[i]["id"].ToString());
                lsp.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lsp.Maloai = dt.Rows[i]["maloai"].ToString();

                lstLoaiSP.Add(lsp);
            }
            return lstLoaiSP;
        }
        public static bool ThemLoai(LoaiSP_DTO l)
        {
            string sTruyVan = string.Format(@"insert into loaisp values('{0}',N'{1}')", l.Maloai,l.Tenloai);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool SuaLoai(LoaiSP_DTO l)
        {
            string sTruyVan = string.Format(@"UPDATE loaisp SET maloai='{1}'WHERE tenloai=N'{0}'", l.Tenloai,l.Maloai);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool XoaLoai(LoaiSP_DTO l)
        {
            string sTruyVan = string.Format(@"delete FROM loaisp WHERE maloai='{0}'",l.Maloai);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }

        public static List<LoaiSP_DTO> TimTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"Select * from loaisp where maloai like N'%{0}%'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiSP_DTO> lstLoaiSP = new List<LoaiSP_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiSP_DTO lsp = new LoaiSP_DTO();
                lsp.Id = int.Parse(dt.Rows[i]["id"].ToString());
                lsp.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lsp.Maloai = dt.Rows[i]["maloai"].ToString();

                lstLoaiSP.Add(lsp);
            }
            return lstLoaiSP;
        }

    }
}
