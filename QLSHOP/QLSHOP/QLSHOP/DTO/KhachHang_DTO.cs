using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHang_DTO
    {
        private string id;
        private string hoten;
        private string gioitinh;
        private string sdt;

        public string Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
