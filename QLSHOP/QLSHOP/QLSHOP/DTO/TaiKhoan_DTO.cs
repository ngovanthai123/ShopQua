using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class TaiKhoan_DTO
    {
        private string manv;
        private string matkhau;
        private int quyen;
        public string Manv { get => manv; set => manv = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Quyen { get => quyen; set => quyen = value; }
    }
}
