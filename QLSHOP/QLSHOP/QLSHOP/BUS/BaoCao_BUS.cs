using DAL;
using DTO;
using System.Collections.Generic;


namespace BUS
{
    public class BaoCao_BUS
    {
        public BaoCao_DTO BaoCaoTrongNam( int nam)
        {
            var baoCao = new BaoCao_DAL();
            return baoCao.BaoCaoTrongNam( nam);
        }
        public int BaoCaoNgay(int ngay, int thang, int nam)
        {
            var baoCao = new BaoCao_DAL();
            return baoCao.BaoCaoNgay(ngay, thang, nam);
        }
        public static List<SP> LaySP()
        {
            return BaoCao_DAL.LaySP();
        }
    }
}
