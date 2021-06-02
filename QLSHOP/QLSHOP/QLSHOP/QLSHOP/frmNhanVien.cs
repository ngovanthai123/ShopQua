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


namespace QLCH
{
    public  class FrmNhanVien : Form
    {
       
        public FrmNhanVien()
        {
            InitializeComponent();
           

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dgDSnv.DataSource = lstNhanVien;
        }
        
        private void dgDSnv_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgDSnv.SelectedRows[0];
            txtManv.Text = row.Cells["SID"].Value.ToString();
            txtHoten.Text = row.Cells["SHolot"].Value.ToString();
            if (row.Cells["Sgioitinh"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            Dtngaysinh.Text = row.Cells["Dtngaysinh"].Value.ToString();
            txtCMND.Text = row.Cells["Scmnd"].Value.ToString();
            txtDiachi.Text = row.Cells["Sdiachi"].Value.ToString();
            txtSDT.Text = row.Cells["Ssdt"].Value.ToString();
            cbChucvu.SelectedValue = row.Cells["Schucvu"].Value.ToString();
        }
    }
}
