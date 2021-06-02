using DAL;
using DTO.SanPhamViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThanhToan_BUS
    {
        public bool ThanhToan(List<GioHang_DTO> gh, string maKhachHang, string maNhanVien)
        {
            var thanhToan = new ThanhToan_DAL();
            return thanhToan.ThanhToan(gh, maKhachHang, maNhanVien);
        }

    }
}
