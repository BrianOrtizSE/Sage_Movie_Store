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
    public partial class frmManager_Main : Form
    {
        public frmManager_Main()
        {
            InitializeComponent();
        }

        private void btnMerchandiseAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMerchandiseAdd frmmerchadd = new frmMerchandiseAdd();
            frmmerchadd.ShowDialog();
        }
    }
}
