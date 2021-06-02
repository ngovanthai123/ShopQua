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
    public partial class frmLoaiSP : Form
    {
        public frmLoaiSP()
        {
            InitializeComponent();
           
            LoadData();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            
            List<LoaiSP_DTO> lstLoaiSP = LoaiSP_BUS.LayLoai();
            dgLoaiSP.DataSource = lstLoaiSP;

            dgLoaiSP.Columns["Id"].HeaderText = "Số thứ tự";
            dgLoaiSP.Columns["tenloai"].HeaderText = "Tên loại";
            dgLoaiSP.Columns["maloai"].HeaderText = "Mã loại";

        }

        private void dgLoaiSP_Click(object sender, EventArgs e)
        {

            DataGridViewRow r = new DataGridViewRow();
            r = dgLoaiSP.CurrentRow;
            txtLoai.Text = r.Cells["maloai"].Value.ToString();
            txtLoaiSP.Text = r.Cells["tenloai"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtLoai.Text == "" || txtLoaiSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtLoai.Text.Length > 5)
            {
                MessageBox.Show("Mã loại sản phẩm tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (KH_BUS.TimTheoID(txtLoai.Text) != null)
            {
                MessageBox.Show("Mã loại sản phẩm đã tồn tại!");
                return;
            }

            LoaiSP_DTO l = new LoaiSP_DTO();
            l.Maloai = txtLoai.Text;
            l.Tenloai = txtLoaiSP.Text;
            if (LoaiSP_BUS.ThemLoai(l) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;

            }
            LoadData();
            MessageBox.Show("Đã thêm loại mới.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiSP_DTO l = new LoaiSP_DTO();
            l.Maloai = txtLoai.Text;
            l.Tenloai = txtLoaiSP.Text;
            if (LoaiSP_BUS.SuaLoai(l) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;

            }
            LoadData();
            MessageBox.Show("Sửa thành công.");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiSP_DTO l = new LoaiSP_DTO();
            l.Maloai = txtLoai.Text;
            l.Tenloai = txtLoaiSP.Text;
            if (LoaiSP_BUS.XoaLoai(l) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;

            }
            LoadData();
            MessageBox.Show("Xóa thành công.");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
