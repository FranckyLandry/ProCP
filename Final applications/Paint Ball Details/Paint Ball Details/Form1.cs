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

namespace Paint_Ball_Details
{
    public partial class Form1 : Form
    {
        RFID rfid;
        string rfid_number_team_leader;
        string rfid_number_members;
        string Client_detail;
        string team_member_name;
        string team_leader_name;
        string formatForMySql_start_time;
        string formatForMySql_end_time;
        int score;
        string team_name;
        string result;
        DateTime starttime = DateTime.Now;
        DateTime endtime = DateTime.Now;
        bool Isleader;

        public Form1()
        {

            try
            {

                InitializeComponent();

                rfid = new RFID();
                rfid.Tag += new TagEventHandler(ProcessThisTag);
                if (Convert.ToInt32(tbScore.Text) > 0)
                {
                    score = Convert.ToInt32(tbScore.Text);
                }
                score = 0;
                team_name = tb_team_name.Text;
                result = tbWinOrLose.Text;

            }
            catch (PhidgetException)
            {
                MessageBox.Show("error at start-up.");
            }

        }
        private void ProcessThisTag(object sender, TagEventArgs e)
        {
           
            rfid_number_team_leader = e.Tag.ToString();
           
            rfid_number_members = e.Tag.ToString();
            Console.Beep();
            MySqlException error = null;
            DatabaseConnection.ConnectToDB(ref error);

            double money=0;

            //Client_detail = DatabaseConnection.GetClientDetail(rfid_number_team_leader, out money);
            List<string>[] myArrayList = DatabaseConnection.GetClientDetail(rfid_number_team_leader, money);
            List<string>nmes = myArrayList[0];
            foreach (string s in nmes)
            {
                tb_team_leader_name.Text = s;
               
            }

            if (Isleader == true)
            {

                team_leader_name = Client_detail;
                tb_team_leader_name.Text = team_leader_name;
                lbl_team_leader_rfid_nr.Text = rfid_number_team_leader;
            }
            else
            {
               // listbTeamMemmber.Items.Clear();


                team_member_name = Client_detail;
                if (team_member_name != listbTeamMemmber.Items.ToString())
                {
                    listbTeamMemmber.Items.Add(team_member_name);
                }
                else
                {
                    MessageBox.Show("Nae already exist");
                }
            }
            

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
            // rfid.close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scan for members");
            Isleader = false;
            String connectionInfo1 = "Server=athena01.fhict.local;" +
                                 "Database=dbi297937;" +
                                 "user id=dbi297937;" +
                                 "Password=xdl2xDpHkC;" +
                                 "connect timeout=30;";

            //update event_visitors table.....
            MySqlConnection connection1 = new MySqlConnection(connectionInfo1);

            //update event_visitors table
            string Query1 = " Select distinct Client_First_Name from event_visitors where RFID_Nr='" + rfid_number_members + "'";
            MySqlCommand cmdDataBase1 = new MySqlCommand(Query1, connection1);
            MySqlDataReader myReader1;

            try
            {
                connection1.Open();
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    team_member_name = myReader1.GetString(0);
                }
               // listbTeamMemmber.Items.Add(team_member_name.ToString());
                connection1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Scan_For_team_leader_Click(object sender, EventArgs e)
        {
            Isleader = true;
            try
            {
                rfid.open();
                rfid.waitForAttachment(3000);
                rfid.Antenna = true;
                rfid.LED = true;
                MessageBox.Show("Scanner Start Working");


            }
            catch (PhidgetException) { MessageBox.Show("Please Plug in RFID Reader First...\n OR\n Check your RFID Connection"); }
            // rfid.close();
        }

        private void btStartTime_Click(object sender, EventArgs e)
        {
            formatForMySql_start_time = starttime.ToString("yyyy-MM-dd HH:mm:ss");
            lbl_Start_time.Text = starttime.ToString();

        }

        private void btEndTime_Click(object sender, EventArgs e)
        {
            formatForMySql_end_time = endtime.ToString("yyyy-MM-dd HH:mm:ss");
            lbl_end_time.Text = endtime.ToString();

        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbScore.Text) > 0)
            {
                score = Convert.ToInt32(tbScore.Text);
            }
            
            String connectionInfo = "Server=athena01.fhict.local;" +
                                "Database=dbi297937;" +
                                "user id=dbi297937;" +
                                "Password=xdl2xDpHkC;" +
                                "connect timeout=30;";

            //update event_visitors table.....
            MySqlConnection connection = new MySqlConnection(connectionInfo);


            //insert in Coffie shop table

            connection.Open();
            string NewQuery = " Insert into paint_ball_game_detail (Team_Name,Start_Time_Of_the_Game,Team_Leader,End_Time_Of_the_game,Score,Result) values('" + team_name + "','" + formatForMySql_start_time + "','" + tb_team_leader_name.Text + "','" + formatForMySql_end_time + "','" + Convert.ToInt32(tbScore.Text) + "','" + tbWinOrLose.Text + "')";//+@RFID_Nr','@Type','@Weight','@Amount_Paid','@Name') ";
            MySqlCommand cmdDataBase1 = new MySqlCommand(NewQuery, connection);
            cmdDataBase1.ExecuteNonQuery();
            MessageBox.Show("Values Saved!");
            // MessageBox.Show("Inserted");
            connection.Close();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            //rfid.close();
        }
    }
}
