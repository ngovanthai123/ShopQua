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

namespace GUI.Dialog
{
    public partial class KhachHangDialog : Form
    {
        public KhachHangDialog()
        {
            InitializeComponent();
            LoadKH();
        }

        public string _MaKH { get; set; }

        void LoadKH()
        {
            List<KhachHang_DTO> lstKH = KH_BUS.LayKH();
            dgv_KhachHang.DataSource = lstKH;


            dgv_KhachHang.Columns["Id"].HeaderText = "Mã khách hàng";

            dgv_KhachHang.Columns["Hoten"].HeaderText = "Họ tên";
            dgv_KhachHang.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgv_KhachHang.Columns["Sdt"].HeaderText = "Số điện thoại";

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (dgv_KhachHang.CurrentRow.Index < 0) return;
            _MaKH = $"{dgv_KhachHang.CurrentRow.Cells["id"].Value}";
            DialogResult = DialogResult.OK;

        }

        private void KhachHangDialog_Load(object sender, EventArgs e)
        {

        }

    }
}
