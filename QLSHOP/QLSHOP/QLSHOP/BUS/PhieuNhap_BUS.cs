using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class PhieuNhap_BUS
    {
        PhieuNhap_DAL PN = new PhieuNhap_DAL();

        public static List<PhieuNhap_DTO> LayPN()
        {
            return PhieuNhap_DAL.LayPN();
        }
        public static bool ThemPN(int ID, string TenSP, string SL, String Ngaynhap, string DonGia)
        {
            return PhieuNhap_DAL.ThemPN(ID, TenSP, SL, Ngaynhap, DonGia);
        }
        public static bool XoaPN(string ID)
        {
            return PhieuNhap_DAL.XoaPN(ID);
        }
        public static bool SuaPn(PhieuNhap_DTO pn)
        {
            return PhieuNhap_DAL.SuaPn(pn);
        }
    }
}
