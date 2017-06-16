using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuringTest
{
    class TuringTest
    {
        static void Main(string[] args)
        {string yourName, age, city, school, subject, pin, lastname, answer, food, colour, tv;
           
            Console.WriteLine("Hi there!");
            Console.WriteLine("So tell me first of all, what is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine(" Alright! Hello "+yourName+". I suggest you brace yourself for the conversation of your life.");
            Console.WriteLine("Tell me, how old are you? ");
            age = Console.ReadLine();
            Console.WriteLine("Oh yeah!!! Thats a fun age to be. I remember when I was "+ age);
            Console.WriteLine("So, where do you go to school?");
            school = Console.ReadLine();
            Console.WriteLine("By the way do you know the temperature outside right now? If so tell me please");
            double temp= double.Parse(Console.ReadLine());
            Console.WriteLine("Really? It feels like " + temp * 2.5 + " degrees!");
            Console.WriteLine("What is your favourite colour?");
            colour = Console.ReadLine();
            if (colour == "red" || colour == "blue" || colour == "black")
            
                Console.WriteLine(colour + " is a nice colour. I like it too");
            
            else if (colour == "gray" || colour == "black")
                Console.WriteLine(colour + " is not a bad colour");

            else
                Console.WriteLine(colour + " is not one of my favourites");
            
            
            Console.WriteLine("And how much money do your parents ear??????");
            Console.WriteLine("ean");
            Console.WriteLine("I cant spell today");
            Console.WriteLine("EARN");
            pin= (Console.ReadLine());
            if(double.Parse(pin) >= 100000)
            {
                Console.WriteLine("Nice!");
            }
                
            
            else if(double.Parse(pin) <= 50000)
                Console.WriteLine("So you aren't rich....");
            else
                Console.WriteLine("Okay so you are average, not bad");

            Console.WriteLine("Okay that was not a necessary question. Anyways, what's your last name ");
            lastname = Console.ReadLine();
            Console.WriteLine("and what did you eat last???");
            food= Console.ReadLine();
            Console.WriteLine("Oh I hate " + food+ ". No offence");
            Console.WriteLine("Which city or town were you born in?");
            city=Console.ReadLine();
            if (city == "Toronto" || city == "toronto")

                Console.WriteLine("Alright, so you were born here");

            else if (city == "calgary" || city == "Calgary")
                Console.WriteLine("I have never been to " + city);

            else

                Console.WriteLine("Really? " + city + " ìs such an amazing place. The people there are so warm and friendly! What's your favourite subject at school?");
            
            Console.WriteLine("So whats your favourite subject at school?");    
            subject = Console.ReadLine();
            Console.WriteLine(subject+" is my worse subject. I personally find it pretty boring. So what tv show do you watch the most?");
            tv=Console.ReadLine();
            Console.WriteLine(tv+ "? I haven't heard of that one. I dont really watch many TV shows. Do you watch Masterchef?");
            answer = Console.ReadLine();
            if(answer == "yes")
            {
                Console.WriteLine("Me 2! I love that TV show");
            }
            else
            {
                Console.WriteLine("You should watch it, it is really great.");
            }
            Console.WriteLine("Okay. It have to go now. nice talking to you. Bye");
            
            Console.ReadKey(); 
        }
    }
}
