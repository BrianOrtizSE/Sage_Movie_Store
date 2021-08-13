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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            switch (ProgOps._PICTURE)
            {
                case 1:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_MainScreen;
                    break;
                case 2:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_SignUp;
                    break;
                case 3:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_LogIn;
                    break;
                case 4:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_SecurityQuestion;
                    break;
                case 5:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_CustomerMainScreen;
                    break;
                case 6:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_Shop;
                    break;
                case 7:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_CheckOut;
                    break;
                case 8:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_MerchandiseView;
                    break;
                case 9:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_PasswordRecovery;
                    break;
                case 10:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_POS;
                    break;
                case 11:
                    pbxHelp.Image = Properties.Resources.Sages_Movie_Store_EditCustomer;
                    break;
                case 12:
                    pbxHelp.Image = Properties.Resources.FindUser;
                    break;

                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
