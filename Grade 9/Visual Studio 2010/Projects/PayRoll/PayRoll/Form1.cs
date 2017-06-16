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
    // Snehan Gorain, Mr Yasui, Period 4. Dec.4
    
    public partial class Form1 : Form
    {
        int age, hours;
        double salary, pay, yearlypay, tax;
        string name;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            int hours = int.Parse(textBox2.Text);
            name = textBox3.Text;

            if (hours > 28)
            {
                salary = 11.25;
            }
            else
            {
                salary = 10.55;
            }

            if (age >= 18)
            {
                salary = 11.25;
            }

            pay = salary * hours;
            yearlypay = pay * 40;

            if (yearlypay <= 44701)
            {
                tax = yearlypay - yearlypay * 0.15;
            }
            else if (yearlypay <= 89401)
            {
                tax = yearlypay - 44701 * 0.15 - (yearlypay - 44700) * 0.22;
            }
            else if (yearlypay <= 138586)
            {
                tax = yearlypay - 44701 * 0.15 - 44700 * 0.22 - (yearlypay - 49185 * 0.26);
            }
            else
            {
                tax = yearlypay - 44701 * 0.15 - 44700 * 0.22 - 49185 * 0.26 - (yearlypay - 138586) * 0.29;
            }

            label9.Text = "Hi " + name + ", here is your PayRoll report!";
            
            if(hours>60)
            {
                label10.Text = "However, you should not be working over 60 hours!";
            }
            label5.Text = "Your weekly pay is $" + Math.Round(pay, 2);
            label6.Text = " Your monthly pay is $" + Math.Round(pay * 4, 2);
            label7.Text="Your estimated yearly pay is $" + Math.Round(yearlypay, 2);
            label8.Text = "Your estimated yearly with tax is $" + Math.Round(tax, 2);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
