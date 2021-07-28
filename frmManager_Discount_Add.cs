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
    public partial class frmManager_Discount_Add : Form
    {
        public frmManager_Discount_Add()
        {
            InitializeComponent();
        }
        string strQuery;
        bool blnEdit = false;
        private void frmManager_Discount_Add_Load(object sender, EventArgs e)
        {
            DisplayDiscount();
            cmxDiscountType.Text = "1";
            SetState("View");
        }

        private void btnShowDiscount_Click(object sender, EventArgs e)
        {
            DisplayDiscount();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            strQuery = "Select ProductID , ProductName , Quantity , ProductPrice from OrtizB21Su2332.Products";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);

            dgvDiscount.Columns[0].HeaderText = "Product ID ";
            dgvDiscount.Columns[1].HeaderText = "Product Name";
            dgvDiscount.Columns[2].HeaderText = "Quantity";
            //dgvDiscount.Columns[3].DefaultCellStyle.Format = "c2";
            dgvDiscount.Columns[3].HeaderText = "Product Price";
        }

        public void DisplayDiscount()
        {
            strQuery = "Select * from OrtizB21Su2332.Discount";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);
            //dgvDiscount.AutoResizeColumn();

            dgvDiscount.Columns[0].HeaderText = "Discount ID ";
            dgvDiscount.Columns[1].HeaderText = "Discount Type";
            dgvDiscount.Columns[2].HeaderText = "Product ID";
            dgvDiscount.Columns[3].HeaderText = "Discount Percent";
            dgvDiscount.Columns[4].HeaderText = "Is Valid";
        }

        private void cmxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmxDiscountType.Text == "2")
            {
                tbxProductID.Enabled = true;
                lblProductIDValid.Visible = true;
            }
            else
            {
                tbxProductID.Enabled = false;
                lblProductIDValid.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int intBool = 1;
            if (cbxIsValid.Checked)
            {
                intBool = 1;
            }
            else
            {
                intBool = 0;
            }

            if (lblDiscountIDTextValid.Text == "\u221A" && lblDiscountPercentValid.Text == "\u221A" && cmxDiscountType.Text == "1")
            {
                strQuery = "Insert Into OrtizB21Su2332.Discount(DiscountID , DiscountType , ProductID , DiscountPercent , isValid) " +
                "values( " + tbxDiscount.Text + "," + cmxDiscountType.Text + ", NULL ," + tbxDiscountPercent.Text + "," + intBool + ")";
                ProgOps.CreateDiscount(strQuery);
                DisplayDiscount();

            }
            else if(lblDiscountIDTextValid.Text == "\u221A" && lblDiscountPercentValid.Text == "\u221A" && lblProductIDValid.Text == "\u221A")
            {
                strQuery = "Insert Into OrtizB21Su2332.Discount(DiscountID , DiscountType , ProductID , DiscountPercent , isValid) " +
                "values( " + tbxDiscount.Text + "," + cmxDiscountType.Text + "," + tbxProductID.Text + "," + tbxDiscountPercent.Text + "," + intBool + ")";
                ProgOps.CreateDiscount(strQuery);
                DisplayDiscount();
            }
            else
            {
                MessageBox.Show("Yeah It Would Be InValid");
            }

            tbxDiscount.Clear();
            tbxDiscountPercent.Clear();
            cmxDiscountType.Text = "1";
            cbxIsValid.Checked = false;
            tbxProductID.Clear();
        }

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            
            if (tbxDiscount.Text.Length != 9)
            {
                lblDiscountIDTextValid.Text = "X";
                lblDiscountIDTextValid.ForeColor = Color.Red;               
            }
            else
            {
                strQuery = "Select DiscountID From OrtizB21Su2332.Discount where DiscountID =" + tbxDiscount.Text;
                ProgOps.GrabProductID(strQuery);//Will Change to GrabProductID
                if (ProgOps._blnFound == true)
                {
                    lblDiscountIDTextValid.Text = "X";
                    lblDiscountIDTextValid.ForeColor = Color.Red;

                }
                else
                {
                    lblDiscountIDTextValid.Text = "\u221A";
                    lblDiscountIDTextValid.ForeColor = Color.Green;
                }
            }
        }

        private void tbxDiscountPercent_TextChanged(object sender, EventArgs e)
        {
            int intDiscountTest = 0;
            if (tbxDiscountPercent.Text == String.Empty)
            {

            }
            else
            {
                intDiscountTest = int.Parse(tbxDiscountPercent.Text);
            }

            

            if (tbxDiscountPercent.Text == String.Empty || intDiscountTest > 95)
            {
                lblDiscountPercentValid.Text = "X";
                lblDiscountPercentValid.ForeColor = Color.Red;
            }
            else
            {
                lblDiscountPercentValid.ForeColor = Color.Green;
                lblDiscountPercentValid.Text = "\u221A";
            }
        }

        private void tbxProductID_TextChanged(object sender, EventArgs e)
        {
            if (tbxProductID.Text == string.Empty || tbxProductID.Text.Length != 5)
            {
                lblProductIDValid.Text = "X";
                lblProductIDValid.ForeColor = Color.Red;
            }
            else
            {
                strQuery = "Select ProductID from OrtizB21Su2332.Products where ProductID = " + tbxProductID.Text;
                ProgOps.GrabProductID(strQuery);
                if(ProgOps._blnFound == true)
                {
                    lblProductIDValid.Text = "\u221A";
                    lblProductIDValid.ForeColor = Color.Green;
                }
                else
                {

                    lblDiscountPercentValid.Text = "X";
                    lblDiscountPercentValid.ForeColor = Color.Red;
                }
            }
            
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(blnEdit == true)
            {
                if (dgvDiscount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDiscount.CurrentRow.Selected = true;
                    tbxDiscount.Text = dgvDiscount.Rows[e.RowIndex].Cells["DiscountID"].Value.ToString();
                    cmxDiscountType.Text = dgvDiscount.Rows[e.RowIndex].Cells["DiscountType"].Value.ToString();
                    tbxProductID.Text = dgvDiscount.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                    tbxDiscountPercent.Text = dgvDiscount.Rows[e.RowIndex].Cells["DiscountPercent"].Value.ToString();
                    cbxIsValid.Checked = Convert.ToBoolean(dgvDiscount.Rows[e.RowIndex].Cells["isValid"].Value);
                }
            }
          
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            int intBool = 1;
            if (cbxIsValid.Checked)
            {
                intBool = 1;
            }
            else
            {
                intBool = 0;
            }

            if (lblDiscountPercentValid.Text == "\u221A" && cmxDiscountType.Text == "1")
            {
                strQuery = "Update OrtizB21Su2332.Discount " +
                "Set DiscountID = " + tbxDiscount.Text + ", DiscountType = " + cmxDiscountType.Text + ", ProductID = NULL , DiscountPercent = " + tbxDiscountPercent.Text + ", isValid = " + intBool + 
                "Where DiscountID =" + tbxDiscount.Text;
                ProgOps.CreateDiscount(strQuery);
                DisplayDiscount();

            }
            else if (lblDiscountPercentValid.Text == "\u221A" && lblProductIDValid.Text == "\u221A")
            {
                strQuery = "Update OrtizB21Su2332.Discount " +
                "Set DiscountID = " + tbxDiscount.Text + ", DiscountType = " + cmxDiscountType.Text + ", ProductID = " + tbxProductID.Text + " , DiscountPercent = " + tbxDiscountPercent.Text + ", isValid = " + intBool +
                "Where DiscountID =" + tbxDiscount.Text;
                ProgOps.CreateDiscount(strQuery);
                DisplayDiscount();
            }
            else
            {
                MessageBox.Show("Yeah It Would Be InValid");
            }

            tbxDiscount.Clear();
            tbxDiscountPercent.Clear();
            cmxDiscountType.Text = "1";
            cbxIsValid.Checked = false;
            tbxProductID.Clear();
        }

        private void tbxDiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || //ASCII Check For Numbers
                e.KeyChar == 8)
            {
                //Allow the key press
                e.Handled = false;
            }
            else
            {
                //Deny the key press
                e.Handled = true;
            }
        }

        private void tbxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || //ASCII Check For Numbers
                e.KeyChar == 8)
            {
                //Allow the key press
                e.Handled = false;
            }
            else
            {
                //Deny the key press
                e.Handled = true;
            }
        }

        private void tbxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || //ASCII Check For Numbers
                e.KeyChar == 8)
            {
                //Allow the key press
                e.Handled = false;
            }
            else
            {
                //Deny the key press
                e.Handled = true;
            }
        }

        private void SetState(string state)
        {
            string myState = state;

            switch (state)
            {
                case "View":
                    //button
                    btnAdd.Enabled = true;
                    btnEditDiscount.Enabled = true;
                    btnCancelEdit.Enabled = false;
                    btnCompleteEdit.Enabled = false;
                    //labels
                    lblDiscountIDTextValid.Visible = true;

                    //textboxes
                    tbxDiscount.Enabled = true;

                    //Bool
                    blnEdit = false;
                    break;

                case "Edit":
                    //Button
                    btnEditDiscount.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCompleteEdit.Enabled = true;
                    btnCancelEdit.Enabled = true;

                    //labels
                    lblDiscountIDTextValid.Visible = false;

                    //Text boxes
                    tbxDiscount.Enabled = false;

                    blnEdit = true;
                    break;
                default:
                   
                    break;
            }
        }

        private void btnEditDiscount_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void dgvDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            SetState("View");
            tbxDiscount.Clear();
            tbxDiscountPercent.Clear();
            cmxDiscountType.Text = "1";
            cbxIsValid.Checked = false;
            tbxProductID.Clear();
        }
    }
}
