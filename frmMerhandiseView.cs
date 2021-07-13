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
    public partial class frmMerhandiseView : Form
    {
        public frmMerhandiseView()
        {
            InitializeComponent();
        }
        string strQuery;
        private void frmProductView_Load(object sender, EventArgs e)
        {

            //On Load We Display All Items
            strQuery = "Select * From OrtizB21Su2332.Products"; ;
            ProgOps.GrabProduct(tbxProductID, dgvView, strQuery);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Look For Specific Item

            if (tbxProductID.Text == string.Empty)
            {
                MessageBox.Show("Search box must not be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                strQuery = "Select * From OrtizB21Su2332.Products Where ProductID = " + tbxProductID.Text;
                ProgOps.GrabProduct(tbxProductID, dgvView, strQuery);

                if (dgvView.RowCount != 1)
                {

                }
                else
                {
                    MessageBox.Show("The entered ID doesn't exist within our inventory.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Reset User
                    tbxProductID.Clear();
                    tbxProductID.Focus();

                    //Reset Data Grid View
                    strQuery = "Select * From OrtizB21Su2332.Products"; ;
                    ProgOps.GrabProduct(tbxProductID, dgvView, strQuery);

                }

            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset Data Grid View
            strQuery = "Select * From OrtizB21Su2332.Products"; ;
            ProgOps.GrabProduct(tbxProductID, dgvView, strQuery);
        }

        private void tbxProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and backspace
            if (e.KeyChar >= 48 && e.KeyChar <= 57 ||       //ASCII Check for Numbers
                e.KeyChar == 8)                             //ASCII Check for Backspace

            {
                //Accept the keystroke
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void mnsHelp_Click(object sender, EventArgs e)
        {
            ProgOps._PICTURE = 8;
            this.Hide();
            frmHelp frmhelp = new frmHelp();
            frmhelp.ShowDialog();
            this.Show();
        }
    }
}
