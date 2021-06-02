using System.Collections.Generic;
using DAL;
using DTO;
namespace BUS
{

    public  class LoaiSP_BUS
    {
        public static List<LoaiSP_DTO> LayLoai()
        {
            return LoaiSP_DAL.LayLoai();
        }
        public static bool ThemLoai(LoaiSP_DTO l)
        {
            return LoaiSP_DAL.ThemLoai(l);
        }
        public static bool SuaLoai(LoaiSP_DTO l)
        {
            return LoaiSP_DAL.SuaLoai(l);
        }
        public static bool XoaLoai(LoaiSP_DTO l)
        {
            return LoaiSP_DAL.XoaLoai(l);
        }

        public static List<LoaiSP_DTO> TimTheoMa(string ma)
        {
            return LoaiSP_DAL.TimTheoMa(ma);
        }
    }
}
