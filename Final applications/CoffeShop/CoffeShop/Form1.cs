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

namespace CoffeShop
{
    public partial class Form1 : Form
    {
        int amount;
        int weight;
        int calculate;
        string value = "";
        bool isChecked;
        public Form1()
        {
            InitializeComponent();
            lbl_Amount_Show.Enabled = false;
            lbl_Amount_To_Pay.Enabled = false;
            lbl_total_Weight.Enabled = false;
            btn_Calculate.Enabled = false;
            btn_Clear.Enabled = false;
            btn_Pay.Enabled = false;
            tb_Weight.Enabled = false;
            lbl_Note.Enabled = false;
            lbl_Euro.Enabled = false;
        }

        public void Enabled_True()
        {
            lbl_Amount_Show.Enabled = true;
            lbl_Amount_To_Pay.Enabled = true;
            lbl_total_Weight.Enabled = true;
            btn_Calculate.Enabled = true;
            btn_Clear.Enabled = true;
            btn_Pay.Enabled = false;
            tb_Weight.Enabled = true;
            lbl_Note.Enabled = true;
            lbl_Euro.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoffeeShopKassa coffeeShopKassa = new CoffeeShopKassa();
            coffeeShopKassa.Show();
            coffeeShopKassa.Currency = Convert.ToInt32(calculate.ToString());
            coffeeShopKassa.Weight = weight;
            coffeeShopKassa.Type = value;

        }

        private void rbtn_Sativa_CheckedChanged(object sender, EventArgs e)
        {
            Enabled_True();
            isChecked = rbtn_Sativa.Checked;
            if (isChecked)
                value = rbtn_Sativa.Text;
            lbl_Per_Roll.Text = "Per Roll 7 Euro";
        }

        private void rbtn_Indica_CheckedChanged(object sender, EventArgs e)
        {
            Enabled_True();
            isChecked = rbtn_Indica.Checked;
            if (isChecked)
                value = rbtn_Indica.Text;
            lbl_Per_Roll.Text = "Per Roll 8 Euro";
        }

        private void rbtn_Ruderalis_CheckedChanged(object sender, EventArgs e)
        {
            Enabled_True();
            isChecked = rbtn_Ruderalis.Checked;
            if (isChecked)
                value = rbtn_Ruderalis.Text;
            lbl_Per_Roll.Text = "Per Roll 9 Euro";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Weight.Clear();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tb_Weight.Text) <= 0)
                {
                    MessageBox.Show("Please put the desired number greater than 0");
                }
                else
                {
                    if (rbtn_Sativa.Checked == true)
                    {
                        amount = 7;
                        weight = Convert.ToInt32(tb_Weight.Text);
                        calculate = weight * amount;
                        lbl_Amount_Show.Text = calculate.ToString();
                        tb_Weight.Clear();
                    }
                    else if (rbtn_Indica.Checked == true)
                    {
                        amount = 8;

                        weight = Convert.ToInt32(tb_Weight.Text);
                        calculate = weight * amount;
                        lbl_Amount_Show.Text = calculate.ToString();
                        tb_Weight.Clear();

                    }
                    else
                    {
                        amount = 9;
                        weight = Convert.ToInt32(tb_Weight.Text);
                        calculate = weight * amount;
                        lbl_Amount_Show.Text = calculate.ToString();
                        tb_Weight.Clear();

                    }
                    btn_Pay.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
