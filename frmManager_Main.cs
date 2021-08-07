﻿using System;
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
            frmManager_Edit_Inventory frmmerchadd = new frmManager_Edit_Inventory();
            frmmerchadd.ShowDialog();
            this.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            frmManager_View_Sales frmviewsales = new frmManager_View_Sales();
            this.Hide();
            frmviewsales.ShowDialog();
            this.Show();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager_Discount_Add frmDisAdd = new frmManager_Discount_Add();
            frmDisAdd.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager_Edit_Customer frmEditCustomer = new frmManager_Edit_Customer();
            frmEditCustomer.ShowDialog();
            this.Show();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager_Edit_Employees frmEditEmp = new frmManager_Edit_Employees();
            frmEditEmp.ShowDialog();
            this.Show();
        }
    }
}
