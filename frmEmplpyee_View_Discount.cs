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
    public partial class frmEmplpyee_View_Discount : Form
    {
        public frmEmplpyee_View_Discount()
        {
            InitializeComponent();
        }
        String strQuery;
        private void frmEmplpyee_Discount_View_Load(object sender, EventArgs e)
        {
            DisplayDiscount();
        }

        public void DisplayDiscount()//Dispplay Discount Data Grid View
        {

            strQuery = "Select DiscountID , DiscountType , ProductID , DiscountPercent , isValid from OrtizB21Su2332.Discount where isValid = 1";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);
            //dgvDiscount.AutoResizeColumn();

            dgvDiscount.Columns[0].HeaderText = "Discount ID ";
            dgvDiscount.Columns[1].HeaderText = "Discount Type";
            dgvDiscount.Columns[2].HeaderText = "Product ID";
            dgvDiscount.Columns[3].HeaderText = "Discount Percent";
            dgvDiscount.Columns[4].HeaderText = "Is Valid";
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    {

                    }
                    else if (dgvDiscount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dgvDiscount.CurrentRow.Selected = true;
                        lblDiscountID.Text = dgvDiscount.Rows[e.RowIndex].Cells["DiscountID"].Value.ToString();
                        lblDiscountType.Text = dgvDiscount.Rows[e.RowIndex].Cells["DiscountType"].Value.ToString();
                        lblProductID.Text = dgvDiscount.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                        lblDiscountPercent.Text = dgvDiscount.Rows[e.RowIndex].Cells["DiscountPercent"].Value.ToString();
                        cbxIsValid.Checked = Convert.ToBoolean(dgvDiscount.Rows[e.RowIndex].Cells["isValid"].Value);
                    }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
