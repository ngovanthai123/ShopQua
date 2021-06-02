using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KH_BUS
    {
        public static List<KhachHang_DTO> LayKH()
        {
            return KhachHang_DAL.LayKH();
        }
        public static bool ThemKH(string id, string hoten, string gioitinh, string sdt)
        {
            return KhachHang_DAL.ThemKH(id,hoten,gioitinh,sdt);
        }
        public static bool XoaKhachHang(string ID)
        {
            return KhachHang_DAL.XoaKhachHang(ID);
        }

        public static bool SuaKH(string id, string hoten, string gioitinh, string sdt)
        {
            return KhachHang_DAL.SuaKH(id, hoten, gioitinh, sdt);
        }

        //TÌM  THEO TÊN
        public static List<KhachHang_DTO> TimTheoTen(string ten)
        {
            return KhachHang_DAL.TimKHTheoTen(ten);
        }
        //TÌM  THEO MÃ ID
        public static List<KhachHang_DTO> TimTheoID(string id)
        {
            return KhachHang_DAL.TimTheoID(id);
        }
    }
}
