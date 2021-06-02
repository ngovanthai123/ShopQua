using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
   public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAL.LayNhanVien();
        }
        public static bool ThemNhanVien(string ID, string HoTen, string GioiTinh, string NgaySinh, string SoCMND, string DiaChi, string SoDT,string tencv)
        {
            return NhanVien_DAL.ThemNhanVien(ID, HoTen, GioiTinh, NgaySinh, SoCMND, DiaChi, SoDT, tencv);
        }

        public static bool SuaNhanVien(string ID, string HoTen, string GioiTinh, string NgaySinh, string SoCMND, string DiaChi, string SoDT, string tencv)
        {
            return NhanVien_DAL.SuaNhanVien(ID,HoTen, GioiTinh, NgaySinh, SoCMND, DiaChi, SoDT, tencv);
        }

        public static List<NhanVien_DTO> TimNhanVienTheoMa(string id)
        {
            return NhanVien_DAL.TimNhanVienTheoMa(id);
        }

        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAL.TimNhanVienTheoten(ten);
        }

        public static bool XoaNhanVien(string id)
        {
            return NhanVien_DAL.XoaNhanVien(id);
        }

       
    }
}
