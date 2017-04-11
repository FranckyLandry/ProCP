using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets.Events;
using Phidgets;
using System.IO;

namespace GUI2
{
    public partial class Form1 : Form
    {
        DatabaseHelper databseHelper;
        RFID rfid;
        List<ClientInfo> clientList;
        ClientInfo c;
        string tagnumber = "";
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 6;
            databseHelper = new DatabaseHelper();
            
            clientList = new List<ClientInfo>();
            //btTransHistory.Visible = false;

            //btCreditRFID.Visible = false;

            //richthistory.Visible = false;
            //lbEnterAmount.Visible = false;
            //tbEnterMoney.Visible = false;

            try
            {
                rfid = new RFID();
                rfid.Attach += new AttachEventHandler(ShowWhoIsAttached);
                rfid.Detach += new DetachEventHandler(ShowWhoIsDetached);
                rfid.Tag += new TagEventHandler(ProcessThisTag);


            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }
        }

        

        /// <summary>
        /// Method wich Load the LogfilePaypal
        /// </summary>
        /// <param name="filename"></param>
        private bool LoadClientInfo(string filename)
        {
          
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                string eventAccount, rfidFieldsAmounts = ""; 
                string dateUpload="" ; string dateEnd="" ;
                string  storeAmount="";
                string sStart = "";
                string sEnd = "";
              //  List<int>[] amountList = new List<int>[1000];
                // read the event account(first line)
              
                
             
                eventAccount = sr.ReadLine();
               // string splitRfidAndAmount = "";
                while (eventAccount!= null)
                {
                    // read the date (second line)
                    sStart = sr.ReadLine();
                    if (sStart != null)
                    {
                        // split it in year,month and day
                        string[] lineStart = sStart.Split('/');
                        string yearStart = lineStart[0];
                        string monthStart = lineStart[1];
                        string daysStart = lineStart[2];
                        string timeStart = lineStart[3];
                        //string fuldate = new DateTime(yearStart, monthStart, daysStart);
                        //fuldate.ToString("yyyy-MM-dd");
                        //dateUpload = fuldate;
                        string fullStartDate = yearStart + "-" + monthStart + "-" + daysStart + " " + timeStart;
                        dateUpload = fullStartDate;
                   }
                    //reading the second date(third line)
                    sEnd = sr.ReadLine();
                    if (sEnd != null)
                    {
                       
                        //  split it in year,month and day
                        string[] lineEnd = sEnd.Split('/');
                        string yearEnd = lineEnd[0];
                        string monthEnd = lineEnd[1];
                        string daysEnd = lineEnd[2];
                        string timeEnd = lineEnd[3];
                      //  DateTime fullEndDate = new DateTime(yearEnd, monthEnd, daysEnd);
                        string fullEnddate = yearEnd + "-" + monthEnd + "-" + daysEnd + " " + timeEnd;
                        //'2300fb4525','2014-10-07 16:13:03',1000,'fontys12345','2014-11-07 16:14:25');
                        dateEnd = fullEnddate;
                       // dateEnd = fullEndDate;
                       
                        //read the rfids and the amounts 
                        
                        //checking if 
                        while (rfidFieldsAmounts !=null)
                        {
                            rfidFieldsAmounts = sr.ReadLine();
                            if (rfidFieldsAmounts == "")
                            {
                                break;
                            }
                            string[] line = rfidFieldsAmounts.Split(' ');
                         
                          rfidFieldsAmounts=line[0];
                          storeAmount =line[1];
                                /*
                                 *  test to see if I am reading the file
                                 */
                              
                                databseHelper.Insert( rfidFieldsAmounts, dateUpload, storeAmount, eventAccount, dateEnd);
                              
                            }
                        }
                       

                    
                        break;

                    }
                c = new ClientInfo(rfidFieldsAmounts, dateUpload, storeAmount, eventAccount, dateEnd);
                        return true;
                    
                    
                }
              

           
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Dispose();
            }
            return true;

        }


        private void lbFullName_Click(object sender, EventArgs e)
        {

        }

        private void btCreditRFID_Click(object sender, EventArgs e)
        {

            int result = 0;
            bool input = Int32.TryParse(tbEnterMoney.Text, out result);

            if (input)
            {
                string tag = lbRFIDNR.Text;

                databseHelper.Transfert(tag, result);
                MessageBox.Show("Added");
                databseHelper.TransfertToRFID(tag);
            }
            else
                MessageBox.Show("Wrong Input format ");

        }

        private void btTransHistory_Click_1(object sender, EventArgs e)
        {
           // richthistory.Visible = true;
        }


        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            lbAmountRFID.Text = "RFID Reader attached!," + e.Device.SerialNumber; ;
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            lbAmountRFID.Text = "RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString();
        }


        private void ProcessThisTag(object sender, TagEventArgs e)
        {

            tagnumber = e.Tag.ToString();
            lbRFIDNR.Text = tagnumber;

            List<string>[] myArrayList = databseHelper.Select(tagnumber);

            List<string> names = myArrayList[0];
            List<string> RfidNber = myArrayList[1];
            List<string> bankAccount = myArrayList[2];

            foreach (string s in names)
            {
                lbFullName.Text = s;
            }

            foreach (string m in RfidNber)
            {
                lbAmountRFID.Text = m;
            }

            foreach (string bk in bankAccount)
            {
                lbAccountClient.Text = bk;
            }

            Console.Beep();


           

            btCreditRFID.Visible = true;

          
            tbEnterMoney.Visible = true;
            lbEnterAmount.Visible = true;
            lbEnterAmount.Visible = true;
            tbEnterMoney.Visible = true;

        }

        private void btStopScan_Click(object sender, EventArgs e)
        {

        }

        private void btTransfer_Click(object sender, EventArgs e)
        {

            //int result = 0;

            //   bool answer = Int32.TryParse(tbEnterMoney.Text, out result);
            //   if (answer)
            //     //  databseHelper.Update(result, lbRFIDNR.Text);
            //   //  databseHelper.Update(result,e.Tag.ToString());
            //   // lbAccountClient.Text = "";
            //   else
            //       MessageBox.Show("Value entered not in good format");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("Please scan....");



            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                rfid.LED = false;
                rfid.Antenna = false;
               
                MessageBox.Show("Scanner is Closing");
                rfid.close();

            }
            catch (PhidgetException) { MessageBox.Show(" RFID-reader not Closed."); }

            LoadClientInfo("../../../Data/LogfileDetails.txt");
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            // LoadPersons("../../../data/persons.txt");
           // if (LoadClientInfo("../../../Data/LogfileDetails.txt"))
               // databseHelper.Insert(c.RfidFields,c.RfidFields,c.DateUpload,c.Amount,c.EventAccount,c.DateEnd);
           
             
        }

        private void richthistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int user = 123456;
            int password = 258852;
            bool userTest = Int32.TryParse(textBox1.Text, out user);
            bool passwrdTest = Int32.TryParse(textBox2.Text, out password);
            if ((userTest) && (passwrdTest))
            //LoadClientInfo("../../../Data/LogfileDetails.txt");
            {
                MessageBox.Show("Loged In succesuflly");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
                MessageBox.Show("wrong User_ID or password", "WARNING");
        }
    }
}
