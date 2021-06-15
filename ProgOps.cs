using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SU21_Final_Project
{
    class ProgOps
    {
        //Connetions to open database
        public static string CONNECT_STRING = @"Server= cstnt.tstc.edu;" + "Database=inew2332su21;" + "User Id=OrtizB21Su2332;" + "Password=1739497;";

        private static SqlConnection _conDatabase = new SqlConnection(CONNECT_STRING);
        private static SqlCommand _sqlResultsCommand;
        private static SqlDataAdapter _daLogOn = new SqlDataAdapter();
        private static DataTable _dtLogOn = new DataTable();
        
        //Information for Product Table
        private static SqlDataAdapter _daProduct = new SqlDataAdapter();
        private static DataTable _dtProductTable = new DataTable();

        //Int for PersonID
        public static int intPersonID;
        //Bool If Person Was Found
        public static bool blnFound;

        //Strinbuilder for error messages in the trycatch
        private static StringBuilder errorMessages = new StringBuilder();
        public static void OpenDatabase()
        {
            try
            {
                //Try to open the database
                _conDatabase.Open();

                //If it worked
                MessageBox.Show("Connection to Database Opened Successfully!", "Connection Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) //Note: May change to SqlException down the road
            {
                MessageBox.Show(e.Message);


            }
        }
        public static void CloseDatabase()//Attemp to Close The Database
        {
            try
            {
                //closes Database 
                _conDatabase.Close();
                _conDatabase.Dispose();

                MessageBox.Show("Connection to Database Closed Successfully!", "Connection Status",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) //Note: May change to SqlException down the road
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void LogOn(TextBox tbxUsername, TextBox tbxPassword, RadioButton rdButtonA, RadioButton rdButtonB, String query)
        {
            //used to search for specific user
            
            if (rdButtonA.Checked == true)
            {
                query = "Select * From OrtizB21Su2332.LogOn " +
                 "Where Username = '" + tbxUsername.Text + "' " +
                 "And Password = '" + tbxPassword.Text + "';";
            }
            if (rdButtonB.Checked == true)
            {
                query = "Select * From OrtizB21Su2332.LogOn, OrtizB21Su2332.Employees " +
                "Where EmployeeID = " + tbxUsername.Text + " " +
                "and Password = '" + tbxPassword.Text + "';";
            }


            //establush command object
            _sqlResultsCommand = new SqlCommand(query, _conDatabase);
            //establish data adapter
            _daLogOn = new SqlDataAdapter();
            _daLogOn.SelectCommand = _sqlResultsCommand;
            //fill data table
            _dtLogOn = new DataTable();
            _daLogOn.Fill(_dtLogOn);

            if (_dtLogOn.Rows.Count == 1)
            {
                MessageBox.Show("User Was Found");
                blnFound = true;
            }
            else
                MessageBox.Show("User Was Not Found");
                blnFound = false;

        }

        public static void CreateNewUser(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, TextBox tbxSuffix, TextBox tbxAddress1, TextBox tbxAddress2, TextBox tbxAddress3,
                                        TextBox tbxCity, TextBox tbxZipcode, TextBox tbxState, TextBox tbxEmail, TextBox tbxPhonePrim, TextBox tbxPhoneSecon, string query)
        {
            try
            {

                //establish Command Object For This Function
                _sqlResultsCommand = new SqlCommand(query, _conDatabase);
                _sqlResultsCommand.ExecuteNonQuery();

                //Dispose Of Command Object
                _sqlResultsCommand.Dispose();

            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.

                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        public static void GrabPersonID()
        {
            //Grab the newst PersonID that was just creted
            String query = "Select PersonID From OrtizB21Su2332.Person Order by PersonID desc";

            _sqlResultsCommand = new SqlCommand(query, _conDatabase);

            //Grab PersonID so we can cretae LogIn Info
            intPersonID = (int)_sqlResultsCommand.ExecuteScalar();

        }

        public static void CreateLogIn(TextBox tbxUsername, TextBox tbxPassword, ComboBox cmbSQuestion1, TextBox SQAnswer1, ComboBox cmbSQuestion2, TextBox SQAnswer2, String strQuery)
        {
            try
            {
                //Using the Sqlcommand we execute the Query
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                _sqlResultsCommand.ExecuteNonQuery();

                //Dispose Of Command Object
                _sqlResultsCommand.Dispose();

            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.

                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public static void GrabProduct(TextBox tbxProductID, DataGridView dgvOrders)
        {
            string strQuery = "Select ProductID , CategoryID , ProductName , Quantity , ProductPrice , ProductDescription From OrtizB21Su2332.Products Where Quantity > 0";

            //Establish Command Object
            _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

            //Establish Data Adapter
            _daProduct = new SqlDataAdapter();
            _daProduct.SelectCommand = _sqlResultsCommand;

            //Fill Data Table
            _dtProductTable = new DataTable();
            _daProduct.Fill(_dtProductTable);
            dgvOrders.DataSource = _dtProductTable;

        }
    }
}
