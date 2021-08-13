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

        private void btnProduct_Click(object sender, EventArgs e)//Dispaly Product Data Grid View
        {
            strQuery = "Select ProductID , ProductName , Quantity , ProductPrice from OrtizB21Su2332.Products";
            ProgOps.GrabDiscounts(dgvProduct, strQuery);

            dgvProduct.Visible = true;
            dgvDiscount.Visible = false;

            dgvProduct.Columns[0].HeaderText = "Product ID ";
            dgvProduct.Columns[1].HeaderText = "Product Name";
            dgvProduct.Columns[2].HeaderText = "Quantity";
            dgvProduct.Columns[3].DefaultCellStyle.Format = "c2";
            dgvProduct.Columns[3].HeaderText = "Product Price";
        }

        public void DisplayDiscount()//Dispplay Discount Data Grid View
        {

            strQuery = "Select * from OrtizB21Su2332.Discount where isValid = 1";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);
            if (ProgOps._blnFound == true)
            {
                //dgvDiscount.AutoResizeColumn();

                dgvProduct.Visible = false;
                dgvDiscount.Visible = true;

                dgvDiscount.Columns[0].HeaderText = "Discount ID ";
                dgvDiscount.Columns[1].HeaderText = "Discount Type";
                dgvDiscount.Columns[2].HeaderText = "Product ID";
                dgvDiscount.Columns[3].HeaderText = "Discount Percent";
                dgvDiscount.Columns[4].HeaderText = "Is Valid";
            }
            else
            {

            }
        }

        public void DisplayInactiveDiscount()//Dispplay Discount Data Grid View
        {

            strQuery = "Select * from OrtizB21Su2332.Discount where isValid = 0";
            ProgOps.GrabDiscounts(dgvDiscount, strQuery);
            if (ProgOps._blnFound == true)
            {
                //dgvDiscount.AutoResizeColumn();

                dgvProduct.Visible = false;
                dgvDiscount.Visible = true;

                dgvDiscount.Columns[0].HeaderText = "Discount ID ";
                dgvDiscount.Columns[1].HeaderText = "Discount Type";
                dgvDiscount.Columns[2].HeaderText = "Product ID";
                dgvDiscount.Columns[3].HeaderText = "Discount Percent";
                dgvDiscount.Columns[4].HeaderText = "Is Valid";
            }
            else
            {

            }
            
        }
        private void cmxDiscountType_SelectedIndexChanged(object sender, EventArgs e)//Used To Turn on Product Box
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

        private void btnAdd_Click(object sender, EventArgs e)//Add to Dataabse
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
                MessageBox.Show("Invalid! Please Fillout all required information!" , "Invalid Discount" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }

            tbxDiscount.Clear();
            tbxDiscountPercent.Clear();
            cmxDiscountType.Text = "1";
            cbxIsValid.Checked = false;
            tbxProductID.Clear();
        }

        private void tbxDiscount_TextChanged(object sender, EventArgs e)//Used to make sure that the Discount ID is valid
        {
            if(blnEdit == false)
            {
                if (tbxDiscount.Text.Length != 9)
                {
                    lblDiscountIDTextValid.Text = "X";
                    lblDiscountIDTextValid.ForeColor = Color.Red;
                }
                else
                {
                    strQuery = "Select DiscountID From OrtizB21Su2332.Discount where DiscountID =" + tbxDiscount.Text;
                    ProgOps.CheckID(strQuery);//Will Change to GrabProductID
                    if (ProgOps._blnFound == true)
                    {
                        lblDiscountIDTextValid.Text = "X";
                        lblDiscountIDTextValid.ForeColor = Color.Red;
                        MessageBox.Show("Invalid! DiscountID must be unique", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        lblDiscountIDTextValid.Text = "\u221A";
                        lblDiscountIDTextValid.ForeColor = Color.Green;
                    }
                }
            }
           
        }

        private void tbxDiscountPercent_TextChanged(object sender, EventArgs e)//Validation for Discount Percent
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

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)//For When the User is In Edit Discount Mode
        {
            try
            {
                if (blnEdit == true)
                {
                    if(e.RowIndex  < 0 || e.ColumnIndex < 0)
                    {

                    }
                    else if (dgvDiscount.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
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
            catch (ArgumentOutOfRangeException)
            {
                
            }
           
          
        }
        private void btnComplete_Click(object sender, EventArgs e)//For When User is Done making new Discount
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
                MessageBox.Show("Invalid Discount , Please Fill Out Neccesary Information " , "Invalid Disocunt" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

            tbxDiscount.Clear();
            tbxDiscountPercent.Clear();
            cmxDiscountType.Text = "1";
            cbxIsValid.Checked = false;
            tbxProductID.Clear();
        }
        private void SetState(string state)//Set State To Make It Easier For User
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
                    //Data Grid View
                    dgvDiscount.AllowUserToOrderColumns = false;

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
            DisplayDiscount();
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

        private void dgvDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowInactive_Click(object sender, EventArgs e)
        {
            DisplayInactiveDiscount();
        }

        private void btnShowActive_Click(object sender, EventArgs e)
        {

        }

        private void btnShowDisabled_Click(object sender, EventArgs e)
        {

        }

        private void mnsHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Discount : \n 1.Press Add Discount \n 2.Create a new DiscountID \n3.Choose The Type Of Discount \n 3.1 If Discount Type 2 Add Valid ProductID \n4.Choose Discount Percent \n5. Choose if it Valid / Active right now \n6.Add Discount" + 
                "\nEdit Discount: \n1 Press Edit Discount \n Click On Grid To Grab Discount Information \n3. Edit Discount Information \n4.Complete Edit", "Help File", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
