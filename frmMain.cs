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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }

        private void tsSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frmsingup = new frmSignUp();
            frmsingup.ShowDialog();
        }

        private void tsLogIn_Click(object sender, EventArgs e)
        {
            frmLogIn frmlogin = new frmLogIn();
            frmlogin.ShowDialog();
        }
    }
}