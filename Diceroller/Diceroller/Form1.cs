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
    public partial class Form1 : Form
    {
        public Form1()
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

        }
}
