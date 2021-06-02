using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)

        { 
           
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
