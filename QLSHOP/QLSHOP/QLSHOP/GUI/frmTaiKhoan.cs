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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            loadtk();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
           
        }

        private void dgTK_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgTK.Rows[dgTK.SelectedCells[0].RowIndex];
            txtID.Text = dr.Cells[0].Value.ToString();
            txtMK.Text = dr.Cells[1].Value.ToString();
            txtQuyen.Text = dr.Cells["quyen"].Value.ToString();
           
        }
        void loadtk()
        {
            List<TaiKhoan_DTO> lsttk = TaiKhoan_BUS.LayTaiKhoan();
            dgTK.DataSource = lsttk;
            /*List<NhanVien_DTO> lstNhanvien = NhanVien_BUS.LayNhanVien();
            cbQuyen.DataSource = lstNhanvien;
            cbQuyen.DisplayMember = "tencv";
            cbQuyen.ValueMember = "";*/



            dgTK.Columns["Manv"].HeaderText = "Tên đăng nhập ";

            dgTK.Columns["Matkhau"].HeaderText = "Mật khẩu";

            dgTK.Columns["quyen"].HeaderText = "Quyền";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtMK.Text == "" || txtQuyen.Text == "")
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin.","Thông báo");
                return;
            }
            if (txtID.TextLength > 5)
            {
                MessageBox.Show("Mã nhân viên có chiều dài không quá 5 ký tự.", "Thông báo");
                return;
            }

            // Kiểm tra mã  có bị trùng không
            if (TaiKhoan_BUS.TimTheoID(txtID.Text) != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo");
                return;
            }
           

            if (TaiKhoan_BUS.ThemTaiKhoan(txtID.Text, txtMK.Text,txtQuyen.Text))
                MessageBox.Show("Thêm thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            loadtk();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (TaiKhoan_BUS.SuaTaiKhoan(txtID.Text, txtMK.Text,int.Parse(txtQuyen.Text)))
                MessageBox.Show("Sửa thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            loadtk();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (TaiKhoan_BUS.XoaTaikhoan(txtID.Text))
                MessageBox.Show("Xóa thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            loadtk();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

