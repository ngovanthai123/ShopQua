using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_DAL
    {
        static SqlConnection con;
        public static List<HoaDon_DTO> LayHD()
        {
            string sTruyVan = string.Format(@"select hd.ID,hd.IDNhanVien, hd.IDkh, hd.ThanhTien ,hd.ngaylap
                                                from hoadon as hd
                                                inner join chitiethoadon as ct on hd.ID= ct.IDHoaDon");
            con = DataProvider.MoKetNoi();
          
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHD = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.ID = new Guid(dt.Rows[i]["ID"].ToString());
                hd.IDkh = dt.Rows[i]["IDkh"].ToString();
                hd.IDNhanVien = dt.Rows[i]["IDNhanVien"].ToString();
                hd.NgayLap = DateTime.Parse(dt.Rows[i]["NgayLap"].ToString());
                hd.ThanhTien = int.Parse(dt.Rows[i]["ThanhTien"].ToString());
                lstHD.Add(hd);
            }
            return lstHD;
          
        }
    }
}
