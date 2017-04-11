using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Web;
using MySql.Data.MySqlClient;

namespace Management
{
    public partial class Form1 : Form
    {
        String connectionInfo;
        DatabaseHelper databaseHelper = new DatabaseHelper();
        List<ClassRestaurant> myclassRest = new List<ClassRestaurant>();
        
        //for food
        //chinese
        int totalremaingcapresso = 0; int totalsremaingchicken = 0; int totalsremaingbeer = 0; int total_chinese;
        int totalremaingcocaloChinese = 0; int totalremaingcontinental = 0; int totalremaingtoffu = 0;
        //italino
        int totalcaridocktails = 0; int totalsremaingCocacolaItaliano = 0;
        int totalremaingbreakfast = 0; int totalremainglasagne = 0; int totalremaingpizza = 0;
        int total_Italiano;
        //persian
        int totalremaingBacardi = 0; int totalsremaingCocacolaPerian = 0; int totalsremaingdarban = 0;
        int totalremaingFesenjan = 0; int totalremaingFullbrakfast = 0; int totalremaingbeer = 0;
        int totalremaintachin = 0;
        
        int total_Persian;

        //for entrance
        int total_visiotrs_present;
        int total_visitors;
        int total_check_in;
        int total_check_out;
        //int total_earned_entrance;

        //for paint ball.....
        int total_paint_ball_suit;
        int remaing_paint_ball_suit;
        int rent_paint_ball_suit;
        int rent_paint_ball_suit_present;
        // int price_per_suit;
        // int toal_earned_paint_ball;

        //camping....
        int total_camping_site = 1000;
        int total_visitors_camping;
        int totalreserve = 0;
        int remaining_camping_site;
        int total_check_in_camping;
        int total_check_out_camping;
        //int total_present;
        int total_earned_Camping;
        int totalLeader, totalMember = 0;


        //coffee............
        int total_roll;
        int remaing_roll_sativa;
        int remaing_roll_indica;
        int sold_roll;
        int price_sativa = 7;
        int price_indica = 8;
        int price_ruderails = 9;
        int total_earned_sativa;
        int total_earned_indica;
        int total_earned_ruderails;
        int total_earned_coffee_shop;

        public Form1()
        {
            InitializeComponent();
        }


        private void tbPgFood_Click(object sender, EventArgs e)
        {

        }

        private void rbPersian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPersian_Click(object sender, EventArgs e)
        {
            lbFoodDetails.Items.Clear();
            lbStockDetails.Items.Clear();
            List<string>[] myBacardi = databaseHelper.selectYpeOfFood("Bacardi");
            List<string>[] myCocaCola = databaseHelper.selectYpeOfFood("Coca-Cola");
            List<String>[] myDarban = databaseHelper.selectYpeOfFood("Darban");
            List<String>[] myFesenjan = databaseHelper.selectYpeOfFood("Fesenjan");
            List<String>[] myFullpersianbreakfast = databaseHelper.selectYpeOfFood("Full persian breakfast");
            List<string>[] myPersianbeer = databaseHelper.selectYpeOfFood("Persian beer");
            List<string>[] myTahChin = databaseHelper.selectYpeOfFood("TahChin");


            List<string> bacardi = myBacardi[0];
            List<String> CocaCola = myCocaCola[0];
            List<string> darban = myDarban[0];
            List<string> fesenjan = myFesenjan[0];
            List<string> fullBreak = myFullpersianbreakfast[0];
            List<string> persianBeer = myPersianbeer[0];
            List<string> tahchin = myTahChin[0];





            List<string>[] myArrayList = databaseHelper.SelectAll("Persian");

            List<string> typeOfFoodList = myArrayList[1];
            string[] Type_of_Food = new string[7];

            foreach (string stock in bacardi)
            {
                totalremaingBacardi = Convert.ToInt32(stock);
            }

            foreach (string stock in CocaCola)
            {
                totalsremaingCocacolaPerian = Convert.ToInt32(stock);
            }
            foreach (string stock in darban)
            {
                totalsremaingdarban = Convert.ToInt32(stock);
            }

            foreach (string stock in fesenjan)
            {
                totalremaingFesenjan = Convert.ToInt32(stock);
            }

            foreach (string stock in fullBreak)
            {
                totalremaingFullbrakfast = Convert.ToInt32(stock);
            }
            foreach (string stock in persianBeer)
            {
                totalremaingbeer = Convert.ToInt32(stock);
            }
            foreach (string stock in tahchin)
            {
                totalremaintachin = Convert.ToInt32(stock);
            }

            foreach (string foodtype in typeOfFoodList)
            {
                if (foodtype == "Bacardi")
                    Type_of_Food[0] = foodtype;

                else if (foodtype == "Coca-Cola")

                    Type_of_Food[1] = foodtype;

                else if (foodtype == "Darban")

                    Type_of_Food[2] = foodtype;

                else if (foodtype == "Fesenjan")

                    Type_of_Food[3] = foodtype;

                else if (foodtype == "Full persian breakfast")

                    Type_of_Food[4] = foodtype;

                else if (foodtype == "Persian beer")

                    Type_of_Food[5] = foodtype;

                else if (foodtype == "TahChin")

                    Type_of_Food[6] = foodtype;
            }




            lbFoodDetails.Items.Add("Name : PERSIAN ");
            lbFoodDetails.Items.Add("Type Of Food ");
            lbFoodDetails.Items.Add("1." + Type_of_Food[0] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("2." + Type_of_Food[1] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("3." + Type_of_Food[2] + "  price: 7 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("4." + Type_of_Food[3] + "  price: 6 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("5." + Type_of_Food[4] + "  price: 4 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("6." + Type_of_Food[5] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("7." + Type_of_Food[6] + "  price: 5 Euros" + "TotalStock 100");


            lbStockDetails.Items.Add("Bacardi: " + totalremaingBacardi + "Iterms");
            lbStockDetails.Items.Add("Coca-Cola : " + totalsremaingCocacolaPerian + "Iterms");
            lbStockDetails.Items.Add("Darban : " + totalsremaingdarban + "Iterms");
            lbStockDetails.Items.Add("Fesenjan : " + totalremaingFesenjan);
            lbStockDetails.Items.Add("Full persian breakfast: " + totalremaingFullbrakfast + "Iterms");
            lbStockDetails.Items.Add("Persian beer : " + totalremaingbeer + "Iterms");
            lbStockDetails.Items.Add("TahChin : " + totalremaintachin + "Iterms");

           
        }

        private void rbItalian_Click(object sender, EventArgs e)
        {
            lbFoodDetails.Items.Clear();
            lbStockDetails.Items.Clear();

            List<string>[] mycaridoCocktail = databaseHelper.selectYpeOfFood("Carido Cocktail");
            List<string>[] myCocaColaItalian = databaseHelper.selectYpeOfFood("Coca-Cola");
            List<String>[] myBreakFast = databaseHelper.selectYpeOfFood("italiano breakfast");
            List<String>[] myLasagne = databaseHelper.selectYpeOfFood("Lasagne");
            List<String>[] myPizza = databaseHelper.selectYpeOfFood("Pizza");



            List<string> caridocktails = mycaridoCocktail[0];
            List<String> CocaCola = myCocaColaItalian[0];
            List<string> breakfast = myBreakFast[0];
            List<string> lasagne = myLasagne[0];
            List<string> pizza = myPizza[0];



            List<string>[] myArrayList = databaseHelper.SelectAll("Italiano");


            List<string> typeOfFoodList = myArrayList[1];
            string[] Type_of_Food = new string[5];


            foreach (string stock in caridocktails)
            {
                totalcaridocktails = Convert.ToInt32(stock);
            }

            foreach (string stock in CocaCola)
            {
                totalsremaingCocacolaItaliano = Convert.ToInt32(stock);
            }
            foreach (string stock in breakfast)
            {
                totalremaingbreakfast = Convert.ToInt32(stock);
            }

            foreach (string stock in lasagne)
            {
                totalremainglasagne = Convert.ToInt32(stock);
            }

            foreach (string stock in pizza)
            {
                totalremaingpizza = Convert.ToInt32(stock);
            }


            foreach (string foodtype in typeOfFoodList)
            {
                if (foodtype == "Carido Cocktail")
                    Type_of_Food[0] = foodtype;

                else if (foodtype == "Coca-Cola")

                    Type_of_Food[1] = foodtype;

                else if (foodtype == "italiano breakfast")

                    Type_of_Food[2] = foodtype;

                else if (foodtype == "Lasagne")

                    Type_of_Food[3] = foodtype;

                else if (foodtype == "Pizza")

                    Type_of_Food[4] = foodtype;
            }

            lbFoodDetails.Items.Add("Name : ITALIANO ");

            lbFoodDetails.Items.Add("Type Of Food ");
            lbFoodDetails.Items.Add("1." + Type_of_Food[0] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("2." + Type_of_Food[1] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("3." + Type_of_Food[2] + "  price: 4 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("4." + Type_of_Food[3] + "  price: 5 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("5." + Type_of_Food[4] + "  price: 6 Euros" + "TotalStock 100");


            lbStockDetails.Items.Add("Carido Cocktail: " + totalcaridocktails + "Iterms");
            lbStockDetails.Items.Add("Coca-Cola : " + totalsremaingCocacolaItaliano + "Iterms");
            lbStockDetails.Items.Add("italiano breakfast : " + totalremaingbreakfast + "Iterms");
            lbStockDetails.Items.Add("Lasagne : " + totalremainglasagne);
            lbStockDetails.Items.Add("Pizza " + totalremaingpizza + "Iterms");

        }

        private void rbChinese_Click(object sender, EventArgs e)
        {
            lbFoodDetails.Items.Clear();
            lbStockDetails.Items.Clear();
            List<string>[] mycapresso = databaseHelper.selectYpeOfFood("Capresso");
            List<string>[] myChickenchow = databaseHelper.selectYpeOfFood("chicken chow mein");
            List<String>[] mybeer = databaseHelper.selectYpeOfFood("Chinese beer");
            List<String>[] mycocalo = databaseHelper.selectYpeOfFood("Coca-Cola");
            List<String>[] mycontinental = databaseHelper.selectYpeOfFood("Continental");
            List<string>[] mytoffu = databaseHelper.selectYpeOfFood("Toffu");


            List<string> capresso = mycapresso[0];
            List<String> chicken = myChickenchow[0];
            List<string> beer = mybeer[0];
            List<string> cocalo = mycocalo[0];
            List<string> continental = mycontinental[0];
            List<string> toffu = mytoffu[0];




            List<string>[] myArrayList = databaseHelper.SelectAll("Chinese");

            List<string> typeOfFoodList = myArrayList[1];
            string[] Type_of_Food = new string[6];

            foreach (string stock in capresso)
            {
                totalremaingcapresso = Convert.ToInt32(stock);
            }

            foreach (string stock in beer)
            {
                totalsremaingbeer = Convert.ToInt32(stock);
            }
            foreach (string stock in cocalo)
            {
                totalremaingcocaloChinese = Convert.ToInt32(stock);
            }

            foreach (string stock in continental)
            {
                totalremaingcontinental = Convert.ToInt32(stock);
            }

            foreach (string stock in toffu)
            {
                totalremaingtoffu = Convert.ToInt32(stock);
            }
            foreach (string stock in chicken)
            {
                totalsremaingchicken = Convert.ToInt32(stock);
            }



            foreach (string foodtype in typeOfFoodList)
            {
                if (foodtype == "Capresso")
                    Type_of_Food[0] = foodtype;

                else if (foodtype == "chicken chow mein")

                    Type_of_Food[1] = foodtype;

                else if (foodtype == "Chinese beer")

                    Type_of_Food[2] = foodtype;

                else if (foodtype == "Coca-Cola")

                    Type_of_Food[3] = foodtype;

                else if (foodtype == "Continental")

                    Type_of_Food[4] = foodtype;

                else if (foodtype == "Toffu")

                    Type_of_Food[5] = foodtype;
            }


            lbFoodDetails.Items.Add("Name : CHINESE ");
            lbFoodDetails.Items.Add("Type Of Food ");
            lbFoodDetails.Items.Add("1." + Type_of_Food[0] + "  price: 4 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("2." + Type_of_Food[1] + "  price: 6 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("3." + Type_of_Food[2] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("4." + Type_of_Food[3] + "  price: 3 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("5." + Type_of_Food[4] + "  price: 4 Euros" + "TotalStock 100");
            lbFoodDetails.Items.Add("6." + Type_of_Food[5] + "  price: 5 Euros" + "TotalStock 100");


            lbStockDetails.Items.Add("Capresso: " + totalremaingcapresso + "Iterms");
            lbStockDetails.Items.Add("chicken chow mein : " + totalsremaingchicken + "Iterms");
            lbStockDetails.Items.Add("Chinese beer : " + totalsremaingbeer + "Iterms");
            lbStockDetails.Items.Add("Coca-Cola : " + totalremaingcocaloChinese);
            lbStockDetails.Items.Add("Continental: " + totalremaingcontinental + "Iterms");
            lbStockDetails.Items.Add("Toffu : " + totalremaingtoffu + "Iterms");


            ////calculation....
            //total_chinese = (((100 - totalremaingcapresso) * 4) + ((100 - totalsremaingchicken) * 6) + ((100 - totalsremaingbeer) * 3) + ((100 - totalremaingcocaloChinese) * 3) + ((100 - totalremaingcontinental) * 4) + ((100 - totalremaingtoffu)));
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionInfo = "Server=athena01.fhict.local;" +
                               "Database=dbi297937;" +
                               "user id=dbi297937;" +
                               "Password=xdl2xDpHkC;" +
                               "connect timeout=30;";
           
            //start connection
            MySqlConnection connection = new MySqlConnection(connectionInfo);
            
            /////////////////////////////////////////////////////////for entrance//////////////////////////////////////////////////////
            //calculation....
            total_Persian = (((100 - totalremaingBacardi) * 3) + ((100 - totalsremaingCocacolaPerian) * 3) + ((100 - totalsremaingdarban) * 7) + ((100 - totalremaingFesenjan) * 6) + ((100 - totalremaingFullbrakfast) * 4) + ((100 - totalremaingbeer) * 3) + ((100 - totalremaintachin) * 5));
            //calculation
            total_Italiano = (((100 - totalcaridocktails) * 3) + ((100 - totalsremaingCocacolaItaliano) * 3) + ((100 - totalremaingbreakfast) * 4) + ((100 - totalremainglasagne) * 5) + ((100 - totalremaingpizza) * 6));

            //calculation....
            total_chinese = (((100 - totalremaingcapresso) * 4) + ((100 - totalsremaingchicken) * 6) + ((100 - totalsremaingbeer) * 3) + ((100 - totalremaingcocaloChinese) * 3) + ((100 - totalremaingcontinental) * 4) + ((100 - totalremaingtoffu)));

            lbl_total_Persian.Text = total_Persian.ToString();
            lbl_total_Italiano.Text = total_Italiano.ToString();
            lbl_total_Chinese.Text = total_chinese.ToString();
            lbl_Total_food.Text = (total_Persian + total_Italiano + total_chinese).ToString();
            lbl_Food_Amount.Text=(total_Persian + total_Italiano + total_chinese).ToString();
            //count total visitors.................................................

            connection.Open();
            string count_total_visitors = "  SELECT count(DISTINCT  RFID_Nr) FROM event_visitors ";
            MySqlDataReader reader_total_visiotrs;
            MySqlCommand cmd_total_visiotrs = new MySqlCommand(count_total_visitors, connection);
            reader_total_visiotrs = cmd_total_visiotrs.ExecuteReader();
            while (reader_total_visiotrs.Read())
            {
                total_visitors = Convert.ToInt32(reader_total_visiotrs.GetString(0));
            }
            connection.Close();

            //count total Check in....................................................
            connection.Open();
            string count_total_check_in = " Select count(Status)from event_visitors where Status='In'";
            MySqlDataReader reader_total_check_in;
            MySqlCommand cmd_total_check_in = new MySqlCommand(count_total_check_in, connection);
            reader_total_check_in = cmd_total_check_in.ExecuteReader();
            while (reader_total_check_in.Read())
            {
                total_check_in = Convert.ToInt32(reader_total_check_in.GetString(0));
            }
            connection.Close();



            //count total Check out....................................................
            connection.Open();
            string count_total_check_out = " Select count(Status)from event_visitors where Status='Out'";
            MySqlDataReader reader_total_check_out;
            MySqlCommand cmd_total_check_out = new MySqlCommand(count_total_check_out, connection);
            reader_total_check_out = cmd_total_check_out.ExecuteReader();
            while (reader_total_check_out.Read())
            {
                total_check_out = Convert.ToInt32(reader_total_check_out.GetString(0));
            }
            connection.Close();

            total_visiotrs_present = total_check_in + total_check_out;
            lbl_visitors_present.Text = total_visiotrs_present.ToString();
            lbl_Total_nr_check_out.Text = total_check_out.ToString();
            lbl_Total_nr_check_in.Text = total_check_in.ToString();
            lbl_visitors_not_present.Text = (total_visitors - total_visiotrs_present).ToString();
            lbl_Total_number_of_visitors.Text = total_visitors.ToString();
            lbl_Total_Earned_Entrance.Text = (total_visitors * 35).ToString();

            //////////////////////////////////////////////////////for camping/////////////////////////////////////////////////////////

            lbl_ttl_camping_site_nr.Text = total_camping_site.ToString();

            //count total visitors at camping.................................................

            connection.Open();
            string count_total_camping_visitors = " SELECT count(DISTINCT GroupMember_RFID) FROM campings ";
            MySqlDataReader reader_camping_visitors;
            MySqlCommand cmd_total_camping_visiotrs = new MySqlCommand(count_total_camping_visitors, connection);
            reader_camping_visitors = cmd_total_camping_visiotrs.ExecuteReader();
            while (reader_camping_visitors.Read())
            {
                total_visitors_camping = Convert.ToInt32(reader_camping_visitors.GetString(0));
            }
            lbl_total_camping_people.Text = total_visitors_camping.ToString();
            connection.Close();

            //count reserved camping site.................................................

            connection.Open();
            string count_reserved_camping = " SELECT count(DISTINCT Camping_site_Nr) FROM campings ";
            MySqlDataReader reader_reserved_camping;
            MySqlCommand cmd_reserved_camping = new MySqlCommand(count_reserved_camping, connection);
            reader_reserved_camping = cmd_reserved_camping.ExecuteReader();
            while (reader_reserved_camping.Read())
            {
                totalreserve = Convert.ToInt32(reader_reserved_camping.GetString(0));
            }
            lbReserveSite.Text = totalreserve.ToString();
            connection.Close();

            //remaining camping sites

            remaining_camping_site = total_camping_site - totalreserve;
            lbl_remaing_site_nr.Text = remaining_camping_site.ToString();

            //count total  camping Check in....................................................
            connection.Open();
            string count_total_camping_check_in = " Select count(Camping_Status)from campings where Camping_Status='In'";
            MySqlDataReader reader_total_camping_check_in;
            MySqlCommand cmd_total_camping__check_in = new MySqlCommand(count_total_camping_check_in, connection);
            reader_total_camping_check_in = cmd_total_camping__check_in.ExecuteReader();
            while (reader_total_camping_check_in.Read())
            {
                total_check_in_camping = Convert.ToInt32(reader_total_camping_check_in.GetString(0));
            }
            lbl_Check_In.Text = total_check_in_camping.ToString();
            connection.Close();

            //count total  camping Check out....................................................
            connection.Open();
            string count_total_camping_check_out = " Select count(Camping_Status)from campings where Camping_Status='Out'";
            MySqlDataReader reader_total_camping_check_out;
            MySqlCommand cmd_total_camping__check_out = new MySqlCommand(count_total_camping_check_out, connection);
            reader_total_camping_check_out = cmd_total_camping__check_out.ExecuteReader();
            while (reader_total_camping_check_out.Read())
            {
                total_check_out_camping = Convert.ToInt32(reader_total_camping_check_out.GetString(0));
            }
            lbl_check_out.Text = total_check_out_camping.ToString();
            connection.Close();

            //total earned..............

            //count distinct group leader..........
            connection.Open();
            string count_group_leader = " Select count(DISTINCT Group_Leader)from campings ";
            MySqlDataReader reader_group_leader;
            MySqlCommand cmd_group_leader = new MySqlCommand(count_group_leader, connection);
            reader_group_leader = cmd_group_leader.ExecuteReader();
            while (reader_group_leader.Read())
            {
                totalLeader = Convert.ToInt32(reader_group_leader.GetString(0));
            }
            lbl_check_out.Text = total_check_out_camping.ToString();
            connection.Close();

            //count team members
            connection.Open();
            string count_team_members = " Select count(DISTINCT Group_Member)from campings ";
            MySqlDataReader reader_team_member;
            MySqlCommand cmd_team_member = new MySqlCommand(count_team_members, connection);
            reader_team_member = cmd_team_member.ExecuteReader();
            while (reader_team_member.Read())
            {
                totalMember = Convert.ToInt32(reader_team_member.GetString(0));
            }
            lbl_check_out.Text = total_check_out_camping.ToString();
            connection.Close();

            totalMember = total_visitors_camping - totalLeader;
            total_earned_Camping = ((totalLeader * 30) + (totalMember * 20));
            lbl_Camping_ttl_earned.Text = total_earned_Camping.ToString();
            lbl_Camping_Amount.Text = total_earned_Camping.ToString();



            //////////////////////////////////////////////////////for paint Ball//////////////////////////////////////////////////////
            total_paint_ball_suit = 2000;
            lbl_ttl_suit_nr.Text = total_paint_ball_suit.ToString();


            //total number of suit rented at present time................................................
            connection.Open();
            string count_rent_suit_at_present = "  SELECT  sum(Number_Of_Suite) FROM `renting_paint_ball_game` WHERE End_Time is  null;";
            MySqlDataReader reader_suit_present;
            MySqlCommand cmd_suit_present = new MySqlCommand(count_rent_suit_at_present, connection);
            reader_suit_present = cmd_suit_present.ExecuteReader();
            while (reader_suit_present.Read())
            {
                rent_paint_ball_suit_present = Convert.ToInt32(reader_suit_present.GetString(0));
            }
            lbl_suit_in_rent.Text = rent_paint_ball_suit_present.ToString();
            connection.Close();

            //total number of suit rented.............................
            connection.Open();
            string count_remaining_suit = "  SELECT  sum(Number_Of_Suite) FROM `renting_paint_ball_game` WHERE End_Time is   not null;";
            MySqlDataReader reader_suit;
            MySqlCommand cmd_suit = new MySqlCommand(count_remaining_suit, connection);
            reader_suit = cmd_suit.ExecuteReader();
            while (reader_suit.Read())
            {
                rent_paint_ball_suit = Convert.ToInt32(reader_suit.GetString(0));
            }
            lbl_rent_suit_nr.Text = (rent_paint_ball_suit + rent_paint_ball_suit_present).ToString();
            remaing_paint_ball_suit = total_paint_ball_suit - rent_paint_ball_suit_present;
            lbl_remaining_suit_nr.Text = remaing_paint_ball_suit.ToString();
            lbl_total_earned_paint_ball.Text = ((rent_paint_ball_suit + rent_paint_ball_suit_present) * 30).ToString() + "  Euros";
            lbl_Paint_Ball_Amount.Text = ((rent_paint_ball_suit + rent_paint_ball_suit_present) * 30).ToString();
            connection.Close();





            //////////////////////////////////////////////for coffee_coffee////////////////////////////////////////////////////////////////////////////

            //for sativa.................................................................................
            total_roll = 500;
            lbl_nr_of_Roll_sativa.Text = total_roll.ToString();
            price_per_roll_sativa.Visible = true;
            lbl_price_info_sativa.Visible = true;



            connection.Open();
            string count_sativa_query = " Select count(Type)from coffee_shop where Type='Sativa'";
            MySqlDataReader reader_sativa;
            MySqlCommand cmd_sativa = new MySqlCommand(count_sativa_query, connection);
            reader_sativa = cmd_sativa.ExecuteReader();
            while (reader_sativa.Read())
            {
                sold_roll = Convert.ToInt32(reader_sativa.GetString(0));
            }
            remaing_roll_sativa = total_roll - sold_roll;
            lbl_nr_remaing_sativa.Text = remaing_roll_sativa.ToString();
            total_earned_sativa = sold_roll * price_sativa;
            lbl_Total_earned_coffee_sativa.Text = total_earned_sativa.ToString();
            connection.Close();

            //for indica.................................................................
            lbl_total_nr_indica.Text = total_roll.ToString();
            lbl_price_per_indica_info.Visible = true;
            lbl_price__per_indica.Visible = true;

            connection.Open();
            string count_indica_query = " Select count(Type)from coffee_shop where Type='Indica'";
            MySqlDataReader reader_indica;
            MySqlCommand cmd_indica = new MySqlCommand(count_indica_query, connection);
            reader_indica = cmd_indica.ExecuteReader();
            while (reader_indica.Read())
            {
                sold_roll = Convert.ToInt32(reader_indica.GetString(0));
            }
            remaing_roll_indica = total_roll - sold_roll;
            lbl_remaining_nr_indica.Text = remaing_roll_indica.ToString();
            total_earned_indica = sold_roll * price_indica;
            lbl_total_earned_coffee_indica.Text = total_earned_indica.ToString();
            connection.Close();


            //for ruderails.....................................................................
            total_roll = 500;
            lbl_total_roll_ruderails.Text = total_roll.ToString();

            lbl_price_per_ruderails_info.Visible = true;
            lbl_price_per_ruderails.Visible = true;
            //start connection
            connection.Open();
            string count_ruderails_query = " Select count(Type)from coffee_shop where Type='Ruderails'";
            MySqlDataReader reader;
            MySqlCommand cmd = new MySqlCommand(count_ruderails_query, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sold_roll = Convert.ToInt32(reader.GetString(0));
            }
            remaing_roll_sativa = total_roll - sold_roll;
            lbl_remaing_roll_ruderails.Text = remaing_roll_sativa.ToString();
            total_earned_ruderails = sold_roll * price_ruderails;
            lbl_total_earned_coffee_ruderails.Text = total_earned_ruderails.ToString();
            connection.Close();

            total_earned_coffee_shop = total_earned_sativa + total_earned_indica + total_earned_ruderails;

            lbl_ttl_earned_coffee.Text = total_earned_coffee_shop.ToString();

            //inserting data into labels........................................
            lbl_Entrance_Amount.Text = (total_visitors * 35).ToString();
            // lbl_Paint_Ball_Amount.Text = (rent_paint_ball_suit * 30).ToString();
            lbl_coffee_amount.Text = total_earned_coffee_shop.ToString();
            lbl_Overall_total.Text = ((total_visitors * 35) + ((rent_paint_ball_suit + rent_paint_ball_suit_present) * 30) + total_earned_coffee_shop + total_earned_Camping + (total_Persian + total_Italiano + total_chinese)).ToString();
            //for food
           
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void lbl_Paint_Ball_Amount_Click(object sender, EventArgs e)
        {

        }

      






    }
}
