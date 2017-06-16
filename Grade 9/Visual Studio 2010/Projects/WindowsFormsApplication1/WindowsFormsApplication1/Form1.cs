using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double principle, finalgoal, finalamount;
        int years, interest;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principle = double.Parse(textBox1.Text);
            int interest = int.Parse(textBox2.Text);

            years = 1;

            finalgoal = principle * 2.0;
            finalamount=principle*((Math.Pow(1+interest/100/12,years*12)-1));
            

            while(finalgoal>=finalamount)
            {
                years=years+1;
               
            }
            
            textBox3.Text = "It will take "+years;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)//output
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//principle
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)// Interest rate
        {

        }

        private void button2_Click(object sender, EventArgs e)//Clear
        {

        }

        private void button3_Click(object sender, EventArgs e)//Close
        {
            this.Close();
        }
    }
}
