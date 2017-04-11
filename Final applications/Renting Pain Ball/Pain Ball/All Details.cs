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
    public partial class All_Details : Form
    {
        RFID rfid;
        string formatForMySql;
        private int currency;
        public int Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public int Quantity { get; set; }
        DateTime StartTime = DateTime.Now;
        public string Type { get; set; }
        public bool MyRadiobutton { get; set; }
        string rfid_number;
        //  int remaining_number;
        public All_Details()
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
            lbRifdShow.Text = rfid_number;
            Console.Beep();
            MySqlException error = null;
            DatabaseConnection.ConnectToDB(ref error);

            double money;

            string Client_detail = DatabaseConnection.GetClientDetail(rfid_number, out money);
            lbl_Name_Show.Text = Client_detail;
            lbAmountShow.Text = money.ToString();
            lbl_Amount_Show.Text = Currency.ToString();
            btn_OK.Enabled = true;
            btn_Close.Enabled = true;
            btn_Cancel.Enabled = true;

        }

        private void All_Details_Load(object sender, EventArgs e)
        {
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("Scanner Start Working\n You May scan");
                btn_OK.Enabled = false;
                btn_Cancel.Enabled = false;
                btn_Close.Enabled = false;


            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void All_Details_Deactivate(object sender, EventArgs e)
        {
            try
            {
                rfid.LED = false;
                rfid.Antenna = false;
                MessageBox.Show("GOOD BYE!!!");
                rfid.close();

            }
            catch (PhidgetException) { MessageBox.Show(" RFID-reader not Closed."); }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            btn_Cancel.Enabled = false;
            int value = Convert.ToInt32(lbAmountShow.Text) - Convert.ToInt32(Currency);
            lbl_Amount_Paid.Text = "Note:";
            lbl_Amount_Show.Text = "Amount Paid";
            String connectionInfo = "Server=athena01.fhict.local;" +
                                 "Database=dbi297937;" +
                                 "user id=dbi297937;" +
                                 "Password=xdl2xDpHkC;" +
                                 "connect timeout=30;";

            //update event_visitors table.....
            MySqlConnection connection = new MySqlConnection(connectionInfo);

            //update event_visitors table
            string Query = "Update event_visitors SET RFIDMoney='" + value + "' where RFID_Nr='" + rfid_number + "' ";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, connection);
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
                lbAmountShow.Text = value.ToString();
                formatForMySql = StartTime.ToString("yyyy-MM-dd HH:mm:ss");
                lbl_Start_Time.Text = StartTime.ToString();
                btn_OK.Enabled = false;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (MyRadiobutton == true)
            {

                //insert in Paint_BAll_Game table
                // MySqlConnection connection1 = new MySqlConnection(connectionInfo);
                connection.Open();

                string NewQuery = " Insert into renting_paint_ball_game (Start_Time_Of_Renting_Suite,Gun_Set_Nr,Amount_Paid,Own_Suite,RFID_Nr) values('" + formatForMySql + "','" + Quantity + "','" + Currency.ToString() + "','" + Type + "','" + rfid_number.ToString() + "')";
                MySqlCommand cmdDataBase1 = new MySqlCommand(NewQuery, connection);

                cmdDataBase1.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                //insert in Paint_BAll_Game table
                connection.Open();
                string NewQuery = " Insert into renting_paint_ball_game (Start_Time_Of_Renting_Suite,Amount_Paid,Own_Suite,Number_Of_Suite,RFID_Nr) values('" + formatForMySql + "','" + Currency.ToString() + "','" + Type + "','" + Quantity + "','" + rfid_number.ToString() + "')";
                MySqlCommand cmdDataBase1 = new MySqlCommand(NewQuery, connection);

                cmdDataBase1.ExecuteNonQuery();


                connection.Close();

            }
            btn_OK.Enabled = false;

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            All_Details.ActiveForm.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            All_Details.ActiveForm.Close();
        }

        private void lbl_Amount_Show_Click(object sender, EventArgs e)
        {

        }
    }
}
