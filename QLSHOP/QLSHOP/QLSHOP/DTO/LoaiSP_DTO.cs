using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSP_DTO
    {
        private int id;
        private string tenloai;
        private string maloai;

        public int Id { get => id; set => id = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Maloai { get => maloai; set => maloai = value; }
    }
}
