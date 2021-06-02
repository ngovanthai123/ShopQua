using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDon_DTO
    {
        public Guid ID { get; set; }
        public string IDkh { get; set; }
        public string IDNhanVien { get; set; }
        public int ThanhTien { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
