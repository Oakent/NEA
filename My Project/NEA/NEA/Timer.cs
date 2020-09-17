using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            scrambleLabel.Text = "";
            string[] moves = { "U", "D", "L", "R", "F", "B", };
            string[] modifier = { "", "'", "2" };
            int scrambleLength;
            Random ran = new Random();
            scrambleLength = ran.Next(18, 23);
            int move = ran.Next(0, 6);
            int mod = ran.Next(0, 3);
            string chosenmove = "p";
            for (int i = 0; i < scrambleLength; i++)
            {
                move = ran.Next(0, 6);
                mod = ran.Next(0, 3);
                while (chosenmove == moves[move])
                {
                    move = ran.Next(0, 6);
                }
                chosenmove = moves[move];
                if (chosenmove == "p")
                {

                }
                else
                {
                    scrambleLabel.Text += (chosenmove + modifier[mod] + " ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scrambleLabel.Text = "";
            string[] moves = { "U", "D", "L", "R", "F", "B", };
            string[] modifier = { "", "'", "2" };
            int scrambleLength;
            Random ran = new Random();
            scrambleLength = ran.Next(18, 23);
            int move = ran.Next(0, 6);
            int mod = ran.Next(0, 3);
            string chosenmove = "p";
            for (int i = 0; i < scrambleLength; i++)
            {
                move = ran.Next(0, 6);
                mod = ran.Next(0, 3);
                while (chosenmove == moves[move])
                {
                    move = ran.Next(0, 6);
                }
                chosenmove = moves[move];
                if (chosenmove == "p")
                {

                }
                else
                {
                    scrambleLabel.Text+=(chosenmove + modifier[mod] + " ");
                }
            }
        }

        private void scrambleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
