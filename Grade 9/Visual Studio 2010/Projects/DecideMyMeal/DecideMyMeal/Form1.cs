using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecideMyMeal
{
    // Snehan Gorain
    public partial class Form1 : Form
    {
        int counter = 0;
        string finalMeal, description;
        int [] meals=new int[8];
        int roastLamb=0, roastBeef=1, pizza=2, hummus=3, parsnipSoup=4, cabbageSalad=5, kaleSalad=6, fruitsNuts=7;
        string[] question= new string[10];
        string[] radio1 = new string[10];
        string[] radio2 = new string[10];
        string[] radio3 = new string[10];
        string[] radio4 = new string[10];
        string[] radio5 = new string[10];

        int seconds = 15;
        int interval = 15;
    
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//Next Button
        {
           
            //Point system
            if (radioButton1.Checked)
            {
                meals[roastLamb] = meals[roastLamb] + 10;
                meals[roastBeef] = meals[roastBeef] + 9;
                meals[pizza] = meals[pizza] + 8;
                meals[hummus] = meals[hummus] + 8;
                meals[parsnipSoup] = meals[parsnipSoup] + 6;
                meals[cabbageSalad] = meals[cabbageSalad] + 4;
                meals[kaleSalad] = meals[kaleSalad] + 4;
                meals[fruitsNuts] = meals[fruitsNuts] + 0;

            }

            else if (radioButton2.Checked)
            {
                meals[roastLamb] = meals[roastLamb] + 80;
                meals[roastBeef]= meals[roastBeef] + 100;
                meals[pizza] = meals[pizza] + 90;
                meals[hummus] = meals[hummus] + 85;
                meals[parsnipSoup] = meals[parsnipSoup] + 75;
                meals[cabbageSalad] = meals[cabbageSalad] + 65;
                meals[kaleSalad] = meals[kaleSalad] + 60;
                meals[fruitsNuts] = meals[fruitsNuts] + 40;
            }

            else if (radioButton3.Checked)
            {
                meals[roastLamb] = meals[roastLamb] + 70;
                meals[roastBeef] = meals[roastBeef] + 60;
                meals[pizza] = meals[pizza] + 90;
                meals[hummus] = meals[hummus] + 85;
                meals[parsnipSoup] = meals[parsnipSoup] + 80;
                meals[cabbageSalad] = meals[cabbageSalad] + 70;
                meals[kaleSalad] = meals[kaleSalad] + 75;
                meals[fruitsNuts] = meals[fruitsNuts] + 50;
            }

            else if (radioButton4.Checked)
            {
                meals[roastLamb] = meals[roastLamb] + 50;
                meals[roastBeef] = meals[roastBeef] + 65;
                meals[pizza] = meals[pizza] + 70;
                meals[hummus] = meals[hummus] + 75;
                meals[parsnipSoup] = meals[parsnipSoup] + 80;
                meals[cabbageSalad] = meals[cabbageSalad] + 100;
                meals[kaleSalad] = meals[kaleSalad] + 90;
                meals[fruitsNuts] = meals[fruitsNuts] + 60;
            }

            else
            {
                meals[roastLamb] = meals[roastLamb] + 10;
                meals[roastBeef] = meals[roastBeef] + 50;
                meals[pizza] = meals[pizza] + 60;
                meals[hummus] = meals[hummus] + 65;
                meals[parsnipSoup] = meals[parsnipSoup] + 80;
                meals[cabbageSalad] = meals[cabbageSalad] + 85;
                meals[kaleSalad] = meals[kaleSalad] + 90;
                meals[fruitsNuts] = meals[fruitsNuts] + 100;
            }

     

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            counter++;
            if (counter >9)
            {
                MessageBox.Show("We have your meal suggestion!");
                textBox2.Text = description;
                textBox2.Show();
                groupBox1.Hide();
                label2.Show();
                label2.Text = finalMeal;
                textBox1.Hide();
                groupBox1.Hide();
                button1.Hide();
                countdownTimer.Stop();
              
            }

            else
            {
                textBox1.Text = question[counter];
                radioButton1.Text = radio1[counter];
                radioButton2.Text = radio2[counter];
                radioButton3.Text = radio3[counter];
                radioButton4.Text = radio4[counter];
                radioButton5.Text = radio5[counter];

            }
           
          
            //Meal selection
            if (meals.Max() == meals[0])
            {
                finalMeal = "Herb Crusted Roast Lamb";
                description = "A leg of lamb slowly roasted with rosemary, thyme, garlic and black pepper served with a coleslaw of cabbage, kale, turnips and carrots. This is served with a creamy sunflower dressing of sunflower paste, applecider vinegar, garlic, honey and smoked paprika.";
                Image imageAction = new Bitmap(Properties.Resources.roastlamb);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
              
            }

            else if (meals.Max() == meals[1])
            {
                finalMeal = "Roast Beef Boat";
                description = "Roasted beef sliced and served on a base of sunflower and alfalfa sprouts, arugula, sliced cucumbers, grilled peach halves(if in season) and carrots, generously toppled with chunks of creamy feta, walnuts and unsweetened cranberries.";
                Image imageAction = new Bitmap(Properties.Resources.beefsliced);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
              
            }

            else if (meals.Max() == meals[2])
            {
                finalMeal = "Eggza Focaccia";
                description = "A variety of grilled seasonal vegetables such as zucchinis, eggplants, bell peppers, or mushrooms with gouda, parmesan and blue cheese, beef salami, spinach and arugula on a thick omellette base.";
                Image imageAction = new Bitmap(Properties.Resources.eggza);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
                
            }

            else if (meals.Max() == meals[3])
            {
                finalMeal = "Hummus with assorted Vegetables";
                description = "A thick and coarse Hummus of chickpeas, tahini, salt, lemon juice and smoked paprika with garlic served with thinly sliced seasonal vegetables such as beets, cabbage, bell peppers or kohlrabi. This may also be served with Camembert or Haloumi cheese.";
                Image imageAction = new Bitmap(Properties.Resources.hummus);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
             
            }

            else if (meals.Max() == meals[4])
            {
                finalMeal = "Cream of Parsnip Soup";
                description = "Roasted parnsips, red beets, carrots, onions and garlic blended with chicken stock and simmered, generously seasoned with salt, pepper, thyme, rosemary, butter and chili flakes";
                Image imageAction = new Bitmap(Properties.Resources.parnipsoup);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
          
            }

            else if (meals.Max() == meals[5])
            {
                finalMeal = "Cabbage Jungle Salad";
                description = "Shredded cabbage with sliced seasonal vegetables such as beets, turnips, rutabagas, arugula, spinach, green beans or parsley mixed with fried egg-white strips and a creamy sunflower and pumpkin seed dressing with vingera, garlic, honey, pepper and smoked paprika. Generously garnished with chunks of creamy feta, dried prunes, barberries and walnuts";
                Image imageAction = new Bitmap(Properties.Resources.cabbagecalad);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
               
            }

            else if (meals.Max() == meals[6])
            {
                finalMeal = "Kale Jungle Salad";
                description = "Chopped kale with a creamy sunflower and pumpkin seed dressing with vinegar, garlic, honey, pepper and smoked paprika. Tossed with long strips of smoked salmon, bell peppers, julienned beet strips and generously garnished with grated parmesan and walnuts";
                Image imageAction = new Bitmap(Properties.Resources.kalesalad);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
              
            }

            else 
            {
                finalMeal = "Fruits and Nuts";
                description = "Seasonal fruits such as apples, apricots, plums or pears with nuts such as walnuts, almonds or pecans. A simple yet delicious snack to keep you going!";
                Image imageAction = new Bitmap(Properties.Resources.fuitnuts);
                if (counter > 9)
                {
                    pictureBox1.Image = imageAction;
                }
           
            }

            seconds = interval;
        }

      

        private void button3_Click(object sender, EventArgs e)//Begin Button
        {
            //Initializing questions and answer options
            question[0] = "When did you last eat?";
            radio1[0] = "Over eight hours ago";
            radio2[0] = "Between six and eight hours ago";
            radio3[0] = "Between four and six hours ago";
            radio4[0] = "Between two and four hours ago";
            radio5[0] = "Within the past two hours";

            question[1] = "How hungry are you from a scale of 1(very full) to 5(starving)?";
            radio1[1] = "5";
            radio2[1] = "4";
            radio3[1] = "3";
            radio4[1] = "2";
            radio5[1] = "1";

            question[2] = "What best describes what you are looking for right now in a meal?";
            radio1[2] = "Heavy and filling"; 
            radio2[2] = "A mix of various components"; 
            radio3[2] = "Rustic, filling and wholesome ingredients and falvours";
            radio4[2] = "Something warming and soothing";
            radio5[2] = "Fresh and light ingredients";

            question[2] = "What best describes what you are looking for right now in a meal?";
            radio1[2] = "Very heavy, filling and high calories";
            radio2[2] = "Not to heavy, but not very light. Somewhere in between";
            radio3[2] = "Rustic, filling and wholesome ingredients and flavours";
            radio4[2] = "Something warming, soothing and relaxing";
            radio5[2] = "Light and refreshing ingredients";

            question[3] = "What sounds best to you right now?";
            radio1[3] = "A chunk of red meat";
            radio2[3] = "Eggs and/or beans";
            radio3[3] = "A large variety of wholesome vegetables";
            radio4[3] = "A colourful salad";
            radio5[3] = "A quick and simple snack";

            question[4] = "Which macronutrients tend to keep you energetic and satisfied for the longest?";
            radio1[4] = "Proteins and fats";
            radio2[4] = "A mixture of many different macrnutrients (protein, fats and carbs)";
            radio3[4] = "Complex carbohydrates";
            radio4[4] = "A mixture of all the above";
            radio5[4] = "Anything";

            question[5] = "Of the following, which type of meal is most preferred?";
            radio1[5] = "Roasted meat";
            radio2[5] = "Dips";
            radio3[5] = "Roasted vegetables";
            radio4[5] = "Soups";
            radio5[5] = "Raw vegetables and fruits, such as in a salad";

            question[6] = "Upto how much money are you willing to spend on the ingredients for your meal?";
            radio1[6] = "All I want is a good meal, price shouldn't matter";
            radio2[6] = "Between $15 and $20";
            radio3[6] = "Between $10 and $15";
            radio4[6] = "Between $5 and $10";
            radio5[6] = "Under $5";

            question[7] = "Which of the following food groups do you most feel like?";
            radio1[7] = "Meat";
            radio2[7] = "A combination of many foods";
            radio3[7] = "Cooked vegetables";
            radio4[7] = "Legumes";
            radio5[7] = "Raw fruits and vegetables";

            question[8] = "What ratio of protein, carbohydrates and fats best suits you?";
            radio1[8] = "More protein and fats minimal carbohydrates"; 
            radio2[8] = "More protein and fats with carbohydrates"; 
            radio3[8] = "Equal proportions of fats proteins and carbohydrates";
            radio4[8] = "Mostly carbohydrates, with some protein and fat";
            radio5[8] = "Almost all carbohydrates, minimal protein and fats";

            question[9] = "Which of the following nutrients do you lack or could use more of?";
            radio1[9] = "Conjugated Linoleic Acid or/and Vitamin B12";
            radio2[9] = "Selenium, omega 3 or/and zinc";
            radio3[9] = "Iron, folate or/and and manganese";
            radio4[9] = "Fiber, magnesium or/and sulphur";
            radio5[9] = "Vitamin K2, Vitamin A, Vitamin C or/and Potassium"; 

            

            button3.Hide();

            textBox1.Text = question[0];
            radioButton1.Text = radio1[0];
            radioButton2.Text = radio2[0];
            radioButton3.Text = radio3[0];
            radioButton4.Text = radio4[0];
            radioButton5.Text = radio5[0];

            countdownTimer.Start();
      
        }

        private void button2_Click(object sender, EventArgs e)//Restart Button
        {
            counter = 0;

            meals[roastLamb] = 0;
            meals[roastBeef] = 0;
            meals[pizza] = 0;
            meals[hummus] = 0;
            meals[parsnipSoup] = 0;
            meals[cabbageSalad] = 0;
            meals[kaleSalad] = 0;
            meals[fruitsNuts] = 0;

           
            textBox2.Hide();
            textBox1.Show();
            groupBox1.Show();
            label2.Hide();
            button1.Show();

            Image defaultPicture = new Bitmap(Properties.Resources._111797838);
            pictureBox1.Image = defaultPicture;

            textBox1.Text = question[0];
            radioButton1.Text = radio1[0];
            radioButton2.Text = radio2[0];
            radioButton3.Text = radio3[0];
            radioButton4.Text = radio4[0];
            radioButton5.Text = radio5[0];

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            countdownTimer.Start();
            seconds = interval;

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
            {
                MessageBox.Show("Seems like you are taking a while! Choose the most appropriate answer.");
                seconds = interval;

            }
        }
      
    }
}
