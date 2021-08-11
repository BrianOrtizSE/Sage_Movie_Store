using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace SU21_Final_Project
{
    class ProgOps
    {
        //Connetions to open database
        public static string CONNECT_STRING = @"Server= cstnt.tstc.edu;" + "Database=inew2332su21;" + "User Id=OrtizB21Su2332;" + "Password=1739497;";

        private static SqlConnection _conDatabase = new SqlConnection(CONNECT_STRING);
        private static SqlCommand _sqlResultsCommand;
        //Information for LogOn Table
        private static SqlDataAdapter _daLogOn = new SqlDataAdapter();
        private static DataTable _dtLogOn = new DataTable();
        //Information for Product Table
        private static SqlDataAdapter _daProduct = new SqlDataAdapter();
        private static DataTable _dtProductTable = new DataTable();
        //Information for Discount Table
        private static SqlDataAdapter _daDiscount = new SqlDataAdapter();
        private static DataTable _dtDiscount = new DataTable();
        //Information for Sales
        private static SqlDataAdapter _daSales = new SqlDataAdapter();
        private static DataTable _dtSales = new DataTable();
        //Information for Person
        private static SqlDataAdapter _daPerson = new SqlDataAdapter();
        private static DataTable _dtPerson = new DataTable();
        //Information for Employee
        private static SqlDataAdapter _daEmployee = new SqlDataAdapter();
        private static DataTable _dtEmployee = new DataTable();

        //Function To Get Product Tabled
        public static DataTable GetProductTable
        {
            //Return the product table when called
            get { return _dtProductTable; }
        }
        public static DataTable GetPersonTable
        {
            //Return the product table when called
            get { return _dtPerson; }
        }


        //INT FOR PICTURE CASES
        public static int _PICTURE;

        //TAX FOR WHOLE PROJECT:
        public static decimal _TAX = 0.0825M;

        //Public Ints and Deciamls
        public static int _intPersonID = 1000;
        public static int _intEmployeeID;
        //public static int _intEmployeeIDCheck;

        public static int _intProductID = 0;
        public static int _FindUser = 0;
        public static int _intQuantity;
        public static decimal _decDiscountPercent = 0.0m;


        //Public Booleans
        public static bool _blnFound;
        public static bool _blnDiscountFound;


        //Strinbuilder for error messages in the trycatch
        private static StringBuilder errorMessages = new StringBuilder();


        //Standard Functions for database stuff
        public static void OpenDatabase()//Attemp To Open Database
        {
            try
            {
                //Try to open the database
                _conDatabase.Open();
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
            }
            catch (Exception e) //Note: May change to SqlException down the road
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void LogOn(String query)//Used At LogIn Scren To Log User In
        {
            try
            {

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
                    _blnFound = true;
                }
                else
                {
                    _blnFound = false;
                }

                _sqlResultsCommand.Dispose();
                _daLogOn.Dispose();
                _dtLogOn.Dispose();
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
        

        //Used These Functions To Grab Information From The Database
        public static void GrabPersonNewID()
        {
            try
            {
                //Grab the newst PersonID that was just creted used for Security Question 
                String query = "Select PersonID From OrtizB21Su2332.Person Order by PersonID desc";

                _sqlResultsCommand = new SqlCommand(query, _conDatabase);

                //Grab PersonID so we can cretae LogIn Info
                _intPersonID = (int)_sqlResultsCommand.ExecuteScalar();

                _sqlResultsCommand.Dispose();
            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public static void GrabPersonID(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //establish data adapter
                _daPerson = new SqlDataAdapter();
                _daPerson.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtPerson = new DataTable();
                _daPerson.Fill(_dtPerson);

                if (_dtPerson.Rows.Count == 1)
                {
                    _blnFound = true;

                    //Grab PersonID
                    _intPersonID = (int)_sqlResultsCommand.ExecuteScalar();
                }
                else
                {
                    _blnFound = false;
                    MessageBox.Show("No User Was Found", "No User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _sqlResultsCommand.Dispose();


            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error NULL", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _sqlResultsCommand.Dispose();
        }
        public static void GrabEmployeeID(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //establish data adapter
                _daLogOn = new SqlDataAdapter();
                _daLogOn.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtLogOn = new DataTable();
                _daLogOn.Fill(_dtLogOn);

                if (_dtLogOn.Rows.Count == 1)
                {
                    _blnFound = true;

                    //Grab EmployeeID so we can cretae LogIn Info
                    _intEmployeeID = (int)_sqlResultsCommand.ExecuteScalar();
                }
                else
                {
                    _blnFound = false;

                }


                _sqlResultsCommand.Dispose();
            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error NULL", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static void CheckEmployeeID(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //establish data adapter
                _daLogOn = new SqlDataAdapter();
                _daLogOn.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtLogOn = new DataTable();
                _daLogOn.Fill(_dtLogOn);

                if (_dtLogOn.Rows.Count == 1)
                {
                    _blnFound = true;
                }
                else
                {
                    _blnFound = false;

                }


                _sqlResultsCommand.Dispose();
            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error NULL", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static void GrabProductID(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //establish data adapter
                _daProduct = new SqlDataAdapter();
                _daProduct.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtProductTable = new DataTable();
                _daProduct.Fill(_dtProductTable);

                if (_dtProductTable.Rows.Count != 0)
                {
                    _blnFound = true;
                    //Grab EmployeeID so we can cretae LogIn Info
                    _intProductID = (int)_sqlResultsCommand.ExecuteScalar();
                }
                else
                {
                    _blnFound = false;
                    MessageBox.Show("No Product Was Found", "No Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _daProduct.Dispose();
                _dtProductTable.Dispose();
                _sqlResultsCommand.Dispose();
            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error NULL", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public static void GrabAmount(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //Grab PersonID so we can cretae LogIn Info
                _intQuantity = (int)_sqlResultsCommand.ExecuteScalar();

                _sqlResultsCommand.Dispose();
            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("NULL Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void GrabPassword(string query)
        {

            try
            {

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
                    _blnFound = true;
                }
                else
                {
                    _blnFound = false;
                    //MessageBox.Show("No User Was Found", "No User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _sqlResultsCommand.Dispose();
                _daLogOn.Dispose();
                _dtLogOn.Dispose();
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
        public static bool GrabAdmin(int intPersonID)
        {

            string strQuery = "Select isAdmin from OrtizB21Su2332.Employees " +
            "Where PersonID = " + intPersonID;
            bool isAdmin = false;
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //Grab PersonID so we can cretae LogIn Info
                isAdmin = (bool)_sqlResultsCommand.ExecuteScalar();

                _sqlResultsCommand.Dispose();


            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            return isAdmin;
        }
        public static void CheckPicture(string strQuery)
        {
            try
            {

                //establush command object
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                //establish data adapter
                _daProduct = new SqlDataAdapter();
                _daProduct.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtProductTable = new DataTable();
                _daProduct.Fill(_dtProductTable);

                if (_dtProductTable.Rows.Count == 1)
                {
                    _blnFound = true;
                }
                else
                {
                    _blnFound = false;
                    //MessageBox.Show("No User Was Found", "No User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _sqlResultsCommand.Dispose();
                _daLogOn.Dispose();
                _dtLogOn.Dispose();
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


        //Check to make sure whatever is being looked up is available and in the database if not returns false
        public static void GrabDiscountInformation(TextBox tbxDiscountCode)//used to check for product discount vs whole sale discount
        {
            int intDiscountType = 0;
            string strQuery;


            try
            {
                strQuery = "Select DiscountType from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;

                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                //Grab ProductID IF one is associated with this item
                intDiscountType = (int)_sqlResultsCommand.ExecuteScalar();

                switch (intDiscountType)
                {

                    case 1: //For whole sale discount items
                        strQuery = "Select DiscountPercent from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;

                        _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                        //Grab ProductID IF one is associated with this item
                        _decDiscountPercent = (decimal)_sqlResultsCommand.ExecuteScalar();
                        break;

                    case 2: //For Type 2 Discount that need a specific item in their to use
                        strQuery = "Select DiscountPercent from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;

                        _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                        _decDiscountPercent = (decimal)_sqlResultsCommand.ExecuteScalar();

                        strQuery = "Select ProductID from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;
                        _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                        _intProductID = (int)_sqlResultsCommand.ExecuteScalar();
                        break;

                    //case 3: TO BE USED LATER FOR ITEMS SUCH AS BOGO AND SUCH
                    //    strQuery = "Select DiscountPercent from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;

                    //    _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                    //    //Grab ProductID IF one is associated with this item
                    //    decDiscountPercent = (decimal)_sqlResultsCommand.ExecuteScalar();
                    //    break;

                    default:
                        MessageBox.Show("Error Invalid Discount Type", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;


                }
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
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        public static void GrabDiscountID(TextBox tbxDiscountCode)
        {
            try
            {
                String strQuery = "Select * from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;

                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                //establish data adapter
                _daDiscount = new SqlDataAdapter();
                _daDiscount.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtDiscount = new DataTable();
                _daDiscount.Fill(_dtDiscount);

                if (_dtDiscount.Rows.Count == 1)
                {
                    _blnDiscountFound = true;
                    GrabDiscountInformation(tbxDiscountCode);
                }
                else
                {
                    _blnDiscountFound = false;
                }

            }
            catch (SqlException ex)
            {
                //Check if an SqlException was caught
                if (ex is SqlException)
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
                    MessageBox.Show(errorMessages.ToString(), "Discount Search Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
        
        


        //Fucntions for Data Grid Views ++++Maybe change to one big one later+++++++
        public static void GrabEmployee(DataGridView dgvOrders, String strQuery)
        {

            try
            {
                //Establish Command Object
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //Establish Data Adapter
                _daEmployee = new SqlDataAdapter();
                _daEmployee.SelectCommand = _sqlResultsCommand;

                //Fill Data Table
                _dtEmployee = new DataTable();
                _daEmployee.Fill(_dtEmployee);

                if (_dtEmployee.Rows.Count == 0)
                {
                    _blnFound = false;
                    MessageBox.Show("No Item's Were Found", "No Item's", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _blnFound = true;
                    dgvOrders.DataSource = _dtEmployee;
                }
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
            _sqlResultsCommand.Dispose();
            _dtEmployee.Dispose();
            _daEmployee.Dispose();

        }
        public static void GrabSales(DataGridView dgvSales, String strQuery)
        {
            try
            {

                //establush command object
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                //establish data adapter
                _daSales = new SqlDataAdapter();
                _daSales.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtSales = new DataTable();
                _daSales.Fill(_dtSales);

                dgvSales.DataSource = _dtSales;
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
        public static void GrabProduct(DataGridView dgvOrders, String strQuery)
        {

            try
            {
                //Establish Command Object
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //Establish Data Adapter
                _daProduct = new SqlDataAdapter();
                _daProduct.SelectCommand = _sqlResultsCommand;

                //Fill Data Table
                _dtProductTable = new DataTable();
                _daProduct.Fill(_dtProductTable);

                if (_dtProductTable.Rows.Count == 0)
                {
                    _blnFound = false;
                    MessageBox.Show("No Item's Were Found", "No Item's", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _blnFound = true;
                    dgvOrders.DataSource = _dtProductTable;
                }
                _sqlResultsCommand.Dispose();
                _daProduct.Dispose();
                _dtProductTable.Dispose();


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
            }catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString(), "Error Out Of Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public static void GrabDiscounts(DataGridView dgvDiscount, string strQuery)
        {

            try
            {

                //establush command object
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                //establish data adapter
                _daDiscount = new SqlDataAdapter();
                _daDiscount.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtDiscount = new DataTable();
                _daDiscount.Fill(_dtDiscount);

                dgvDiscount.DataSource = _dtDiscount;

                _daDiscount.Dispose();
                _dtDiscount.Dispose();
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


        //Fuctions for Creating Information to pass into the database
        public static void CreateLogIn(TextBox tbxUsername, TextBox tbxPassword, ComboBox cmbSQuestion1, TextBox SQAnswer1, ComboBox cmbSQuestion2, TextBox SQAnswer2, ComboBox cmbSQuestion3 , TextBox SQAnswer3 ,String strQuery)
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
        public static void CreateInvoice(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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
        public static void CreateDiscount(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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
        public static void CreateSale(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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
        public static void CreateNewUser(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, TextBox tbxSuffix, TextBox tbxAddress1, TextBox tbxAddress2, TextBox tbxAddress3,
                                        TextBox tbxCity, TextBox tbxZipcode, ComboBox cbxState, TextBox tbxEmail, MaskedTextBox mtbPhonePrim, MaskedTextBox mtbPhoneSecon, string query)//Used To Create New User
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

            _sqlResultsCommand.Dispose();

        }
        public static void CreateProduct(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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

        


        //Funciton For When We Are Updating Information For Customer or Employee    
        public static void CustomerEdit(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, TextBox tbxSuffix, TextBox tbxAddress1, TextBox tbxAddress2, TextBox tbxAddress3,
                                        TextBox tbxCity, TextBox tbxZipcode, ComboBox cbxState, TextBox tbxEmail, MaskedTextBox mtbPhonePrim, MaskedTextBox mtbPhoneSecon)
        {
            try
            {
                string strQuery;
                //string to build query
                strQuery = "Select Title, NameFirst , NameMiddle , NameLast , Suffix , Address1 , Address2 , Address3 , City , Zipcode , State , Email , PhonePrimary , PhoneSecondary " +
                    "from OrtizB21Su2332.Person " +
                    "Where PersonID = " + _intPersonID;

                //est cmd obj
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //est data adapter
                _daPerson = new SqlDataAdapter();
                _daPerson.SelectCommand = _sqlResultsCommand;

                //Fill data table
                _dtPerson = new DataTable();
                _daPerson.Fill(_dtPerson);

                //bind controlls
                tbxTitle.DataBindings.Add("Text", _dtPerson, "Title");
                tbxFirstName.DataBindings.Add("Text", _dtPerson, "NameFirst");
                tbxMiddleName.DataBindings.Add("Text", _dtPerson, "NameMiddle");
                tbxLastName.DataBindings.Add("Text", _dtPerson, "NameLast");
                tbxSuffix.DataBindings.Add("Text", _dtPerson, "Suffix");
                tbxAddress1.DataBindings.Add("Text", _dtPerson, "Address1");
                tbxAddress2.DataBindings.Add("Text", _dtPerson, "Address2");
                tbxAddress3.DataBindings.Add("Text", _dtPerson, "Address3");
                tbxCity.DataBindings.Add("Text", _dtPerson, "City");
                tbxZipcode.DataBindings.Add("Text", _dtPerson, "Zipcode");
                cbxState.DataBindings.Add("Text", _dtPerson, "State");
                tbxEmail.DataBindings.Add("Text", _dtPerson, "Email");
                mtbPhonePrim.DataBindings.Add("Text", _dtPerson, "PhonePrimary");
                mtbPhoneSecon.DataBindings.Add("Text", _dtPerson, "PhoneSecondary");
                //cbxState.DataBindings.Add("Text", _dtPerson, "State");

                //Dispose Of Command Object
                _sqlResultsCommand.Dispose();
                _daPerson.Dispose();
                _dtPerson.Dispose();

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
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void EmployeeEdit(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, TextBox tbxSuffix, TextBox tbxAddress1, TextBox tbxAddress2, TextBox tbxAddress3,
                                       TextBox tbxCity, TextBox tbxZipcode, ComboBox cbxState, TextBox tbxEmail, MaskedTextBox mtbPhonePrim, MaskedTextBox mtbPhoneSecon)
        {
            try
            {
                string strQuery;
                //string to build query
                strQuery = "Select Title, NameFirst , NameMiddle , NameLast , Suffix , Address1 , Address2 , Address3 , City , Zipcode , State , Email , PhonePrimary , PhoneSecondary " +
                    "from OrtizB21Su2332.Person p inner join OrtizB21Su2332.Employees e on p.PersonID = e.PersonID " +
                    "Where e.EmployeeID = " + _intEmployeeID;

                //est cmd obj
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //est data adapter
                _daPerson = new SqlDataAdapter();
                _daPerson.SelectCommand = _sqlResultsCommand;

                //Fill data table
                _dtPerson = new DataTable();
                _daPerson.Fill(_dtPerson);

                //bind controlls
                tbxTitle.DataBindings.Add("Text", _dtPerson, "Title");
                tbxFirstName.DataBindings.Add("Text", _dtPerson, "NameFirst");
                tbxMiddleName.DataBindings.Add("Text", _dtPerson, "NameMiddle");
                tbxLastName.DataBindings.Add("Text", _dtPerson, "NameLast");
                tbxSuffix.DataBindings.Add("Text", _dtPerson, "Suffix");
                tbxAddress1.DataBindings.Add("Text", _dtPerson, "Address1");
                tbxAddress2.DataBindings.Add("Text", _dtPerson, "Address2");
                tbxAddress3.DataBindings.Add("Text", _dtPerson, "Address3");
                tbxCity.DataBindings.Add("Text", _dtPerson, "City");
                tbxZipcode.DataBindings.Add("Text", _dtPerson, "Zipcode");
                cbxState.DataBindings.Add("Text", _dtPerson, "State");
                tbxEmail.DataBindings.Add("Text", _dtPerson, "Email");
                mtbPhonePrim.DataBindings.Add("Text", _dtPerson, "PhonePrimary");
                mtbPhoneSecon.DataBindings.Add("Text", _dtPerson, "PhoneSecondary");
                //cbxState.DataBindings.Add("Text", _dtPerson, "State");

                //Dispose Of Command Object
                _sqlResultsCommand.Dispose();
                _daPerson.Dispose();
                _dtPerson.Dispose();


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
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        

        //Used for security Question To Check for Password
        public static void CheckPassword(string strQuery)
        {
            try
            {
                //Using the Sqlcommand we execute the Query
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                _sqlResultsCommand.ExecuteNonQuery();

                //establush command object
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                //establish data adapter
                _daLogOn = new SqlDataAdapter();
                _daLogOn.SelectCommand = _sqlResultsCommand;
                //fill data table
                _dtLogOn = new DataTable();
                _daLogOn.Fill(_dtLogOn);

                if (_dtLogOn.Rows.Count != 0)
                {
                    _blnFound = true;
                }
                else
                {
                    _blnFound = false;
                }

                //Dispose Of Command Object
                _sqlResultsCommand.Dispose();
                _daLogOn.Dispose();
                _dtLogOn.Dispose();
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


        //Update Functions that Update Stuff
        public static void UpdatePassword(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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
        public static void UpdateQuantity(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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
        public static void UpdateProduct(string strQuery)
        {
            try
            {

                //establish Command Object For This Function
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

        //Stuff to do with pictures such as upload to database and grab from database
        public static void UploadPicture(string imgLoc, string strQuery)
        {
            try
            {

                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);


                SqlCommand Insert = new SqlCommand(strQuery, _conDatabase);
                Insert.Parameters.Add(new SqlParameter("@img", img));
                int x = Insert.ExecuteNonQuery();
                //MessageBox.Show(x.ToString() + "record(s) saved.");

                Insert.Dispose();
                fs.Dispose();
                br.Dispose();

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
        public static void GrabPicture(PictureBox pbxBox, string strQuery)
        {
            try
            {
                //strQuery = "Select Image from OrtizB21Su2332.Picture where Number = " + tbxID.Text;
                SqlCommand Grab = new SqlCommand(strQuery, _conDatabase);
                SqlDataReader Reader = Grab.ExecuteReader();
                Reader.Read();
                if (Reader.HasRows && Reader["Image"] != System.DBNull.Value)
                {                  
                    byte[] img = (byte[])(Reader[0]);
                    if (img == null)
                    {
                        pbxBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pbxBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbxBox.Image = Properties.Resources.Logo_SMS;
                    //MessageBox.Show("No Image");
                }
                Grab.Dispose();
                Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }

}

