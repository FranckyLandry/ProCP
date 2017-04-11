﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

namespace Pain_Ball
{
    
       public static class DatabaseConnection
    {      
         
      static String connectionInfo ="Server=athena01.fhict.local;" +
                                 "Database=dbi297937;" +
                                 "user id=dbi297937;" +
                                 "Password=xdl2xDpHkC;" +
                                 "connect timeout=30;";
      static MySqlConnection connection=new MySqlConnection(connectionInfo);
      static MySqlDataReader reader = null;
       
        public static bool ConnectToDB(ref MySqlException error)
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

         //for coffie shop app........................................................................................
        public static string GetClientDetail(string tag_number, out double money)
       {
           string name = "";
           money = 0;
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
                   name = reader.GetString(0);
                   money = Convert.ToDouble(reader.GetString(1));
               }
               connection.Close();
               
           }
           return name;
       }

      

    }
    

}
