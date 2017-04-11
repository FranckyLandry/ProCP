using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;//to be abble to store files
using System.Diagnostics;// to be abble to use ProcessStartInfo

namespace Management
{
    class DatabaseHelper
    {

       // private string status;
        private MySqlConnection connection=null;//will be used to open a connection to the database.
        private string server;//indicates where our server is hosted, in our case, it's athenaserver
        private string database;//is the name of the database we will use, in our case it's the database we already created 
        private string uid;//is our MySQL username.
        private string password;//is our MySQL password.
       // List<Restaurant> restaurantList = new List<Restaurant>();
        //Constructor
        public DatabaseHelper()
        {
            CreateOpen();
        }

        //Initialize values
        private void CreateOpen()
        {
            server = "athena01.fhict.local;";
            database = "dbi297937";
            uid = "dbi297937";
            password = "xdl2xDpHkC";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password;

            this.connection = new MySqlConnection(connectionString);
            if (this.connection != null)
            {
                this.connection.Open();

            }
        }
   
        //Close connection
        private bool CloseConnection()
        {
            try
            {
                if (this.connection != null)
                {
                    this.connection.Close();
                    this.connection = null;
                    return true;
                }
                else
                    return false;
            
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        public List<string>[] selectYpeOfFood(string typeofFood)
        {
            string query = "Select Remaining_Number from multicultural_resturant where Type_Of_Food='" + typeofFood + "'";

            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();



            this.CreateOpen();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                list[0].Add(dataReader["Remaining_Number"] + "");
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;

        }
        
        public List<string>[] SelectAll(string stallName)
        {
            string query = "Select Remaining_Number,Type_Of_Food,Total_Stock,Food_Price from multicultural_resturant where Stall_Name='" + stallName + "'";

            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            //list[4] = new List<string>();
            
           
            this.CreateOpen();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                list[0].Add(dataReader["Remaining_Number"] + "");
                list[1].Add(dataReader["Type_Of_Food"] + "");
                list[2].Add(dataReader["Total_Stock"] + "");
                list[3].Add(dataReader["Food_Price"] + "");
               // list[4].Add(dataReader["Total_Earned"] + "");
                

            }
          
            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();
          
            //return list to be displayed
            return list;


        }

        public void setRemainStock(int remStock, string stalname,string nameFood)
        {
            string query = "UPDATE multicultural_resturant SET Remaining_Number='" + remStock + "'where Stall_Name='" + stalname + "' and Type_Of_Food='"+nameFood+"'";
            this.CreateOpen();

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

        public void SetAfterTransaction(decimal remainMoney,string saverfid)
        {
            string query = "UPDATE event_visitors SET RFIDMoney ='" + remainMoney + "' where RFID_Nr = '" + saverfid + "'";
           
            this.CreateOpen();
        
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

        public List<string>[] Payments(string tagNumber)
        {
            string query = "Select  RFIDMoney from event_visitors where RFID_Nr='" + tagNumber + "'";

            //Create a list to store the result
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();
            
            this.CreateOpen();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                
                list[0].Add(dataReader["RFIDMoney"] + "");
            }
     
            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();
        
            return list;
           
        }
          
        public List<string>[] Select(string tagNumber)
            {

            string query = "Select  Client_First_Name,RFIDMoney from event_visitors where RFID_Nr='" + tagNumber + "'";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
           

           
                this.CreateOpen();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    /*list[0].Add(dataReader["RFID_Nr"] + "");*/
                    list[0].Add(dataReader["Client_First_Name"] + "");
                    list[1].Add(dataReader["RFIDMoney"] + "");
                  

                }
               

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
         
        }

    }
}
