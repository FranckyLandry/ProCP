using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets; //Needed for the RFID class and the PhidgetException class
using Phidgets.Events; //Needed for the phidget event handling classes
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql.Web;
namespace Restaurant
{
    public partial class Restaurant : Form
    {
        private List<Chinese> chineseList;
        private List<Italian> italianList;
        private List<Persian> persianList;
        private decimal totalPriceSelectedFood;
        private List<string>[] lisMoneyClient;
        private List<string> getListmoneyclient;
        private string moneyClient;
        private string saverfid;
        private int countItemsPersian;
        private int countItemsItalian;
        private int countItemsChine;
        private int tempcountPersian;
        private int tempcountItalian;
        private int tempcountChine;
        private List<ClassRestaurant> ListStallName;
        private List<string>[] getStockPersian;
        private List<string>[] getStockItalian;
        private List<string>[] getStockChinese;
        private List<string> takeoutStockPersian;
        private List<string> taKeoutStockItalian;
        private List<string> takeoutStockChine;
    

        ClassRestaurant mainRestaurant = null;
        RFID rfid;
        DatabaseHelper databseHelper;


        public Restaurant()
        {

            InitializeComponent();
            databseHelper = new DatabaseHelper();

            chineseList = new List<Chinese>();
            italianList = new List<Italian>();
            persianList = new List<Persian>();
         
            ListStallName = new List<ClassRestaurant>();

            gpChinese.Visible = false;
            gpeItaliano.Visible = false;
            gpPersian.Visible = false;
            Gpbreakfasts.Visible = false;
            gpDrinks.Visible = false;
            gpeDetailsClient.Visible = false;
            gpeDetailsInfo.Enabled = false ;
         

            tempcountPersian = 0;
            tempcountItalian = 0;
            tempcountChine = 0;
            totalPriceSelectedFood = 0;
            moneyClient = "";
            saverfid = "";

            try
            {
                rfid = new RFID();
                rfid.Attach += new AttachEventHandler(ShowWhoIsAttached);
                rfid.Detach += new DetachEventHandler(ShowWhoIsDetached);
                rfid.Tag += new TagEventHandler(ProcessThisTag);
                lbl_Message.Text = "waiting for attachment";
                rfid.Tag += new TagEventHandler(ProcessTagTransaction);
            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }
        }
        private void ShowWhoIsAttached(object sender, AttachEventArgs e)
        {
            lbl_Message.Text = "RFID Reader attached!," + e.Device.SerialNumber;
        }

        private void ShowWhoIsDetached(object sender, DetachEventArgs e)
        {
            lbl_Message.Text = "RFIDReader detached!, serial nr: " + e.Device.SerialNumber.ToString();
        }

        private void ProcessTagTransaction(object sender, TagEventArgs e)
        {
            saverfid = e.Tag;
            lbRFIDNR.Text = saverfid;

            lisMoneyClient = databseHelper.Payments(saverfid);

            getListmoneyclient = lisMoneyClient[0];

            foreach (string s in getListmoneyclient)
            {

                moneyClient = s;
            }
        }

        private void ProcessThisTag(object sender, TagEventArgs e)
        {
            string tagnumber = e.Tag.ToString();
         
            lbl_RFID_Show.Text = tagnumber;

            List<string>[] myArrayList = databseHelper.Select(tagnumber);

            List<string> names = myArrayList[0];
            List<string> money = myArrayList[1];
            foreach (string s in names)
            {
                lbl_Name.Text = s;
            }

            foreach (string m in money)
            {
                lbl_Money.Text = m;
            }
            Console.Beep();
        }
        private void linkLbDinner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Gpbreakfasts.Visible = false;
            gpDrinks.Visible = false;



            gpPersian.Visible = true;
            gpChinese.Visible = true;
            gpeItaliano.Visible = true;

            if (rbTahcinChouse.Checked)
                lbItemSelected.Items.Add("Dinner:");

        }

        private void linkLbindonesianfood_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gpChinese.Visible = false;
            gpeItaliano.Visible = false;
            gpPersian.Visible = false;
            gpDrinks.Visible = false;

            Gpbreakfasts.Visible = true;
        }

        private void linkLabelDrinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gpChinese.Visible = false;
            gpeItaliano.Visible = false;
            gpPersian.Visible = false;
            Gpbreakfasts.Visible = false;


            gpDrinks.Visible = true;

        }

        private void btPayOrder_Click(object sender, EventArgs e)
        {
            if (lbItemSelected.Items.Count != 0)
            {


                gpeDetailsInfo.Enabled = true;
                gpChinese.Visible = false;
                gpeItaliano.Visible = false;
                gpPersian.Visible = false;
                Gpbreakfasts.Visible = false;
                gpDrinks.Visible = false;
                btOK.Enabled = false;
                btRemveSelectIterm.Enabled = false;
                foreach (ClassRestaurant item in lbItemSelected.Items)
                {
                 
                        if (item is Persian)
                        {
                            totalPriceSelectedFood += ((Persian)item).Price;
                            tempcountPersian++;
                           
                        }
                        if (item is Italian)
                        {
                            totalPriceSelectedFood += ((Italian)item).Price;
                            tempcountItalian++;
                        }
                        if (item is Chinese)
                        {
                            totalPriceSelectedFood += ((Chinese)item).Price;
                            tempcountChine++;
                        }
                  
                    ListStallName.Add(item);
                }
                lbTotalAmountShow.Text = totalPriceSelectedFood + " euro";

            }
            else
                MessageBox.Show("No menu selected yet!", "WARNING");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gpeDetailsClient.Visible = true;
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
             

            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }



        private void rbTahcinChouse_Click(object sender, EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Persian("TahChin", "Persian", 5,0));
            persianList.Add((Persian)mainRestaurant);

        }

        private void rbFesenjan_Click(object sender, EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Persian("Fesenjan", "Persian", 6,0));
            persianList.Add((Persian)mainRestaurant);
        }

        private void rbDarban_Click(object sender, System.EventArgs e)
        {
            lbItemSelected.Items.Add(mainRestaurant = new Persian("Darban", "Persian", 7,0));
            persianList.Add((Persian)mainRestaurant);
        }

        private void rbLasagne_Click(object sender, System.EventArgs e)
        {
            lbItemSelected.Items.Add(mainRestaurant = new Italian("Lasagne", "Italiano", 5,0));
            italianList.Add((Italian)mainRestaurant);
        }

        private void rbPizza_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Italian("Pizza", "Italiano", 6,0));
            italianList.Add((Italian)mainRestaurant);
        }

        private void rbToffu_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Chinese("Toffu", "Chine", 5,0));
            chineseList.Add((Chinese)mainRestaurant);
        }

        private void rbChikenChowmein_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Chinese("chicken chow mein", "Chine", 6,0));
            chineseList.Add((Chinese)mainRestaurant);

        }

        private void rbpersianBreakfast_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Persian("Full persian breakfast ", "Persian", 4,0));
            persianList.Add((Persian)mainRestaurant);
        }

        private void rbItalianobreakfast_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Italian("italiano breakfast", "Italiano", 4,0));
            italianList.Add((Italian)mainRestaurant);
        }

        private void rbcapresso_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Chinese("Capresso", "Chine", 4,0));
            chineseList.Add((Chinese)mainRestaurant);
        }

        private void rbContinental_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Chinese("Continental", "Chine", 4,0));
            chineseList.Add((Chinese)mainRestaurant);
        }

        private void rbCola_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Chinese("Coca-Cola", "Chine", 3,0));
            chineseList.Add((Chinese)mainRestaurant);
        }

        private void rbCaridoCoktail_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Italian("Carido Cocktail", "Italino", 3,0));
            italianList.Add((Italian)mainRestaurant);
        }

        private void rbBacardi_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Persian("Bacardi", "Persian", 3,0));
            persianList.Add((Persian)mainRestaurant);
        }

        private void rbPersian_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Persian("Persian beer ", "Persian", 3,0));
            persianList.Add((Persian)mainRestaurant);
        }

        private void rbChineBeer_Click(object sender, System.EventArgs e)
        {

            lbItemSelected.Items.Add(mainRestaurant = new Chinese("Chinese beer ", "Chine", 3,0));
            chineseList.Add((Chinese)mainRestaurant);
        }

        private void btRemveSelectIterm_Click(object sender, System.EventArgs e)
        {
            mainRestaurant = (ClassRestaurant)lbItemSelected.SelectedItem;
            if (mainRestaurant == null)
                MessageBox.Show("NO MENU SELECTED!", "ERROR");
            else
            {
                lbItemSelected.Items.Remove(mainRestaurant);
            }
        }

        private void btStartScan_Click(object sender, EventArgs e)
        {
            try
            {
                gpChinese.Visible = false;
                gpeItaliano.Visible = false;
                gpPersian.Visible = false;
                Gpbreakfasts.Visible = false;
                gpDrinks.Visible = false;
                gpeDetailsClient.Visible = false;

                btStartScan.Enabled = false;


                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("Please scan....");
                btPay.Enabled = true;
            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            try
            {
                btOK.Enabled = true;
                btRemveSelectIterm.Enabled = true;
                gpChinese.Visible = true;
                gpeItaliano.Visible = true;
                gpPersian.Visible = true;
                Gpbreakfasts.Visible = true;
                gpDrinks.Visible = true;

                btStartScan.Enabled = true;

                totalPriceSelectedFood = 0;
                lbTotalAmountShow.Text = "";
                rfid.LED = false;
                rfid.Antenna = false;
                lbl_RFID_Show.Text = "";
                rfid.close();
                lbRFIDNR.Text = "";
            }
            catch (PhidgetException) { }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
             
                decimal remainMoney = 0;

                remainMoney = Convert.ToDecimal(moneyClient) - totalPriceSelectedFood;

                databseHelper.SetAfterTransaction(remainMoney, saverfid);

                foreach (ClassRestaurant st in ListStallName)
                {
                    if (st is Persian)
                    {
                        string stalname = ((Persian)st).StallName;
                        string typeofFood = ((Persian)st).Name;
                        getStockPersian = databseHelper.SelectStock(stalname, typeofFood);


                        for (int i = 0; i < getStockPersian.Length; i++)
                        {
                            takeoutStockPersian = getStockPersian[i];

                            foreach (string takeout in takeoutStockPersian)
                            {
                                countItemsPersian = Convert.ToInt32(takeout);
                                countItemsItalian = countItemsPersian - tempcountPersian;
                                databseHelper.setRemainStock(countItemsPersian, stalname, typeofFood);
                            }
                        }
                    }
                    if (st is Italian)
                    {
                        string stalname = ((Italian)st).StallName;
                        string typeofFood = ((Italian)st).Name;
                        getStockItalian = databseHelper.SelectStock(stalname, typeofFood);


                        for (int i = 0; i < getStockItalian.Length; i++)
                        {
                            taKeoutStockItalian = getStockItalian[i];

                            foreach (string takeout in taKeoutStockItalian)
                            {
                                countItemsItalian = Convert.ToInt32(takeout);
                                countItemsItalian = countItemsItalian - tempcountItalian;
                                databseHelper.setRemainStock(countItemsItalian, stalname, typeofFood);
                            }
                        }
                    }
                    if (st is Chinese)
                    {
                        string stalname = ((Chinese)st).StallName;
                        string typeofFood = ((Chinese)st).Name;
                        getStockChinese = databseHelper.SelectStock(stalname, typeofFood);


                        for (int i = 0; i < getStockChinese.Length; i++)
                        {
                            takeoutStockChine = getStockChinese[i];

                            foreach (string takeout in takeoutStockChine)
                            {
                                countItemsChine = Convert.ToInt32(takeout);
                                countItemsItalian = countItemsChine - tempcountChine;
                                databseHelper.setRemainStock(countItemsChine, stalname, typeofFood);
                            }
                        }
                    }
                   
                }
                if (remainMoney < 0)
                {
                    MessageBox.Show("Please recharge your RFID MONEY");
                }
                else
                {
                    lbRestAmount.Text = remainMoney.ToString();
                    MessageBox.Show("Paid");
                }
               
            }
            catch (FormatException ex) { MessageBox.Show("You have to scan first"); }
            finally { gpeDetailsClient.Visible = false; }

        }
       
    }
}
