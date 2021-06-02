using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaocao : Form
    {
        public frmBaocao()
        {
            InitializeComponent();
            
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            var baoCao1 = new BaoCao_BUS();
            var ketQuaBaoCao1 = baoCao1.BaoCaoNgay(int.Parse(cbngay.Text), int.Parse(cbthang.Text), int.Parse(cbnam.Text));
            textBox1.Text = $"{ketQuaBaoCao1}";

        }

        void loadSP()
        {
            List<SP> lstSP = BaoCao_BUS.LaySP();
            dgSPTon.DataSource = lstSP;

            dgSPTon.Columns["Masp"].HeaderText = "Mã sản phẩm";
            dgSPTon.Columns["Tensp"].HeaderText = "Tên sản phẩm";
        }

        private void btnSPTon_Click(object sender, EventArgs e)
        {
            loadSP();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
