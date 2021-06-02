using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace BUS
{
   public class TaiKhoan_BUS
    {
        public static List<TaiKhoan_DTO> LayTaiKhoan()
        {
            return TaiKhoan_DAL.LayTaiKhoan();
        }
        public static TaiKhoan_DTO LayTaiKhoan(string manv, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAL.LayTaiKhoan(manv, matkhau);

        }
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool ThemTaiKhoan(string MaNV, string MatKhau, string quyen)
        {
            return TaiKhoan_DAL.ThemTaiKhoan(MaNV, MatKhau,quyen);
        }
        public static bool SuaTaiKhoan(string idnhanvien, string matkhau, int quyen)
        {
            return TaiKhoan_DAL.SuaTaiKhoan(idnhanvien, matkhau,quyen);
        }
        public static bool XoaTaikhoan(string idnhanvien)
        {
            return TaiKhoan_DAL.XoaTaiKhoan(idnhanvien);
        }

        //TÌM NCC THEO MÃ ID
        public static List<TaiKhoan_DTO> TimTheoID(string id)
        {
            return TaiKhoan_DAL.TimTheoID(id);
        }
    }
}
