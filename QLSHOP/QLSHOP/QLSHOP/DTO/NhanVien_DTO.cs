using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{   
    public class NhanVien_DTO
    {
        private string id;
        private string hoten;
        private string gioitinh;
        private string ngaysinh;
        private string cmnd;
        private string diachi;
        private string sdt;
        private string tencv;
        

        public string Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }  
        public string Tencv { get => tencv; set => tencv = value; }
        
    }

}

