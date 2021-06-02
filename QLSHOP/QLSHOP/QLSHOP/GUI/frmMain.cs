using BUS;
using DTO;
using DTO.Common;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool bDangNhap;
        public TaiKhoan_DTO TaiKhoan;
        frmDangNhap fDN;
        

        void ChuaDangNhap()
        {
            tsbLogin.Enabled = !bDangNhap;
            tsbOut.Enabled = bDangNhap;
            tsbKH.Enabled = bDangNhap;
            tsbSP.Enabled = bDangNhap;
            tsbNhanVien.Enabled = bDangNhap;
            tsbTK.Enabled = bDangNhap;
            tsbHD.Enabled = bDangNhap;
            tsbBanHang.Enabled = bDangNhap;
            tsbPN.Enabled = bDangNhap;
            tsbLoaiSP.Enabled = bDangNhap;
            tsbTKE.Enabled= bDangNhap;
            tsbtrogiup.Enabled = bDangNhap;
            tsbIn.Enabled = bDangNhap;
            tsbSaoLuu.Enabled = bDangNhap;
            tsbPhucHoi.Enabled = bDangNhap;
            tsbThongTin.Enabled = bDangNhap;

        }
        private void HienThiMenu()
        {

            ChuaDangNhap();
            if (bDangNhap == true)
            {

                int iQuyen;
                if (TaiKhoan == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(TaiKhoan.Quyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1:
                        tsbTKE.Enabled = true;
                        tsbKH.Enabled = true;
                        tsbOut.Enabled = true;
                        tsbLogin.Enabled = false;
                        tsbSP.Enabled = true;
                        tsbNhanVien.Enabled = true;
                        tsbTK.Enabled = true;
                        tsbHD.Enabled = true;
                        tsbBanHang.Enabled = true;
                        tsbPN.Enabled = true;
                        tsbLoaiSP.Enabled = true;
                        tsbtrogiup.Enabled = true;
                        tsbIn.Enabled = true;
                        tsbSaoLuu.Enabled = true;
                        tsbPhucHoi.Enabled = true;
                        tsbThongTin.Enabled = true;
                        lbl.Text = "Quản lý ";



                        break;
                    case 0:
                        tsbKH.Enabled = true;
                        tsbOut.Enabled = true;
                        tsbLogin.Enabled = false;
                        tsbSP.Enabled = true;
                        tsbNhanVien.Enabled = false;
                        tsbTK.Enabled = false;
                        tsbHD.Enabled = true;
                        tsbBanHang.Enabled = true;
                        tsbPN.Enabled = false;
                        tsbLoaiSP.Enabled = true;
                        tsbTKE.Enabled = false;
                        tsbtrogiup.Enabled = true;
                        tsbIn.Enabled = false;
                        tsbSaoLuu.Enabled = false;
                        tsbPhucHoi.Enabled = false;
                        tsbThongTin.Enabled = true;                       
                        lbl.Text = "Nhân Viên";


                        break;
                    default:
                        break;
                }
            }
            else
            {

                return;
            }
        }
        private void tsbLogin_Click(object sender, EventArgs e)
        {
            fDN = new frmDangNhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                string Manv = fDN.txtMaNV.Text;
                string MatKhau = fDN.txtMK.Text;
                TaiKhoan = new TaiKhoan_DTO();
                TaiKhoan = TaiKhoan_BUS.LayTaiKhoan(Manv, MatKhau);
                ThongTin.NhanVien = TaiKhoan;
                if (TaiKhoan != null)
                {
                    bDangNhap = true;
                    MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công. Phiền bạn xác nhận OK để vào hệ thống!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    bDangNhap = false;

                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Bạn vui lòng nhập lại tài khoản và mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }


                HienThiMenu();

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu();
        }

        private void tsbKH_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void TsbSP_Click(object sender, EventArgs e)
        {
            SanPham f = new SanPham();
            f.ShowDialog();
        }

        private void tsbNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void TsbTK_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            
            f.ShowDialog();
        }

        private void tsbLoaiSP_Click(object sender, EventArgs e)
        {
            frmLoaiSP f = new frmLoaiSP();
            f.ShowDialog();
        }

        private void tsbPN_Click(object sender, EventArgs e)
        {

            frmPhieuNhap f = new frmPhieuNhap();
            f.ShowDialog();
        }

        private void tsbOut_Click(object sender, EventArgs e)
        {
            tsbLogin.Enabled = !bDangNhap;
            tsbOut.Enabled = bDangNhap;
            tsbKH.Enabled = !bDangNhap;
            tsbSP.Enabled = !bDangNhap;
            tsbNhanVien.Enabled = !bDangNhap;
            tsbTK.Enabled = !bDangNhap;
            tsbHD.Enabled = !bDangNhap;
            tsbBanHang.Enabled = !bDangNhap;
            tsbPN.Enabled = !bDangNhap;
            tsbLoaiSP.Enabled = !bDangNhap;
            tsbTKE.Enabled = !bDangNhap;

            foreach (Form DX in MdiChildren)
            {
                DX.Close();
            }
            var fDN = new frmDangNhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                string Manv = fDN.txtMaNV.Text;
                string MatKhau = fDN.txtMK.Text;
                TaiKhoan = new TaiKhoan_DTO();
                TaiKhoan = TaiKhoan_BUS.LayTaiKhoan(Manv, MatKhau);
                if (TaiKhoan != null)
                {
                    bDangNhap = true;
                    MessageBox.Show("Đăng nhập thành công. Mời bạn nhấn OK để xác nhận!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    bDangNhap = false;

                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Bạn vui lòng nhập lại tài khoản và mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }


                HienThiMenu();
               

            }
        }

        private void TsbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbTke_Click(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            f.ShowDialog();
        }

        private void tsbHD_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.ShowDialog();
           

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            frmBaocao f = new frmBaocao();
            f.ShowDialog();


        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbtrogiup_Click(object sender, EventArgs e)
        {
            frmHuongDan f = new frmHuongDan();
            f.ShowDialog(); 
        }

        private void tsbIn_Click(object sender, EventArgs e)
        {
            frmbcNhanVien f = new frmbcNhanVien();
            f.ShowDialog();
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
           phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ThongTinShop f = new ThongTinShop();
            f.ShowDialog();
        }
    }
 }