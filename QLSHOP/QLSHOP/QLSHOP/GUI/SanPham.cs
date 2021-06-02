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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            LoadSanPham();
            LoadTB();
        }

        void LoadSanPham()
        {
            List<SanPham_DTO> lstSanPham = SanPham_BUS.LaySanPham();
            dgDSSP.DataSource = lstSanPham;

            List<LoaiSP_DTO> lstLoaiSP = LoaiSP_BUS.LayLoai();
            cbLoaiSP.DataSource = lstLoaiSP;
            cbLoaiSP.DisplayMember = "tenloai";
            cbLoaiSP.ValueMember = "maloai";

            dgDSSP.Columns["Masp"].HeaderText = "Mã sản phẩm";
            dgDSSP.Columns["Tensp"].HeaderText = "Tên sản phẩm";
            dgDSSP.Columns["Dongiaban"].HeaderText = "Đơn giá bán";
            dgDSSP.Columns["Soluong"].HeaderText = "Số lượng";
            dgDSSP.Columns["idloaisp"].HeaderText = "Mã loại sản phẩm";
            dgDSSP.Columns["Tenloai"].HeaderText = "Tên loại";
            dgDSSP.Columns["MaPn"].HeaderText = "Mã phiếu nhập";
        }

        void LoadTB()
        {
            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", dgDSSP.DataSource, "Masp");

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", dgDSSP.DataSource, "Tensp");

            txtSL.DataBindings.Clear();
            txtSL.DataBindings.Add("Text", dgDSSP.DataSource, "Soluong");

            txtPN.DataBindings.Clear();
            txtPN.DataBindings.Add("Text", dgDSSP.DataSource, "MaPn");

            txtDGBan.DataBindings.Clear();
            txtDGBan.DataBindings.Add("Text", dgDSSP.DataSource, "Dongiaban");

            cbLoaiSP.DataBindings.Clear();
            cbLoaiSP.DataBindings.Add("Text", dgDSSP.DataSource, "tenloai");
        }

        private void SanPham_Load(object sender, EventArgs e)
        {

        }

        private void dgDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewRow row = dgDSSP.CurrentRow;

            // Chuyển giá trị lên form

            txtMaSP.Text = row.Cells["masp"].Value.ToString();
            txtTenSP.Text = row.Cells["tensp"].Value.ToString();
            txtSL.Text = row.Cells["soluong"].Value.ToString();

            txtDGBan.Text = row.Cells["dongiaban"].Value.ToString();
            cbLoaiSP.Text = row.Cells["tenloai"].Value.ToString();

            txtPN.Text = row.Cells["maPn"].Value.ToString();*/
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtSL.Text == "" || txtDGBan.Text == "" || txtPN.Text=="" ||cbLoaiSP.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }// Kiểm tra mã  có độ dài chuỗi hợp lệ hay không
            if (txtMaSP.Text.Length > 6)
            {
                MessageBox.Show("Mã sản phẩm tối đa 6 ký tự!");
                return;
            }
            // Kiểm tra mã  có bị trùng không
            if (SanPham_BUS.TimSPTheoMa(txtMaSP.Text) != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }
            if (SanPham_BUS.ThemSP(int.Parse(txtPN.Text), txtMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtDGBan.Text), cbLoaiSP.SelectedValue.ToString()))
                MessageBox.Show("Thành công", "Thông báo");
            else
                MessageBox.Show("Không thêm được.");
            LoadSanPham();
            LoadTB();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (SanPham_BUS.SuaSanPham(int.Parse(txtPN.Text), txtMaSP.Text, txtTenSP.Text, int.Parse(txtSL.Text), int.Parse(txtDGBan.Text), cbLoaiSP.SelectedValue.ToString()))
                MessageBox.Show("Thành công", "Thông báo");
            else
                MessageBox.Show("Không thêm được.");

            LoadSanPham();
            LoadTB();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (SanPham_BUS.XoaSanPham(txtMaSP.Text))
                MessageBox.Show("Xóa thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadSanPham ();
            LoadTB();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            string ten = textBox1.Text;
            List<SanPham_DTO> lstsp = SanPham_BUS.TimSPTheoTen(ten);
            if (lstsp == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSSP.DataSource = lstsp;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadTB();
            textBox1.Clear();
            this.Focus();
        }

        //private void btnThemSP_Click(object sender, EventArgs e)
        //{
        //    if (SanPham_BUS.ThemSP(txtMaSP.Text, txtTenSP.Text, txtSL.Text, txtDGBan.Text, cbLoaiSP.SelectedValue.ToString()))
        //        MessageBox.Show("Thành công", "Thông báo");


        //    else

        //        MessageBox.Show("Không thêm được.");

        //    LoadSanPham();
        //    LoadTB();

        //}

        //private void btnSuaSP_Click(object sender, EventArgs e)
        //{
        //    if (SanPham_BUS.SuaSP(txtMaSP.Text, txtTenSP.Text, txtSL.Text, txtDGBan.Text, cbLoaiSP.SelectedValue.ToString()))
        //    {
        //        MessageBox.Show("Thành công", "Thông báo");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Không Sửa được.");
        //    }
        //    LoadSanPham();
        //    LoadTB();
        //}
    }
    }

