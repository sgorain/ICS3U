using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RichorPoor
{
    class Program
    {
        static void Main(string[] args)
        {
            string vola, rclass;
            Console.WriteLine("Hi there. I bet you are wondering whether you are rich, poor, really poor, really rich or somewhere in between");
            Console.WriteLine("Please enter your last name");
            string name=Console.ReadLine();
            Console.WriteLine("Please enter your annual gross income.");
            double income = double.Parse(Console.ReadLine());
            if(income >= 150000)
                rclass= "rich";
            else if(income <=50000)
                rclass="poor";

            else
                rclass="middle class";

            Console.WriteLine("Are you a volunteer?");
            string vol = Console.ReadLine();
            

            Console.WriteLine("Please enter your title");
            string title=Console.ReadLine();

            Console.WriteLine("Alright " + title+ " " + name +", you earn $" +income+" a year, thus, you are " + rclass+".");

           if (vol == "Yes" || vol == "Yeah" || vol == "yes" || vol == "yeah")
               Console.WriteLine("However, you are a volunteer, thus you should not be earning an income");
            
            else 
                Console.WriteLine("Thank you");



           Console.ReadLine();



        }
    }
}
