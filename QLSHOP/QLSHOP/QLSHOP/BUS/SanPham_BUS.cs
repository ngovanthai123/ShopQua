using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
   public class SanPham_BUS
    {
        public static List<SanPham_DTO> LaySanPham()
        {
            return SanPham_DAL.LaySanPham();
        }

        public static List<SanPham_DTO> LaySanPhamTrongPhieuNhap(int maPhieuNhap)
        {
            return SanPham_DAL.LaySanPhamTrongPhieuNhap(maPhieuNhap);
        }

        public static bool ThemSP(int id, string masp, string tensp, int soluong, int dongiaban, string idloaisp)
        {
            return SanPham_DAL.ThemSP(id,masp,tensp,soluong,dongiaban,idloaisp);
        }
       
        public static bool SuaSanPham(int id, string masp, string tensp, int soluong, int dongiaban, string idloaisp)
        {
            return SanPham_DAL.SuaSanPham(id, masp, tensp, soluong, dongiaban, idloaisp);
        }
        public static bool XoaSanPham(string MaSP)
        {
            return SanPham_DAL.XoaSanPham(MaSP);
        }
        public static List<SanPham_DTO> TimSPTheoTen(string ten)
        {
            return SanPham_DAL.TimSPTheoTen(ten);
        }

        public static List<SanPham_DTO> TimSPTheoMa(string ma)
        {
            return SanPham_DAL.TimSPTheoMa(ma);
        }
    }
}
