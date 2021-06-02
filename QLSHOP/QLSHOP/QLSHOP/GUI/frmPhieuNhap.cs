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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
            LoadPN();
            LoadTB();
        }
        void LoadPN()
        {
            List<PhieuNhap_DTO> lstPN = PhieuNhap_BUS.LayPN();
            dgv_PhieuNhap.DataSource = lstPN;

            dgv_PhieuNhap.Columns["id"].HeaderText = "Mã phiếu nhập";
            dgv_PhieuNhap.Columns["tensp"].HeaderText = "Loại";
            dgv_PhieuNhap.Columns["dongia"].HeaderText = "Đơn giá nhập";
            dgv_PhieuNhap.Columns["ngaynhap"].HeaderText = "Ngày nhập";
            dgv_PhieuNhap.Columns["soluong"].HeaderText = "Số lượng";
        }

        void LoadTB()
        {
            txtPhieuNhap.DataBindings.Clear();
            txtPhieuNhap.DataBindings.Add("Text", dgv_PhieuNhap.DataSource, "id");

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", dgv_PhieuNhap.DataSource, "tensp");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgv_PhieuNhap.DataSource, "dongia");

            dtNgayNhap.DataBindings.Clear();
            dtNgayNhap.DataBindings.Add("Text", dgv_PhieuNhap.DataSource, "ngaynhap");

            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dgv_PhieuNhap.DataSource, "soluong");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PhieuNhap_BUS.ThemPN(0,txtTenSP.Text, txtSL.Text,  dtNgayNhap.Value.ToShortDateString(), txtDonGia.Text))
                MessageBox.Show("Thành công", "Thông báo");
            else
                MessageBox.Show("Không thêm được.");
            LoadPN();
            LoadTB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (PhieuNhap_BUS.XoaPN(txtPhieuNhap.Text))
                MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadPN();
            LoadTB();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuNhap_DTO pn = new PhieuNhap_DTO();
            pn.Id = int.Parse(txtPhieuNhap.Text);
            pn.Tensp = txtTenSP.Text;
            pn.Soluong = txtSL.Text;
            pn.Ngaynhap = DateTime.Parse(dtNgayNhap.Text);
            pn.Dongia = txtDonGia.Text;
            if (PhieuNhap_BUS.SuaPn(pn) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            MessageBox.Show("Sửa phiếu nhập thành công!", "Thông báo");
            LoadPN();
            LoadTB();
        }

        private void dgv_PhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_PhieuNhap.CurrentRow.Index < 0) return;
            dgv_ChiTietPhieuNhap.DataSource = null;
            dgv_ChiTietPhieuNhap.DataSource = SanPham_BUS.LaySanPhamTrongPhieuNhap(int.Parse($"{dgv_PhieuNhap.CurrentRow.Cells["ID"].Value}"));

           /* dgv_ChiTietPhieuNhap.Columns["Masp"].HeaderText = "Mã sản phẩm";
            dgv_ChiTietPhieuNhap.Columns["Tensp"].HeaderText = "Tên sản phẩm";
            dgv_ChiTietPhieuNhap.Columns["Soluong"].HeaderText = "Số lượng";
            dgv_ChiTietPhieuNhap.Columns["Dongiaban"].HeaderText = "Đơn giá bán";
            dgv_ChiTietPhieuNhap.Columns["Idloaisp"].HeaderText = "Mã loại sản phẩm";
            dgv_ChiTietPhieuNhap.Columns["Tenloai"].HeaderText = "Tên loại sản phẩm";
            dgv_ChiTietPhieuNhap.Columns["MaPn"].HeaderText = "Mã phiếu nhập";*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
