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
        //Int for PersonID
        public static int intPersonID;

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
                "And Password = '" + tbxPassword.Text + "';";
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
            }
            else
                MessageBox.Show("User Was Not Found");

        }

    }
}
