//ToDo: Change the entries below indicated by {} to your values
//*******************************************
//*******************************************
// Programmer: Brian Ortiz
// Course: INEW 2332.7Z2 (Final Project)
// Program Description: Form Purpose: To create a fully functional movie store project that comes with a employee / manager POS system 
// and a customer friendly view and purchase merchandise function
//*******************************************
// 
//*******************************************
//*******************************************

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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgOps._PICTURE = 1;
            frmHelp frmhelp = new frmHelp();
            frmhelp.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }

        private void tsSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void tsLogIn_Click(object sender, EventArgs e)
        {
            
        }

        private void addMerchandiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManager_Edit_Inventory frmmerchadd = new frmManager_Edit_Inventory();
            this.Hide();
            frmmerchadd.ShowDialog();
            this.Show();
        }

        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer_POS frmcreateinvoice = new frmCustomer_POS();

            frmcreateinvoice.ShowDialog();
        }

        private void securityQuestionCheclToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecurityQuestions frmsq = new frmSecurityQuestions();
            frmsq.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignUp frmsingup = new frmSignUp();
            this.Hide();
            frmsingup.ShowDialog();
            this.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmLogIn frmlogin = new frmLogIn();
            this.Hide();
            frmlogin.ShowDialog();
            this.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmManager_Edit_Inventory frmmerch = new frmManager_Edit_Inventory();
            frmmerch.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmManager_View_Sales frmviewsales = new frmManager_View_Sales();
            this.Hide();
            frmviewsales.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManager_Discount_Add frmDiscountAdd = new frmManager_Discount_Add();
            frmDiscountAdd.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee_Edit_Customer frmempcusedit = new frmEmployee_Edit_Customer();
            frmempcusedit.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEmployee_View_Inventory frminvvie = new frmEmployee_View_Inventory();
            frminvvie.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEmplpyee_View_Discount frmDisView = new frmEmplpyee_View_Discount();
            frmDisView.ShowDialog();
        }
    }
}