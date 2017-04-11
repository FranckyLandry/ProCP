using System;
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


namespace WindowsFormsApplication1
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
            try
            {
                string tagnumber = e.Tag.ToString();
                lbl_RFID_Show.Text = tagnumber;

                List<string>[] myArrayList = databseHelper.Select(tagnumber);

                List<string> names = myArrayList[0];
                List<string> money = myArrayList[1];
                List<string> status = myArrayList[2];

                if (names.Count == 0)
                {
                    lbl_RFID_Show.Text = "Invalid rfid";
                    lbl_Name.Text = "UNKNOWN";
                    lbl_Money.Text = "";
                    Check_msg.Text = "";
                    MessageBox.Show("Please see our client service", "MESSAGE");
                    Console.Beep();
                }
                else
                {
                    bool test = true;
                    foreach (string s in names)
                    {
                        if (names != null)
                            lbl_Name.Text = s;
                        else
                            lbl_Name.Text = "UNKNOWN";
                        lbl_Money.Text = "";
                        Check_msg.Text = "";
                    }

                    foreach (string m in money)
                    {
                        if (Convert.ToDecimal(m) < 35)
                        {
                            lbl_Money.Text = m;
                            Check_msg.Text = "";

                            MessageBox.Show("Amount: " + m + "\nNot all full amount has been paid");


                            test = false;
                            break;
                        }
                        else
                            lbl_Money.Text = m;

                    }

                    if (test)
                    {
                        databseHelper.Update(tagnumber);
                        foreach (string st in status)
                        {
                            if (st == "In")
                                Check_msg.Text = "Check out";
                            else if (st == "Out")
                                Check_msg.Text = "Check In";

                        }
                    }
                    else
                        Check_msg.Text = "";
                    Console.Beep();
                }

            }
            catch (FormatException ex) { MessageBox.Show(ex.Message); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("WELCOME TO THE MULTICULTURAL EVENT..... ");

            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                rfid.LED = false;
                rfid.Antenna = false;
                lbl_RFID_Show.Text = "";
                Check_msg.Text = "";
                MessageBox.Show("GOOD BYE!!");
                rfid.close();

            }
            catch (PhidgetException) { MessageBox.Show(" RFID-reader not Closed."); }
        }
    }


}

