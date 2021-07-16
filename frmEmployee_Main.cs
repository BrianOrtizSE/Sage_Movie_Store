using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU21_Final_Project
{
    public partial class frmEmployee_Main : Form
    {
        public frmEmployee_Main()
        {
            InitializeComponent();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee_POS frmEmpPos = new frmEmployee_POS();
            frmEmpPos.ShowDialog();
        }
    }
}
