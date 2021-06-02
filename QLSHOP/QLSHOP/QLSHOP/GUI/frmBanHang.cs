using BUS;
using DTO;
using DTO.Common;
using DTO.SanPhamViewModel;
using GUI.Dialog;
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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            LoadDanhSachSanPham();
        }

        List<SanPham_DTO> _dsSanPham = new List<SanPham_DTO>();
        List<GioHang_DTO> _sanPhamTrongGio = new List<GioHang_DTO>();
      
        private void LoadDanhSachSanPham()
        {

            _dsSanPham = SanPham_BUS.LaySanPham();
            dgv_SanPham.DataSource = null;
            dgv_SanPham.DataSource = _dsSanPham;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgv_SanPham.CurrentRow.Index < 0) return;
            //sanPham => sản phẩm trong danh sách bán
            var sanpham = _dsSanPham.FirstOrDefault(x => x.Masp == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanpham.Soluong < 1)  return; //nếu hết hàng thì không cho thêm vào giỏ hàng nữa.
       

            //sanphamTG => Sản phẩm trong giỏ hàng
            var sanphamTG = _sanPhamTrongGio.FirstOrDefault(x => x.MaSP == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanphamTG != null)
            {
                sanphamTG.SoLuongMua++;
                sanphamTG.TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}") * sanphamTG.SoLuongMua;
          
                sanpham.Soluong--;
            }
            else
            {
                var sp = new GioHang_DTO()
                {
                    MaSP = $"{dgv_SanPham.CurrentRow.Cells["Masp"].Value}",
                    TenSP = $"{dgv_SanPham.CurrentRow.Cells["TenSP"].Value}",
                    DonGiaBan =int.Parse( $"{dgv_SanPham.CurrentRow.Cells["DonGiaBan"].Value}"),
                    SoLuongMua = 1,
                    TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}"),
                    //ThanhTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["ThanhTien"].Value}")
                };
                ;
                sanpham.Soluong--;
                _sanPhamTrongGio.Add(sp);
            }
            //Cập nhật giỏ hàng
            dgv_GioHang.DataSource = null;
            dgv_GioHang.DataSource = _sanPhamTrongGio;
            //Cập nhật danh sách bán
            dgv_SanPham.DataSource = null;
            dgv_SanPham.DataSource = _dsSanPham;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var kh = new KhachHangDialog();
            if (kh.ShowDialog() != DialogResult.OK) return;
            var thanhToan = new ThanhToan_BUS();
            var kq = thanhToan.ThanhToan(_sanPhamTrongGio, kh._MaKH, ThongTin.NhanVien.Manv);
            if (kq)
                MessageBox.Show("Thanh toán thành công");
            else
                MessageBox.Show("Thanh toán thất bại");


           
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void dgv_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bthThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_GioHang.CurrentRow.Index < 0) return;
            //sanPham => sản phẩm trong danh sách bán
            var sanpham = _dsSanPham.FirstOrDefault(x => x.Masp == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanpham.Soluong < 1) return; //nếu hết hàng thì không cho thêm vào giỏ hàng nữa.


            //sanphamTG => Sản phẩm trong giỏ hàng
            var sanphamTG = _sanPhamTrongGio.FirstOrDefault(x => x.MaSP == $"{dgv_SanPham.CurrentRow.Cells["maSP"].Value}");
            if (sanphamTG != null)
            {
                sanphamTG.SoLuongMua--;
                sanphamTG.TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}") * sanphamTG.SoLuongMua;

                sanpham.Soluong++;
            }
            else
            {
                var sp = new GioHang_DTO()
                {
                    MaSP = $"{dgv_SanPham.CurrentRow.Cells["Masp"].Value}",
                    TenSP = $"{dgv_SanPham.CurrentRow.Cells["TenSP"].Value}",
                    SoLuongMua = 1,
                    TongTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["Dongiaban"].Value}"),
                    //ThanhTien = int.Parse($"{dgv_SanPham.CurrentRow.Cells["ThanhTien"].Value}")
                };
                ;
                sanpham.Soluong++;
                _sanPhamTrongGio.Remove(sp);
                
            }
            //Cập nhật lại giỏ hàng
            dgv_GioHang.DataSource = null;
            dgv_GioHang.DataSource = _sanPhamTrongGio;
            //Cập nhật lại danh sách bán
            dgv_SanPham.DataSource = null;
            dgv_SanPham.DataSource = _dsSanPham;

        }

        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("XUÂN QUỲNH SHOP ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(280, 50));
            e.Graphics.DrawString(" 88 Nguyễn Trãi, Phường Mỹ Long, Thành phố Long Xuyên, An Giang ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(125, 100));


            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));

            e.Graphics.DrawString("Tên khách hàng: " + txtTen.Text.Trim(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 190));

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));
            e.Graphics.DrawString("Tên mặt hàng ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 255));
            e.Graphics.DrawString("Số lượng ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(380, 255));
           e.Graphics.DrawString("Đơn giá bán ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 255));
            e.Graphics.DrawString("Thành tiền ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));
            int yPos = 295;
            foreach(var i in _sanPhamTrongGio)
            {
                e.Graphics.DrawString(i.TenSP, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.SoLuongMua.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                e.Graphics.DrawString(i.DonGiaBan.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                e.Graphics.DrawString(i.TongTien.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("Nhân viên lập: " + txtNhanVien.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, yPos + 30));

            e.Graphics.DrawString(" Vui lòng giữ lại hóa đơn để xác nhận trong trường hợp đổi hàng hóa ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(125, yPos+60));

        }

        private void btnBILL_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

