using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int principal = 10000;
            int years = 20;
            double interest;
            
            textBox1.Text = "Interest(%)            Simple Interest         Compound Interest" + Environment.NewLine; 

            for (interest = 1; interest <= 10; interest = interest + 1)
            {
                double simple = principal * interest / 100.0 * years;
                double compound = principal*((Math.Pow(1+interest/100.0,years))-1);

                textBox1.Text = textBox1.Text +interest+"                            "+simple.ToString("c") + "               "+ compound.ToString("c")+Environment.NewLine;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
