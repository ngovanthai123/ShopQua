using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        private string idHD;
        public frmHoaDon()
        {
            InitializeComponent();
            LoadHd();
            LoadCT();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {

        }
        void LoadHd()
        {

            List<HoaDon_DTO> lstHD = HoaDon_BUS.LayHD();
            dgHD.DataSource = lstHD;
         
            dgHD.Columns["ID"].HeaderText = "Mã hóa đơn";
            dgHD.Columns["IDkh"].HeaderText = "Mã khách hàng";
            dgHD.Columns["IDNhanVien"].HeaderText = "Mã nhân viên";
            dgHD.Columns["NgayLap"].HeaderText = "Ngày lập";
            dgHD.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }

        void LoadCT()
        {



        }


        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           

            
        }

        private void dgHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            if (idHD != null)
            {
                List<ChiTietHD_DTO> lstHD = CTHD_BUS.LayHD(idHD);
                dgChiTietHD.DataSource = lstHD;

                dgChiTietHD.Columns["IDSanPham"].HeaderText = "Mã sản phẩm";
                dgChiTietHD.Columns["soluong"].HeaderText = "Số lượng";
                dgChiTietHD.Columns["tensp"].HeaderText = "Tên sản phẩm";

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgChiTietHD_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgChiTietHD.CurrentRow;        
            txtMaSP.Text = row.Cells["IDSanPham"].Value.ToString();
            txtSL.Text = row.Cells["soluong"].Value.ToString();
            txtTenSP.Text = row.Cells["tensp"].Value.ToString();


        }

        private void dgHD_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dgHD.CurrentRow;
            idHD = row.Cells["ID"].Value.ToString();      
            // Chuyển giá trị lên form
            txtMaHD.Text = row.Cells["ID"].Value.ToString();
            txtMaKH.Text = row.Cells["IDkh"].Value.ToString();
            cbMaNV.Text = row.Cells["IDNhanVien"].Value.ToString();
            dtNgayLap.Text = row.Cells["NgayLap"].Value.ToString();
            txtTien.Text = row.Cells["ThanhTien"].Value.ToString();


           
        }
    }
}