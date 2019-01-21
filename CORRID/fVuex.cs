using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORRID
{
    public partial class fVuex : Form
    {
        public fVuex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fVSub1 _dlg = new fVSub1();
            _dlg.ShowDialog();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            fVSub2 _dlg = new fVSub2();
            _dlg.ShowDialog();

        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            fVSub3 _dlg = new fVSub3();
            _dlg.ShowDialog();

        }
    }
}
