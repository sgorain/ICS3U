using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace investmentprogram
{
    public partial class Form1 : Form
    {
        string name, simple, compound;
        double principal, interest;
        int years;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            principal = double.Parse(textBox2.Text);
            years= int.Parse(textBox3.Text);
            interest = double.Parse(textBox4.Text);

            interest = interest / 100;

            simple = (principal * interest * years+principal).ToString("c");
            compound = (principal * (Math.Pow(1 + interest, years) - 1)+principal).ToString("c");

            textBox5.Text = "Hello "+name+Environment.NewLine;
            textBox5.Text = textBox5.Text + "Your investment will grow to " + simple + " from simple interest" + Environment.NewLine; 
            textBox5.Text=textBox5.Text+"Your investment will grow to " + compound + " from compound interest";


            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = ""; 
            textBox5.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
