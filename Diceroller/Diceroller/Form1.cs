using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diceroller
{
    public partial class clear : Form
    {
        public clear()
        {
            InitializeComponent();
        }

        private void d6_Click(object sender, EventArgs e)
        {
            
            var random = new Random();
            int total=0;
            resultD6.Text="";
            for (int i = 0; i < numericD6.Value; i++)
            {
                int die = (random.Next(6) + 1);
               resultD6.Text += die.ToString()+" ";
               total += die;  
                
            }

            
            totalD6.Text = total.ToString();
        }

        private void d8_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int total = 0;
            resultD8.Text = "";
            for (int i = 0; i < numericD8.Value; i++)
            {
                int die = (random.Next(8) + 1);
                resultD8.Text += die.ToString() + " ";
                total += die;

            }

            totalD8.Text = total.ToString();
        }

        private void d10_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int total = 0;
            resultD10.Text = "";
            for (int i = 0; i < numericD10.Value; i++)
            {
                int die = (random.Next(10) + 1);
                resultD10.Text += die.ToString() + " ";
                total += die;

            }

            totalD10.Text = total.ToString();
        }

        private void d12_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int total = 0;
            resultD12.Text = "";
            for (int i = 0; i < numericD12.Value; i++)
            {
                int die = (random.Next(12) + 1);
                resultD12.Text += die.ToString() + " ";
                total += die;

            }

            totalD12.Text = total.ToString();
        }

        private void d20_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int total = 0;
            resultD20.Text = "";
            for (int i = 0; i < numericD20.Value; i++)
            {
                int die = (random.Next(20) + 1);
                resultD20.Text += die.ToString() + " ";
                total += die;

            }

            totalD20.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultD6.Text = "";
            resultD8.Text = "";
            resultD10.Text = "";
            resultD12.Text = "";
            resultD20.Text = "";

            totalD6.Text = "";
            totalD8.Text = "";
            totalD10.Text = "";
            totalD12.Text = "";
            totalD20.Text = "";
        }


        }
}
