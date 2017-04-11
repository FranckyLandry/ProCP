using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pain_Ball
{
    public partial class Form1 : Form
    {
        bool radiobutton;
        int number;
        int own_Amount;
        string value = "";
        bool isChecked;
        public Form1()
        {
            InitializeComponent();
            gpOwnsuit.Visible = false;
            gpRentingSuit.Visible = false;
            btn_Return.Enabled = true;
            btPay.Enabled = true;

        }



        private void rdOwnsuit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOwnsuit.Checked == true)
            {
                radiobutton = true;
                lbl_Msg.Text = "10 Euro for gun and 2 sets of bullets.";
                gpOwnsuit.Visible = true;
                gpRentingSuit.Visible = false;
                rdRentSuit.Checked = false;
                btPay.Enabled = true;
                btn_Return.Enabled = true;



            }
            else
                if (rdRentSuit.Checked == true)
                {
                    radiobutton = false;
                    lbl_Msg.Text = "30 Euro ,20 for Suit and 10 for gun with 2 sets of bullets ";
                    gpRentingSuit.Visible = true;
                    gpOwnsuit.Visible = false;
                    rdOwnsuit.Checked = false;
                    btPay.Enabled = true;
                    btn_Return.Enabled = true;

                }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdOwnsuit.Checked)
                {
                    isChecked = rdOwnsuit.Checked;
                    if (isChecked)
                        value = "YES";
                    All_Details details = new All_Details();
                    details.Show();


                    details.Currency = Convert.ToInt32(lbl_Amount_Show.Text);
                    details.Quantity = Convert.ToInt32(tb_Gun_set.Text);
                    details.MyRadiobutton = radiobutton;
                    details.Type = value;

                }
                else
                    if (rdRentSuit.Checked)
                    {
                        isChecked = rdRentSuit.Checked;
                        if (isChecked)
                            value = "NO";

                        lbl_gun_set.Enabled = false;
                        lbl_Amount_Show.Enabled = false;
                        All_Details details = new All_Details();
                        details.Show();
                        details.Currency = Convert.ToInt32(lbAmount.Text);
                        details.Quantity = Convert.ToInt32(tbPaintBallSuit.Text);
                        details.MyRadiobutton = radiobutton;
                        details.Type = value;
                    }

            }
            catch (FormatException)
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renting_details renting = new Renting_details();
            renting.Show();



        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(tb_Gun_set.Text) <= 0)
                {
                    MessageBox.Show("Please put the desired number more than 0!");
                }
                else
                {
                    number = Convert.ToInt32(tb_Gun_set.Text);
                    own_Amount = number * 10;
                    lbl_Amount_Show.Text = own_Amount.ToString();
                    btPay.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_Calculate_Rent_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(tbPaintBallSuit.Text) <= 0)
                {
                    MessageBox.Show("Please put the desired number more than 0!");
                }
                else
                {
                    number = Convert.ToInt32(tbPaintBallSuit.Text);
                    int Rent_Amount = number * 30;
                    lbAmount.Text = Rent_Amount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdRentSuit_CheckedChanged(object sender, EventArgs e)
        {
            gpRentingSuit.Visible = true;
            lbl_Msg.Text = "30 Euro ,20 for Suit and 10 for gun with 2 sets of bullets ";
            btPay.Enabled = true;
            btn_Return.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btPay.Enabled = false;
            btn_Return.Enabled = false;
        }
    }
}
