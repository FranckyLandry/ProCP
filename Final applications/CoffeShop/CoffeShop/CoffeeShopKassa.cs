﻿using System;
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

namespace CoffeShop
{
    public partial class CoffeeShopKassa : Form
    {
        string Client_detail;
        string formatForMySql;
        DateTime StartTime = DateTime.Now;
        RFID rfid;
        public int Weight { get; set; }
        public string Type { get; set; }
        private int currency;
        public int Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        string rfid_number;
        public CoffeeShopKassa()
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
            btClose.Visible = true;
        }


        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            btOK.Visible = true;
            btClose.Visible = true;
            btCancel.Visible = true;

            rfid_number = e.Tag.ToString();
            lbRFIDNR.Text = rfid_number;
            Console.Beep();
            MySqlException error = null;
            DatabaseConnection.ConnectToDB(ref error);

            double money;
            //databse for client name and money..........
            Client_detail = DatabaseConnection.GetClientDetail(rfid_number, out money);
            if (Client_detail == null)
            {
                lbl_Person_Name.Text = "Unknown";
                lbTotalAmountShow.Text = "Unknown";
                lbl_Money.Text = "Unknown";
            }
            else
            {
                lbl_Person_Name.Text = Client_detail;
                lbTotalAmountShow.Text = money.ToString();
                lbl_Money.Text = Currency.ToString();
                if (error != null)
                {
                    switch (error.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Contact administrator");
                            break;
                        case 1042:
                            MessageBox.Show("Cannot connect to server. Contact administrator. \nThe program will not work unless conected to the database.");
                            break;
                        case 1045:
                            MessageBox.Show("Invalid user/password");
                            break;
                        default:
                            MessageBox.Show("" + error.Number + " " + error.Message);
                            break;

                    }
                }
            }

        }


        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoffeeShopKassa_Load(object sender, EventArgs e)
        {
            btOK.Visible = false;
            btClose.Visible = false;
            btCancel.Visible = false;

            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("WELCOME TO THE BALIE!\n You may scan");


            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void CoffeeShopKassa_Deactivate(object sender, EventArgs e)
        {
            try
            {
                rfid.LED = false;
                rfid.Antenna = false;
                MessageBox.Show("GOOD BYE!");
                rfid.close();

            }
            catch (PhidgetException) { MessageBox.Show(" RFID-reader not Closed."); }
        }

        private void btOK_Click_1(object sender, EventArgs e)
        {

            btCancel.Enabled = false;
            formatForMySql = StartTime.ToString("yyyy-MM-dd HH:mm:ss");

            int value = Convert.ToInt32(lbTotalAmountShow.Text) - Convert.ToInt32(Currency);

            lbl_amount_to_pay.Text = "Note:";
            lbl_Money.Text = "Amount Paid";
            btOK.Enabled = false;

            //for new connection............................................................
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
                lbTotalAmountShow.Text = value.ToString();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //insert in Coffie shop table

            connection.Open();
            string NewQuery = " Insert into coffee_shop (RFID_Nr,Time,Type,Weight,Amount_Paid,Name) values('" + lbRFIDNR.Text + "','" + formatForMySql + "','" + Type + "','" + Weight.ToString() + "','" + value.ToString() + "','" + lbl_Person_Name.Text + "')";//+@RFID_Nr','@Type','@Weight','@Amount_Paid','@Name') ";
            MySqlCommand cmdDataBase1 = new MySqlCommand(NewQuery, connection);
            cmdDataBase1.ExecuteNonQuery();
            connection.Close();

        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {
            CoffeeShopKassa.ActiveForm.Close();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            CoffeeShopKassa.ActiveForm.Close();

        }
    }
}
