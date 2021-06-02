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
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
            LoadFrom();
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {

        }
        void LoadFrom()
        {
            timer1.Start();

        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Loading.Value = start += 2;//
            Loading.Maximum = 101;
            Loading.Minimum = 0;
            label1.Text = "Loading " + start + " %";

            //progressBar1.Value = 0;
            if (Loading.Value == 100)
            {
                timer1.Stop();

                frmMain main = new frmMain();
                DialogResult mainResult = main.ShowDialog();
                if (mainResult == DialogResult.Abort) //Khi đóng form main thì form login sẽ đóng
                {
                    this.Close();
                }
            }
        }
    }
}
