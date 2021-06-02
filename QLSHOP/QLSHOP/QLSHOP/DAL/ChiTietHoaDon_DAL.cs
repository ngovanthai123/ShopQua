using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ChiTietHoaDon_DAL
    {
        private static SqlConnection con;

        public static List<ChiTietHD_DTO> LayHD(string ID)//id này là id của ai của bảng nào
        {
            MessageBox.Show(ID);
            string sTruyVan = "select ct.soluong, sp.tensp, ct.IDSanPham from (chitiethoadon ct inner join sanpham sp on sp.masp = ct.IDSanPham) inner join hoadon h on h.ID = ct.IDHoaDon where h.ID = '" + ID.ToUpper() + "'";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietHD_DTO> lstCT = new List<ChiTietHD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHD_DTO ct = new ChiTietHD_DTO();
                //ct.IDCTHD = int.Parse(dt.Rows[i]["IDCTHD"].ToString());
                ct.IDSanPham = dt.Rows[i]["IDSanPham"].ToString();
                ct.soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                ct.tensp= dt.Rows[i]["tensp"].ToString();
                lstCT.Add(ct);
            }
            return lstCT;
        }
    }
}
