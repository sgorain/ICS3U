using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Turing
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName, age, pin, school, lastname, food, colour;//declares variable 
           
            Console.WriteLine("Hi there! Welcome to the Great Conversation");
            Console.WriteLine("So tell me first of all, what is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine(" Alright! Hello "+yourName+". I suggest you brace yourself for the conversation of your life.");
            Console.WriteLine("Tell me, how old are you? ");
            age = Console.ReadLine();
            Console.WriteLine("Oh yeah!!! Thats a fun age to be. I remember when I was "+ age.);
            Console.WriteLine("So, where do you go to school?");
            school = Console.ReadLine();
            Console.WriteLine("What is your favourite colour?");
            colour = Console.ReadLine();
            Console.WriteLine("And how much money do your parents ear??????");
            Console.WriteLine("ean");
            Console.WriteLine("What the fuck I cant spell today");
            Console.WriteLine("EARN");
            pin= Console.ReadLine();
            Console.WriteLine("HA!!!!! Poooooor..");
            Console.WriteLine("Okay sorry I take that back.");
            Console.WriteLine("Oh well, what's you last name ");
            lastname = Console.ReadLine();
            Console.WriteLine("and what did you eat last???");
            food= Console.ReadLine();
            Console.WriteLine("So let me get this straight" + yourName+ " "+ lastname+ ", you are" + age + " years old, you go to " + school + ", you like the colour" + colour + ", " and you ate" + food + ". You suck!!!")

            

            Console.ReadKey();
        }
    }
}
