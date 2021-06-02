using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TaiKhoan_DAL
    {
        static SqlConnection con;
        public static List<TaiKhoan_DTO> LayTaiKhoan()
        {
            string sTruyVan = "select n.*, c.tencv from nguoidung n, nhanvien c where n.IDnhanvien=c.ID";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lsttk = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.Manv = dt.Rows[i]["IDnhanvien"].ToString();
                tk.Matkhau = dt.Rows[i]["matkhau"].ToString();
                
                tk.Quyen = Int16.Parse(dt.Rows[i]["quyen"].ToString());
                lsttk.Add(tk);
            }
            return lsttk;
        }
        public static TaiKhoan_DTO LayTaiKhoan(string manv, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where IDnhanvien=N'{0}' and matkhau=N'{1}'", manv, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Manv = dt.Rows[0]["IDnhanvien"].ToString();
            tk.Matkhau = dt.Rows[0]["matkhau"].ToString();

            tk.Quyen = Int16.Parse(dt.Rows[0]["quyen"].ToString());
            DataProvider.DongKetNoi(con);
            return tk;
        }
        public static bool ThemTaiKhoan(string MaNV, string MatKhau, string quyen)
        {
            string sTruyVan = string.Format(@"insert into nguoidung values(N'{0}',N'{1}','{2}')",MaNV, MatKhau, quyen);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool SuaTaiKhoan(string idnhanvien, string matkhau, int quyen)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau=N'{1}',quyen='{2}' where IDnhanvien=N'{0}'", idnhanvien, matkhau,quyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool XoaTaiKhoan(string idnhanvien)
        {
            string sTruyVan = string.Format(@"delete from nguoidung where IDnhanvien=N'{0}'", idnhanvien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }


        //TÌM NCC THEO Mã
        public static List<TaiKhoan_DTO> TimTheoID(string id)
        {
            string sTruyVan = string.Format(@"Select * from nguoidung where IDnhanvien like N'%{0}%'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lsttk = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.Manv = dt.Rows[i]["IDnhanvien"].ToString();
                tk.Matkhau = dt.Rows[i]["matkhau"].ToString();
                tk.Quyen = Int16.Parse(dt.Rows[i]["quyen"].ToString());
                lsttk.Add(tk);
            }
            return lsttk;

        }
    }
}
