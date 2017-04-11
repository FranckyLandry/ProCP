﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace Camping
{
    public partial class Form1 : Form
    {
        RFID rfid;
        DatabaseHelper databseHelper;

        public Form1()
        {

            InitializeComponent();

            databseHelper = new DatabaseHelper();

            try
            {
                rfid = new RFID();
                rfid.Attach += new AttachEventHandler(ShowWhoIsAttached);
                rfid.Detach += new DetachEventHandler(ShowWhoIsDetached);
                rfid.Tag += new TagEventHandler(ProcessThisTag);
                lbl_Message.Text = "waiting for attachment";

            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }
        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            lbl_Message.Text = "RFID Reader attached!," + e.Device.SerialNumber; ;


        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            lbl_Message.Text = "RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString();
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            lbGroupMember.Items.Clear();
            listBox1.Items.Clear();
            string tagnumber = e.Tag.ToString();

            lbGroupLeaderRFID.Text = tagnumber;

            List<string>[] myArrayList = databseHelper.Select(tagnumber);
            List<string>[] myMembers = databseHelper.Members(tagnumber);

            List<string> membersList = myMembers[0];

            foreach (string member in membersList)
            {
                listBox1.Items.Add(member);
            }

            List<string> names = myArrayList[0];

            List<string> chekingList = myArrayList[1];
            List<string> status = myArrayList[2];
            List<string> siteNber = myArrayList[3];

            foreach (string item in names)
            {
                lbGroupMember.Items.Add(item);
                databseHelper.Update(tagnumber);

            }

            foreach (string item in chekingList)
            {

                tbGroupLeaderName.Text = item;


            }



            foreach (string st in status)
            {
                if (st == "Non")
                    Check_msg.Text = "Check in";
                if (st == "In")
                    Check_msg.Text = "Check out";
                else if (st == "Out")
                    Check_msg.Text = "Check In";

            }

            foreach (string nber in siteNber)
            {
                lbSiteNumberShow.Text = nber;
            }

            Console.Beep();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("WELCOME TO CAMPING SITE!");

            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                rfid.LED = false;
                rfid.Antenna = false;
               
                Check_msg.Text = "";
                MessageBox.Show("GOOD BYE!!");
                rfid.close();

            }
            catch (PhidgetException) { MessageBox.Show(" RFID-reader not Closed."); }
        }
    }
}


