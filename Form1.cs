using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callllculator_finall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculation cal = new calculation();
        public string displaynum;
        private void one_Click(object sender, EventArgs e)
        {
            displaynum += 1;
            display.Text = (displaynum);
        }

        private void two_Click(object sender, EventArgs e)
        {
            displaynum += 2;
            display.Text = (displaynum);
        }

        private void three_Click(object sender, EventArgs e)
        {
            displaynum += 3;
            display.Text = (displaynum);
        }

        private void four_Click(object sender, EventArgs e)
        {
            displaynum += 4;
            display.Text = (displaynum);
        }

        private void five_Click(object sender, EventArgs e)
        {
            displaynum += 5;
            display.Text = (displaynum);
        }

        private void six_Click(object sender, EventArgs e)
        {
            displaynum += 6;
            display.Text = (displaynum);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            displaynum += 7;
            display.Text = (displaynum);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            displaynum += 8;
            display.Text = (displaynum);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            displaynum += 9;
            display.Text = (displaynum);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (displaynum == "0")
            {
                display.Text = " 0";
                displaynum = "";
                
            }
            else
            {
                displaynum += 0;
                display.Text = (displaynum);
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            cal.Fnum = double.Parse(displaynum);
            cal.Opr = "+";
            displaynum = "";

        }

        private void divide_Click(object sender, EventArgs e)
        {
            cal.Fnum = double.Parse(displaynum);
            cal.Opr = "/";
            displaynum = "";


        }

        private void subtract_Click(object sender, EventArgs e)
        {
            cal.Fnum = double.Parse(displaynum);
            cal.Opr = "-";
            displaynum = "";


        }

        private void multiply_Click(object sender, EventArgs e)
        {
            cal.Fnum = double.Parse(displaynum);
            cal.Opr = "*";
            displaynum = "";


        }

        private void equal_Click(object sender, EventArgs e)
        {
            cal.Snum = double.Parse(displaynum);
            cal.calculate();
            display.Text = cal.Result.ToString();
            
            displaynum =" ";
           
          
        }

        private void dot_Click(object sender, EventArgs e)
        {
            displaynum += ".";
            display.Text = (displaynum);
        }
    }
}
