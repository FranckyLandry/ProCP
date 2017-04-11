using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

namespace Paint_Ball_Details
{
    
     static  public class DatabaseConnection
    {      
         
      static String connectionInfo ="Server=athena01.fhict.local;" +
                                 "Database=dbi297937;" +
                                 "user id=dbi297937;" +
                                 "Password=xdl2xDpHkC;" +
                                 "connect timeout=30;";
      static MySqlConnection connection=new MySqlConnection(connectionInfo);
      static MySqlDataReader reader = null;
       
       static public bool ConnectToDB(ref MySqlException error)
        {
            try 
            {                
                connection.Open();
                return true;
                }
                catch (MySqlException err)
                {
                    error = err;
                    return false;
                   
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (connection != null)
                    {
                        connection.Close();
                    }
            
            }
        }

         //for entrance app........................................................................................
      static  public List<string>[] GetClientDetail(string tag_number,  double money)
       {
           //string name = "";
           //money = 0;

           List<string>[] listTest = new List<string>[2];

           listTest[0] = new List<string>();
           listTest[1] = new List<string>();

           MySqlException error = null;
           ConnectToDB(ref error);
           if (error == null)
           {
               connection.Open();
               string clientInfo = " Select  Client_First_Name,RFIDMoney from event_visitors where RFID_Nr='" + tag_number + "'";
               MySqlCommand cmd = new MySqlCommand(clientInfo, connection);
               reader = cmd.ExecuteReader();
               while (reader.Read())
               {

                   listTest[0].Add(reader["Client_First_Name"] + "");
                   listTest[1].Add(reader["Client_First_Name"] + "");
                  
                   //name = reader.GetString(0);
                   //money = Convert.ToDouble(reader.GetString(1));
               }
               connection.Close();
             
           }
           return listTest;
          
       }

    }
    

}
