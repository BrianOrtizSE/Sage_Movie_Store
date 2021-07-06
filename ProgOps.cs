﻿using System;
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

        //Information for Discount Table
        private static SqlDataAdapter _daDiscount = new SqlDataAdapter();
        private static DataTable _dtDiscount = new DataTable();

        //Function To Get Product Tabled
        public static DataTable GetProductTable
        {
            //Return the product table when called
            get { return _dtProductTable; }
        }

        //INT FOR PICTURE CASES
        public static int _PICTURE;

        //TAX FOR WHOLE PROJECT:
        public static decimal _TAX = 0.0825M;

        //Int for PersonID
        public static int intPersonID;
        public static int intQuantity;

        public static decimal decDiscountPercent = 0.0m;
        public static int intProductID = 0;

        //Bool If Person Was Found
        public static bool blnFound;
        public static bool blnDiscountFound;


        //Strinbuilder for error messages in the trycatch
        private static StringBuilder errorMessages = new StringBuilder();
        public static void OpenDatabase()
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
        public static void LogOn(TextBox tbxUsername, TextBox tbxPassword, RadioButton rdButtonA, RadioButton rdButtonB, String query)
        {
            //used to search for specific user

            try
            {
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
                    blnFound = true;
                }
                else
                {
                    blnFound = false;
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



        }
        public static void CreateNewUser(TextBox tbxTitle, TextBox tbxFirstName, TextBox tbxMiddleName, TextBox tbxLastName, TextBox tbxSuffix, TextBox tbxAddress1, TextBox tbxAddress2, TextBox tbxAddress3,
                                        TextBox tbxCity, TextBox tbxZipcode, ComboBox cbxState, TextBox tbxEmail, MaskedTextBox mtbPhonePrim, MaskedTextBox mtbPhoneSecon, string query)
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
            try
            {
                //Grab the newst PersonID that was just creted used for Security Question 
                String query = "Select PersonID From OrtizB21Su2332.Person Order by PersonID desc";

                _sqlResultsCommand = new SqlCommand(query, _conDatabase);

                //Grab PersonID so we can cretae LogIn Info
                intPersonID = (int)_sqlResultsCommand.ExecuteScalar();
            }
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        public static void GrabPersonInfo(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //Grab PersonID so we can cretae LogIn Info
                intPersonID = (int)_sqlResultsCommand.ExecuteScalar();
            }           
            catch (InvalidCastException)
            {

                MessageBox.Show("Error Invalid Cast", "Error on DatabaseCommand", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public static void GrabAmount(string strQuery)
        {
            try
            {
                //Use this Function To Grab Person ID whenever this is called
                _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);

                //Grab PersonID so we can cretae LogIn Info
                intQuantity = (int)_sqlResultsCommand.ExecuteScalar();
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
        public static void GrabProduct(TextBox tbxProductID, DataGridView dgvOrders, String strQuery)
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
                dgvOrders.DataSource = _dtProductTable;
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
        public static void ProductView(TextBox tbxProductID, TextBox ProductName, TextBox tbxGenre, TextBox tbxQuanity, TextBox tbxPrice, TextBox tbxDescription, CheckBox chxInStock)
        {
            //string to build query
            string query = "select * From OrtizB21Su2332.Products ORDER BY ProductID";

            //est cmd obj
            _sqlResultsCommand = new SqlCommand(query, _conDatabase);

            //est data adapter
            _daProduct = new SqlDataAdapter();
            _daProduct.SelectCommand = _sqlResultsCommand;

            //fill data table
            _dtProductTable = new DataTable();
            _daProduct.Fill(_dtProductTable);

            //bind to controls to data table
            tbxProductID.DataBindings.Add("Text", _dtProductTable, "ProductID");
            ProductName.DataBindings.Add("Text", _dtProductTable, "ProductName");
            tbxGenre.DataBindings.Add("Text", _dtProductTable, "Genre");
            tbxQuanity.DataBindings.Add("Text", _dtProductTable, "Quantity");
            tbxPrice.DataBindings.Add("Text", _dtProductTable, "ProductPrice");
            tbxDescription.DataBindings.Add("Text", _dtProductTable, "ProductDescription");
            chxInStock.DataBindings.Add("Checked", _dtProductTable, "inStock");

        }
        public static void ProductAddEdit(TextBox tbxProductName, TextBox tbxGenre, TextBox tbxQuanity, TextBox tbxPrice, TextBox tbxDescription, int blnInStock, String query)
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
                    MessageBox.Show(errorMessages.ToString(), "Error on Merchandise Update On Close",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void ProductDispose()
        {
            //dispose of connection objects
            _sqlResultsCommand.Dispose();
            _daProduct.Dispose();
            _dtProductTable.Dispose();
        }
        public static void GetDiscountID(TextBox tbxDiscountCode)
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
                    blnDiscountFound = true;
                    GetDiscountInformation(tbxDiscountCode);
                }
                else
                {
                    blnDiscountFound = false;
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
        //used to check for product discount vs whole sale discount
        public static void GetDiscountInformation(TextBox tbxDiscountCode)
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
                        decDiscountPercent = (decimal)_sqlResultsCommand.ExecuteScalar();
                        break;

                    case 2: //For Type 2 Discount that need a specific item in their to use
                        strQuery = "Select DiscountPercent from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;

                        _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                        decDiscountPercent = (decimal)_sqlResultsCommand.ExecuteScalar();

                        strQuery = "Select ProductID from OrtizB21Su2332.Discount where DiscountID = " + tbxDiscountCode.Text;
                        _sqlResultsCommand = new SqlCommand(strQuery, _conDatabase);
                        intProductID = (int)_sqlResultsCommand.ExecuteScalar();
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

        public static void GetPassword(TextBox tbxUsername , ComboBox cmbSQ , String query)
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
                    blnFound = true;
                }
                else
                {
                    blnFound = false;
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
        }

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

    }

}

