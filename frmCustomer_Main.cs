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
    public partial class frmCustomer_Main : Form
    {
        public frmCustomer_Main()
        {
            InitializeComponent();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            frmCreateInvoice frmcreateinvoice = new frmCreateInvoice();
            this.Hide();
            frmcreateinvoice.ShowDialog();
            this.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmMerhandiseView frmMerhandise = new frmMerhandiseView();
            this.Hide();
            frmMerhandise.ShowDialog();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            lblDate.Text = localDate.ToString();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmhelp = new frmHelp();
            ProgOps._PICTURE = 5;
            this.Hide();
            frmhelp.ShowDialog();
            this.Show();
        }
    }
}
