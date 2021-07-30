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
            this.Show();
        }

        private void btnEditSelfInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee_Edit_Self frmEditSelf = new frmEmployee_Edit_Self();
            frmEditSelf.ShowDialog();
            this.Show();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            frmFind_User frmFindUser = new frmFind_User();
            this.Hide();
            frmFindUser.ShowDialog();
            this.Show();
        }

        private void btnViewDiscounts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmplpyee_View_Discount frmEmpDisView = new frmEmplpyee_View_Discount();
            frmEmpDisView.ShowDialog();
            this.Show();
        }

        private void btnViewInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee_View_Inventory frmEmpInvView = new frmEmployee_View_Inventory();
            frmEmpInvView.ShowDialog();
            this.Show();
        }
    }
}
