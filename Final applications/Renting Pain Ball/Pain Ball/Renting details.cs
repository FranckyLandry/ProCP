using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

namespace Pain_Ball
{
    public partial class Renting_details : Form
    {
        RFID rfid;
        string rfid_number;
        DateTime datetime = DateTime.Now;
        string formatForMySql;

        public Renting_details()
        {
            InitializeComponent();
            try
            {

                rfid = new RFID();
                rfid.Tag += new TagEventHandler(ProcessThisTag);
            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }
        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            rfid_number = e.Tag.ToString();
            lbl_RFID_Show.Text = rfid_number;
            Console.Beep();
            MySqlException error = null;
            DatabaseConnection.ConnectToDB(ref error);

            double money;

            string Client_detail = DatabaseConnection.GetClientDetail(rfid_number, out money);
            lbl_Name_Show.Text = Client_detail;
            btn_OK.Enabled = true;
            btn_Close.Enabled = true;

        }

        private void Renting_details_Load(object sender, EventArgs e)
        {
            btn_OK.Enabled = false;
            btn_Close.Enabled = false;
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("WELCOME BACK .\n  You may scan to return your stuffs!");
                String connectionInfo = "Server=athena01.fhict.local;" +
                                "Database=dbi297937;" +
                                "user id=dbi297937;" +
                                "Password=xdl2xDpHkC;" +
                                "connect timeout=30;";

                //update event_visitors table.....
                MySqlConnection connection = new MySqlConnection(connectionInfo);



                try
                {
                    connection.Open();

                    lbl_RFID_Show.Text = rfid_number;
                    formatForMySql = datetime.ToString("yyyy-MM-dd HH:mm:ss");
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void Renting_details_Deactivate(object sender, EventArgs e)
        {
            try
            {
                rfid.LED = false;
                rfid.Antenna = false;

                MessageBox.Show("GOOD BYE!!");
                rfid.close();

            }
            catch (PhidgetException) { MessageBox.Show(" RFID-reader not Closed."); }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            lbl_End_Time.Text = datetime.ToString();
            String connectionInfo = "Server=athena01.fhict.local;" +
                                 "Database=dbi297937;" +
                                 "user id=dbi297937;" +
                                 "Password=xdl2xDpHkC;" +
                                 "connect timeout=30;";

            //update event_visitors table.....
            MySqlConnection connection = new MySqlConnection(connectionInfo);

            //Insert event_visitors table
            string Query = "Update renting_paint_ball_game SET End_Time='" + formatForMySql + "' where RFID_Nr='" + rfid_number + "' ";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;


            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
                btn_OK.Enabled = true;

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Renting_details.ActiveForm.Close();
        }
    }
}
