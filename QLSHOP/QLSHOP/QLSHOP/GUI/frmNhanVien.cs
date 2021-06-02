using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
       
        public frmNhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
            LoadTB();


        }
        void LoadNhanVien()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dgDSnv.DataSource = lstNhanVien;

            dgDSnv.Columns["Id"].HeaderText = "Mã nhân viên";
            dgDSnv.Columns["Hoten"].HeaderText = "Họ tên";
            dgDSnv.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgDSnv.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgDSnv.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSnv.Columns["Cmnd"].HeaderText = "CMND";
            dgDSnv.Columns["Diachi"].HeaderText = "Địa chỉ";
            dgDSnv.Columns["Tencv"].HeaderText = "Chức vụ";
        }

        void LoadTB()
        {
            txtManv.DataBindings.Clear();
            txtManv.DataBindings.Add("Text", dgDSnv.DataSource, "ID");

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgDSnv.DataSource, "hoten");

            rdNam.DataBindings.Clear();        
            var maleBinding = new Binding("Checked", dgDSnv.DataSource, "Gioitinh");
            maleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nam";
            maleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nam" : "Nữ";
            rdNam.DataBindings.Add(maleBinding);

            rdNu.DataBindings.Clear();
            var femaleBinding = new Binding("Checked", dgDSnv.DataSource, "Gioitinh");
            femaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ";
            femaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ" : "Nam";
            rdNu.DataBindings.Add(femaleBinding);

            Dtngaysinh.DataBindings.Clear();
            Dtngaysinh.DataBindings.Add("Text", dgDSnv.DataSource, "ngaysinh");

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgDSnv.DataSource, "diachi");

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgDSnv.DataSource, "cmnd");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgDSnv.DataSource, "sdt");

            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", dgDSnv.DataSource, "tencv");           
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtManv.Text == "" || txtHoten.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtManv.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtManv.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            // k co chuc vu t de choi
            if (NhanVien_BUS.ThemNhanVien(txtHoten.Text, gioitinh, Dtngaysinh.Value.ToShortDateString(), txtManv.Text, txtCMND.Text, txtDiachi.Text, txtSDT.Text,txtChucVu.Text))
                MessageBox.Show("Thành công", "Thông báo");     
            else            
                MessageBox.Show("Không thêm được.");               
            LoadNhanVien();
            LoadTB();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NhanVien_BUS.XoaNhanVien(txtManv.Text))
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
            else
                MessageBox.Show("Lỗi!", "Thông báo");
            LoadNhanVien();
            LoadTB();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nữ";

            if(NhanVien_BUS.SuaNhanVien(txtManv.Text, txtHoten.Text, gioitinh, Dtngaysinh.Value.ToShortDateString(), txtCMND.Text, txtDiachi.Text, txtSDT.Text, txtChucVu.Text))
                MessageBox.Show("Thành công", "Thông báo");
            else
                MessageBox.Show("Không sửa được.");

            LoadNhanVien();
            LoadTB();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTim.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSnv.DataSource = lstnv;
        }

        private void btnlai_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadTB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
