using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SU21_Final_Project
{
    public partial class frmMerchandiseAdd : Form
    {
        public frmMerchandiseAdd()
        {
            InitializeComponent();
        }

        //Set up merchandise CurrencyManager
        CurrencyManager prodManager;

        //Future variables for state and bookmark
        string myState;
        bool blnInStock;
        string query;
        int myBookmark;      


        private void frmMerchandiseAdd_Load(object sender, EventArgs e)
        {
            try
            {
               
                //Load in the Products table from the database
                ProgOps.ProductView(tbxProductID, tbxProductName, tbxGenre, tbxQuantity, tbxPrice, tbxDescription, cbxInStock);

                //Fill the currency manager
                prodManager = (CurrencyManager)this.BindingContext[ProgOps.GetProductTable];

                //Start in view state
                SetState("View");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error : Products Table ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Move back one entry if currency manager is not at the first
            if (prodManager.Position != 0)
            {
                prodManager.Position--;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (prodManager.Position != prodManager.Count - 1)
                prodManager.Position++;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            prodManager.Position = 0;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            prodManager.Position = prodManager.Count - 1;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = prodManager.Position;

                //clear everything
                tbxProductID.Clear();
                tbxProductName.Clear();
                tbxGenre.Clear();
                tbxQuantity.Clear();
                tbxPrice.Clear();
                tbxDescription.Clear();



                SetState("Add");
                tbxProductName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error : In Add New ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Set the form into "Edit" mode
            SetState("Edit");
            tbxProductName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Trim the textbox(s) that don't reject spaces
            tbxProductName.Text = tbxProductName.Text.Trim();

            //strinb builder for error messages
            StringBuilder errorMessages = new StringBuilder();

            int intInStock;
            int intRow;

            string savedName = tbxProductName.Text;

            blnInStock = cbxInStock.Checked;

            //since query needs a 1 or 0 this int does that
            if (blnInStock)
            {
                intInStock = 1;
            } else
                intInStock = 0;

            try
            {

                if (DataIsValid(tbxGenre.Text, tbxProductName.Text, tbxQuantity.Text, tbxPrice.Text, tbxDescription.Text) && myState == "Add")
                {
                    //query to add new item
                    query = "Insert into OrtizB21Su2332.Products(ProductName , Genre , Quantity , ProductPrice , ProductDescription , inStock)" +
                    "values ('" + tbxProductName.Text + "','" + tbxGenre.Text + "', " + tbxQuantity.Text + " , " + tbxPrice.Text + " , '" + tbxDescription.Text + "'," + intInStock + ")";

                }
                else if (DataIsValid(tbxGenre.Text, tbxProductName.Text, tbxQuantity.Text, tbxPrice.Text, tbxDescription.Text) && myState == "Edit")
                {
                    //query to add edit item
                    query = "Update OrtizB21Su2332.Products " +
                       "Set ProductName = '" + tbxProductName.Text + "', Genre = '" + tbxGenre.Text + "', Quantity = " + tbxQuantity.Text + ", ProductPrice = " + tbxPrice.Text + ", ProductDescription = '" + tbxDescription.Text + "', inStock = " + 1 +
                       " Where ProductID = " + tbxProductID.Text;
                }
                else
                {
                    MessageBox.Show("Error During Saving Proccess", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                if (blnInStock)
                {
                    ProgOps.ProductAddEdit(tbxProductName, tbxGenre, tbxQuantity, tbxPrice, tbxDescription, 1, query);
                    //Display confirming message box
                    MessageBox.Show("Record saved successfully.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    ProgOps.ProductAddEdit(tbxProductName, tbxGenre, tbxQuantity, tbxPrice, tbxDescription, 0, query);
                    //Display confirming message box
                    MessageBox.Show("Record saved successfully.", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (SqlException ex)
            {
                //Set the error message and display it
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber " + ex.Errors[i].LineNumber + "\n" +
                        "Source " + ex.Errors[i].Source + "\n" +
                        "Procedure " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString(), "Error on Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            SetState("View");

            //Have the currency manager end the edit and re-sort the table
            //prodManager.EndCurrentEdit();
            //ProgOps.GetProductTable.DefaultView.Sort = "ProductName";
            //intRow = ProgOps.GetProductTable.DefaultView.Find(savedName);
            //prodManager.Position = intRow;

        }     

        public bool DataIsValid(string strProductName, string strGenre,  string strQuantity,
                                string strPrice , string strDescription)
        {
            //Check if any textbox is empty
            if (strGenre == "" || strProductName == "" || strQuantity == "" || strPrice == "" || strDescription == "")
            {
                MessageBox.Show("Please make sure all fields are filled in.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbxInStock.Checked == false)
            {
                DialogResult dialogresults = MessageBox.Show("Plesae Confirm Item is Out Of Stock", "Out Of Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogresults == DialogResult.Yes)
                {
                    return true;
                }
                else if (dialogresults == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Cancel the edit
            prodManager.CancelCurrentEdit();

            //If cancelling from adding an entry, return to saved position
            if (myState == "Add")
                prodManager.Position = myBookmark;

            //Return to view mode
            SetState("View");
        }

        private void SetState(string state)
        {
            myState = state;

            switch (state)
            {
                case "View":
                    //Buttons
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnFirst.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnClose.Enabled = true;
                    //textbox
                    tbxProductID.BackColor = Color.White;
                    tbxGenre.ReadOnly = true;
                    tbxProductName.ReadOnly = true;
                    tbxQuantity.ReadOnly = true;
                    tbxPrice.ReadOnly = true;
                    tbxDescription.ReadOnly = true;
                    cbxInStock.Enabled = false;
                    break;
                default:
                    //Buttons
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnFirst.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnClose.Enabled = false;
                    //textbox
                    tbxProductID.BackColor = Color.Red;
                    tbxGenre.ReadOnly = false;
                    tbxProductName.ReadOnly = false;
                    tbxQuantity.ReadOnly = false;
                    tbxDescription.ReadOnly = false;
                    tbxPrice.ReadOnly = false;
                    cbxInStock.Enabled = true;
                    break;
            }
        }

        private void frmMerchandiseInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Check if the user is not in view mode
            if (myState != "View")
            {
                //Display notification and cancel close
                MessageBox.Show("You must finish the current edit before closing the application.", "Finish Edit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                //Update database
                ProgOps.ProductDispose();
            }
        }

    }
}
