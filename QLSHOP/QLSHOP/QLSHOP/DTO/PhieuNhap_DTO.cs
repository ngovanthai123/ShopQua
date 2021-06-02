using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PhieuNhap_DTO
    {
        private int id;
        private string tensp;
        private DateTime ngaynhap;
        private string dongia;
        private string soluong;
        
        

        

        public int Id { get => id; set => id = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        
        public string Soluong { get => soluong; set => soluong = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
 
    }
}
