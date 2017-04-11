using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;//to be abble to store files
using System.Diagnostics;// to be abble to use ProcessStartInfo

namespace/* WindowsFormsApplication1*/GUI2
{
    class DatabaseHelper 
    {
        ClientInfo c;
        private int totalAmount=0;
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

        public override string ToString()
        {
            
            return base.ToString();
        }

        //Insert statement
        public void Insert(string rfidFields, string dateUpload,string amount, string eventA, string dateEnd)
        {
            string query = "INSERT INTO logfilepaypal(RFID_Nr,DateAndTime_file_upload,Amount,Event_Account,DateAndTim_file_end) VALUE('" +rfidFields + "','" + dateUpload + "','"+Convert.ToInt32(amount) + "','" + eventA + "','" + dateEnd + "')";
            /*query += rfidFields + "','" + dateUpload + "','"+amount + "','" + eventA + "','" + dateEnd + "'";*/
            //INSERT INTO logfilepaypal(RFID_Nr,DateAndTime_file_upload,Amount,Event_Account,DateAndTim_file_end) VALUES('2300fb4525','2014-10-07 16:13:03',1000,'fontys12345','2014-11-07 16:14:25');




            //c = new ClientInfo(rfidFields, dateUpload, amount, eventA, dateEnd);
            //string query = c.ToString();
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                //Used to execute a command that will not return any data, for example Insert, update or delete.
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }


        public int CheckTransfert(string tagNumber)
        {
            string query = "Select Amount from LogfilePayPal where RFID_Nr='" + tagNumber + "'";
            List<string>[] Amountlist = new List<string>[1];
            Amountlist[0] = new List<string>();

            List<string> resulAmount = new List<string>();

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
                    Amountlist[0].Add(dataReader["Amount"] + "");
                    resulAmount = Amountlist[0];
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }

            foreach (string a_mount in resulAmount)
            {
                totalAmount = Convert.ToInt32(a_mount);
               
            }
            return totalAmount;

        }
        //Update statement
        /// <summary>
        /// first send money from client account to event account
        ///  
        /// </summary>
        /// <param name="money"></param>
        /// <param name="tagNumber"></param>
        public void Transfert( string tagNumber,int amount)
        {
            CheckTransfert(tagNumber);
            amount += totalAmount;
            //string query = "this is an example: UPDATE tableinfo SET name='', age='' WHERE name=''";
            string query = "Update money_transfer  set Amount ='" + amount + "' where RFID_Nr='" + tagNumber + "'";

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


        public void TransfertToRFID(string tagNumber)
        {


            //string query = "this is an example: UPDATE tableinfo SET name='', age='' WHERE name=''";
            string query = "Update event_visitors  set RFIDMoney ='" + totalAmount + "' where RFID_Nr='" + tagNumber + "'";

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


        //Delete statement
        //public void Delete()
        //{
        //    string query = "DELETE FROM tableinfo WHERE name=''";

        //    if (this.OpenConnection() == true)
        //    {
        //        MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //        this.CloseConnection();
        //    }
        //}

        //Select statement Q??if we have 6000 people  
        public List<string>[] Select(string tagNumber)
        {

            string query = "Select  Client_First_Name,RFIDMoney,Client_Bank_Account from event_visitors where RFID_Nr='" + tagNumber + "'";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            // list[2] = new List<string>();

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

                    list[0].Add(dataReader["Client_First_Name"] + "");
                    list[1].Add(dataReader["RFIDMoney"] + "");
                    list[2].Add(dataReader["Client_Bank_Account"] + "");

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

        //Count statement
     /*   public int Count()
        {

            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
      */

        //Backup
      /*  public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
                         "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);

                //Initializes a new instance of the ProcessStartInfo class and specifies a 
                // file name such as an application or document with which to start the process.
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                                 uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
       * */
    }
}
