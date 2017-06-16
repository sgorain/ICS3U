using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Snehan Gorain, Period 4.
namespace dicegame
{
    public partial class Form1 : Form
    {
        Random dicenumber= new Random();
        int randomNumber;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            randomNumber = dicenumber.Next(1, 6);
            counter = 0;
            button1.Hide();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int guess = int.Parse(textBox1.Text);
            if (guess == randomNumber)
            {
                label5.Text = "You got it!";
                textBox1.Text = "";
                
            }
            else if(guess<randomNumber)
            {
                label5.Text = "Guess higher!";
                counter = counter + 1;
            }
            else
            {
                label5.Text="Guess lower";
                counter = counter + 1;
            }

            if (counter == 3)
            {
                label5.Text = "You are out of guesses!";
            }

            if(counter>3)
            {
                label5.Text="The game is finished. Try again!";
            }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            textBox1.Text = "";
            randomNumber = dicenumber.Next(1, 6);
            counter = 0;
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
