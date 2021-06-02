using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BaoCao_DAL
    {
        static SqlConnection con;
        public BaoCao_DTO BaoCaoTrongNam(int nam)
        {
            string sTruyVan = string.Format(@"SELECT SUM(ThanhTien) AS DOANHTHU FROM hoadon WHERE year(ngaylap) = 2021");

            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return new BaoCao_DTO() { DoanhThu = 0 };
            }
            var DoanhThu = 0.0;

            foreach (var item in dt.Rows)
            {

                DoanhThu += int.Parse($"{((DataRow)item)["DoanhThu"]}");
            }
            DataProvider.DongKetNoi(con);
            return new BaoCao_DTO() { DoanhThu = DoanhThu };



        }

        
        public static List<SP> LaySP()
        {
            string sTruyVan = string.Format(@"SELECT S.masp, tensp
                                                            FROM sanpham S
                                 WHERE NOT EXISTS(SELECT * FROM sanpham  
                                    INNER JOIN chitiethoadon C ON S.masp = C.IDSanPham AND S.masp = S.masp)");
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SP> lstSP = new List<SP>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SP sp = new SP
                {
                    masp = dt.Rows[i]["masp"].ToString(),
                    tensp = dt.Rows[i]["tensp"].ToString()
                };

                lstSP.Add(sp);
            }
            return lstSP;            



        }
        public int BaoCaoNgay(int ngay,int thang, int nam)
        {
            string sTruyVan = string.Format($@"SELECT hd.ngaylap, SUM(ThanhTien) AS DOANHTHU
                FROM hoadon as hd
WHERE hd.ngaylap = '{nam}-{thang}-{ngay}'
GROUP BY ngaylap");

            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            var doanhThu = 0;

            foreach (var item in dt.Rows)
            {

                doanhThu += int.Parse($"{((DataRow)item)["DoanhThu"]}");
            }
            DataProvider.DongKetNoi(con);
            return doanhThu;



        }

    }
}