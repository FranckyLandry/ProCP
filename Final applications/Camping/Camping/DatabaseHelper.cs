using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;//to be abble to store files
using System.Diagnostics;// to be abble to use ProcessStartInfo

namespace Camping
{
    class DatabaseHelper
    {

        private string status;
        private MySqlConnection connection;//will be used to open a connection to the database.
        private string server;//indicates where our server is hosted, in our case, it's athenaserver
        private string database;//is the name of the database we will use, in our case it's the database we already created 
        private string uid;//is our MySQL username.
        private string password;//is our MySQL password.

        //Constructor
        public DatabaseHelper()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "athena01.fhict.local;";
            database = "dbi297937";
            uid = "dbi297937";
            password = "xdl2xDpHkC";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password;

            connection = new MySqlConnection(connectionString);
            // OpenConnection();
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, we want our application's to response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("Check the connection");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public void CheckUpdate(string tagnumber)
        {
            List<string>[] checkList = new List<string>[1];
            checkList[0] = new List<string>();
            List<string> statuslist = new List<string>();


            string query = "Select Camping_Status from campings where GroupMember_RFID='" + tagnumber + "'"; /*+ "' or GroupMember_RFID = '" + tagnumber + "'";*/
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    checkList[0].Add(dataReader["Camping_Status"] + "");
                    statuslist = checkList[0];
                }

                dataReader.Close();
                this.CloseConnection();

                foreach (string s in statuslist)
                {
                    if (s == "Non")
                    {
                        status = "In";
                    }
                    if (s == "In")
                    {
                        status = "Out";

                    }
                    else if (s == "Out")
                    {
                        status = "In";
                    }

                }

            }

        }


        //Update statement
        public void Update(string tagNumber)
        {


            CheckUpdate(tagNumber);

            string query = "UPDATE campings SET Camping_Status ='" + status + "' where GroupMember_RFID = '" + tagNumber + "'";/*+ "' or GroupMember_RFID = '" + tagNumber + "'";*/

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                //Used to execute a command that will not return any data, for example Insert, update or delete.
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }



        public List<string>[] Select(string tagNumber)
        {
            string query = "Select  Group_Member,Group_Leader,Camping_Status,Camping_site_Nr from campings where GroupMember_RFID='" + tagNumber + "'";/*+ "' or GroupMember_RFID = '" + tagNumber + "'";*/
            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    list[0].Add(dataReader["Group_Member"] + "");
                    list[1].Add(dataReader["Group_Leader"] + "");
                    list[2].Add(dataReader["Camping_Status"] + "");
                    list[3].Add(dataReader["Camping_site_Nr"] + "");

                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] Members(string tagNumber)
        {
            string query = "Select  Group_Member from campings where RFID_Leader='" + tagNumber + "'";/*+ "' or GroupMember_RFID = '" + tagNumber + "'";*/
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Group_Member"] + "");

                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }

        }


    }
}
