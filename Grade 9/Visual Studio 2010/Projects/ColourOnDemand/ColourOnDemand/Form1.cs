using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColourOnDemand
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }

            if (radioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            if (radioButton3.Checked)
            {
                this.BackColor = Color.Green;
            }
            if (radioButton4.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            if (radioButton5.Checked)
            {
                this.BackColor = Color.Magenta;
            }
            if (radioButton6.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
