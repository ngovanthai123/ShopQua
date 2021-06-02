using DTO.SanPhamViewModel;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ThanhToan_DAL
    {
        //private SqlConnection con;

        public bool ThanhToan(List<GioHang_DTO> gh, string maKhachHang, string maNhanVien)
        {

            var maHD = Guid.NewGuid();

            var thanhTien = 0;
            foreach (var item in gh)
            {
                thanhTien += item.TongTien;
            }
            SqlConnection con = DataProvider.MoKetNoi();
            //insert into hoadon values ('9BC723CF-7146-40A4-9A4B-20A34FBCD6D0',N'KH061',N'NV02',GETDATE(),0);
           
            string sTruyVan = $"insert into hoadon values('{maHD}','{maKhachHang}','{maNhanVien}','{DateTime.Now.ToString("yyyy-MM-dd")}',{thanhTien})";
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            if (!kq) return false;

            foreach (var item in gh)
            {
                kq = DataProvider.TruyVanKhongLayDuLieu($"insert into chitiethoadon values('{maHD}', '{item.MaSP}', {item.SoLuongMua})", con);
                if (!kq)
                    return false;

                kq = DataProvider.TruyVanKhongLayDuLieu($"UPDATE sanpham SET soLuong = soluong - {item.SoLuongMua}", con);
                if (!kq)
                    return false;
            }

            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
