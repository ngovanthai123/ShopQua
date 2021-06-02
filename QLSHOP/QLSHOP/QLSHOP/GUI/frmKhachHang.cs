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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            LoadKH();
        }
        void LoadKH()
        {
            List<KhachHang_DTO> lstKH = KH_BUS.LayKH();
            dgKH.DataSource = lstKH;


            dgKH.Columns["Id"].HeaderText = "Mã khách hàng";

            dgKH.Columns["Hoten"].HeaderText = "Họ tên";
            dgKH.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgKH.Columns["Sdt"].HeaderText = "Số điện thoại";

            


        }

        private void dgKH_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgKH.CurrentRow;

            // Chuyển giá trị lên form

            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtHoten.Text = row.Cells[1].Value.ToString();
           

            if (row.Cells["gioitinh"].Value.ToString() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;

            txtSDT.Text = row.Cells[3].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaKH.Text == "" || txtHoten.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaKH.Text.Length > 5)
            {
                MessageBox.Show("Mã khách hàng tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (KH_BUS.TimTheoID(txtMaKH.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
                return;
            }

            string gioitinh;
            if (rdNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            if (KH_BUS.ThemKH(txtMaKH.Text,txtHoten.Text, gioitinh, txtSDT.Text))
                MessageBox.Show("Thành công", "Thông báo");


            else

                MessageBox.Show("Không thêm được.");

            LoadKH();



        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KH_BUS.XoaKhachHang(txtMaKH.Text))
                MessageBox.Show("Xóa thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            if (KH_BUS.SuaKH(txtMaKH.Text, txtHoten.Text, gioitinh, txtSDT.Text))
                MessageBox.Show("Thành công", "Thông báo");


            else

                MessageBox.Show("Không sửa được.");

            LoadKH();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    KhachHang_DTO kh = new KhachHang_DTO();
        //    kh.Id = cbQuyen.Text;
        //    kh.Hoten = txtID.Text;
        //    kh.Sdt = txtMK.Text;

        //    if (TaiKhoan_BUS.XoaTaikhoan(tk) == false)
        //    {
        //        MessageBox.Show("Không xóa được.");
        //        return;
        //    }
        //    loadtk();
        //    MessageBox.Show("Đã xóa thành công.");
        //}
    }
}
        