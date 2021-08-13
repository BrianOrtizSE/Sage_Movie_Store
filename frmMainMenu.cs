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
using System.IO;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmManager_View_Sales frmSales = new frmManager_View_Sales();
            frmSales.ShowDialog();
        }

    }
}