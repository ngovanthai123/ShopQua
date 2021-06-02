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
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
           

      
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "DN":
                    webBrowser1.Navigate(@"F:\DPM185200_NgoVanThai\QLSHOP\QLSHOP\QLSHOP\GUI\help\DangNhap.mht");
                    break;
                case "DX":
                    webBrowser1.Navigate(@"F:\DPM185200_NgoVanThai\QLSHOP\QLSHOP\QLSHOP\GUI\help\DangXuat.mht");
                    break;
                default:
                    break;

            }
        }

        private void frmHuongDan_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
