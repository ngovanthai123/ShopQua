using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class CTHD_BUS
    {
        public static List<ChiTietHD_DTO> LayHD(string ID)
        {
            return ChiTietHoaDon_DAL.LayHD(ID);
        }
    }
}
