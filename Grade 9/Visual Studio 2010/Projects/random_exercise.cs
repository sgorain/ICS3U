using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int dice = number.Next(1, 7);
            Console.WriteLine(dice.ToString("f"));
            Console.ReadKey();
            
        }
    }
}
