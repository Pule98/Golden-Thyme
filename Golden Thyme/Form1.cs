using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden_Thyme
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private int clickCounter = 0;
        private const int MAX_Clicks = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            string text = cashamounttxt.Text;
            int number = int.Parse(text);


            if (number <= 0)
            {
                MessageBox.Show("Insert more money");
                return;
            }



         
            int userNum = Convert.ToInt32(userNumberTxb.Text);
            int systemNumber = rand.Next(1, 11);

            if (number >= 5)
            { 
               
                if (userNum == systemNumber)
                {
                    resultslbl.Text = "WON";
                    number += 5;
                }
                else
                {
                    resultslbl.Text = "LOST";
                    number -= 5;
                }
            }
            else
            {
                MessageBox.Show("Minimum amount R10.00");
                button1.Enabled = false;
                return;
            }

            if (number == 0)
            {
                MessageBox.Show("Insert more money");
                button1.Enabled = false;
            }

            jackpotNumber.Text = systemNumber.ToString();
             cashamounttxt.Text = number.ToString();
            cashamountlbl.Text = number.ToString();
            cashamounttxt.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string text = cashamounttxt.Text;
            int number = int.Parse(text);


            if (number <= 0)
            {
                MessageBox.Show("Insert more money");
                return;
            }




            int userNum = Convert.ToInt32(userNumberTxb.Text);
            int systemNumber = rand.Next(1, 11);

            if (number >= 10)
            {

                if (userNum == systemNumber)
                {
                    resultslbl.Text = "WON";
                    number += 10;
                }
                else
                {
                    resultslbl.Text = "LOST";
                    number -= 10;
                }
            }
            else
            {
                MessageBox.Show("Minimum amount R15.00");
                button1.Enabled = false;
                return;
            }

            if (number == 0)
            {
                MessageBox.Show("Insert more money");
                button1.Enabled = false;
            }

            jackpotNumber.Text = systemNumber.ToString();
            cashamounttxt.Text = number.ToString();
            cashamountlbl.Text = number.ToString();
            cashamounttxt.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string text = cashamounttxt.Text;
            int number = int.Parse(text);


            if (number <= 0)
            {
                MessageBox.Show("Insert more money");
                return;
            }




            int userNum = Convert.ToInt32(userNumberTxb.Text);
            int systemNumber = rand.Next(1, 11);

            if (number >= 15)
            {

                if (userNum == systemNumber)
                {
                    resultslbl.Text = "WON";
                    number += 15;
                }
                else
                {
                    resultslbl.Text = "LOST";
                    number -= 15;
                }
            }
            else
            {
                MessageBox.Show("Minimum amount R20.00");
                button1.Enabled = false;
                return;
            }

            if (number == 0)
            {
                MessageBox.Show("Insert more money");
                button1.Enabled = false;
            }

            jackpotNumber.Text = systemNumber.ToString();
            cashamounttxt.Text = number.ToString();
            cashamountlbl.Text = number.ToString();
            cashamounttxt.Enabled = false;
        }


    }
}
