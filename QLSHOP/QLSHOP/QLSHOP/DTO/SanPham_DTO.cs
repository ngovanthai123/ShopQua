using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        private string masp;
        private string tensp;

        private int soluong;
        private int dongiaban;
        private string tenloai;
        private string idloaisp;
        private int maPn;
       
     
       
        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
       
       
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongiaban { get => dongiaban; set => dongiaban = value; }
        public string Idloaisp { get => idloaisp; set => idloaisp = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public int MaPn { get => maPn; set => maPn = value; }

    }
}
