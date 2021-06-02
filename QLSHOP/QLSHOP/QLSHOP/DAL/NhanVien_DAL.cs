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
    public class NhanVien_DAL

    {
        static SqlConnection con;
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "select *from nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = dt.Rows[i]["id"].ToString();
                nv.Hoten = dt.Rows[i]["hoten"].ToString();
                nv.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nv.Ngaysinh =dt.Rows[i]["ngaysinh"].ToString();
                nv.Cmnd = dt.Rows[i]["cmnd"].ToString();
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }



        public static bool ThemNhanVien(string ID, string HoTen, string GioiTinh,string NgaySinh,string SoCMND, string DiaChi, string SoDT,string tencv)
        {
            SqlConnection con;
            string sTruyVan =" INSERT INTO nhanvien VALUES(N'"+ID+"', N'"+HoTen+"', N'"+GioiTinh+"', '"+NgaySinh+"', '"+SoCMND+"', N'"+DiaChi+"', '"+SoDT+"', N'"+ tencv + "')";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNhanVien(string ID)
        {
            string sTruyVan = string.Format(@"delete FROM nhanvien WHERE ID=N'{0}'", ID);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        //sửa
        public static bool SuaNhanVien(string ID,string HoTen, string GioiTinh, string NgaySinh, string SoCMND, string DiaChi, string SoDT, string tencv)
        {
            SqlConnection con;
            string sTruyVan = "UPDATE nhanvien SET hoten=N'"+HoTen+"',gioitinh=N'"+GioiTinh+"',ngaysinh='"+NgaySinh+"',cmnd='"+SoCMND+"',diachi=N'"+DiaChi+"',sdt=N'"+SoDT+"'WHERE ID=N'"+ID+"'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<NhanVien_DTO> TimNhanVienTheoMa(string id)
        {
            SqlConnection con;
            string sTruyVan = string.Format(@"select * from nhanvien where id=N'{0}'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = dt.Rows[i]["id"].ToString();
                nv.Hoten = dt.Rows[i]["hoten"].ToString();
                nv.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nv.Ngaysinh = dt.Rows[i]["ngaysinh"].ToString();
                nv.Cmnd = dt.Rows[i]["cmnd"].ToString();
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }
        // tìm theo tên
        public static List<NhanVien_DTO> TimNhanVienTheoten(string ten)
        {
            SqlConnection con;
            string sTruyVan = string.Format(@"select * from nhanvien where hoten like N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = dt.Rows[i]["id"].ToString();
                nv.Hoten = dt.Rows[i]["hoten"].ToString();
                nv.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nv.Ngaysinh = dt.Rows[i]["ngaysinh"].ToString();
                nv.Cmnd = dt.Rows[i]["cmnd"].ToString();
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }

    }
    
}
