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
            clickCounter++;
            if (clickCounter >= MAX_Clicks)
            {
                button1.Enabled = false;
            }

            string text = cashamounttxt.Text;
            int number = int.Parse(text);
            number = number - 5;
            

            int userNum = Convert.ToInt32(userNumberTxb.Text);
            int systemNumber = rand.Next(1,31);
            if (cashamounttxt.Text.Length <= 2)
            {

            if (userNum == systemNumber)
            {
                resultslbl.Text = "WON";
            }
            else
            {
                resultslbl.Text = "LOST";
            }
            }
            else
            {
                MessageBox.Show("Minimum amount R10.00");
            }
            if(number == 0)
            {
                MessageBox.Show("Insert more money");
            }
            cashamountlbl.Text = number.ToString();
            jackpotNumber.Text = systemNumber.ToString();

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter >= MAX_Clicks)
            {
                button1.Enabled = false;
            }
            int userNum = Convert.ToInt32(userNumberTxb.Text);
            int systemNumber = rand.Next(1, 31);

            if (userNum == systemNumber)
            {
                resultslbl.Text = "WON";
            }
            else
            {
                resultslbl.Text = "LOST";
            }

            jackpotNumber.Text = systemNumber.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter >= MAX_Clicks)
            {
                button1.Enabled = false;
            }
            int userNum = Convert.ToInt32(userNumberTxb.Text);
            int systemNumber = rand.Next(1, 31);

            if (userNum == systemNumber)
            {
                resultslbl.Text = "WON";
            }
            else
            {
                resultslbl.Text = "LOST";
            }

            jackpotNumber.Text = systemNumber.ToString();

        }


    }
}
