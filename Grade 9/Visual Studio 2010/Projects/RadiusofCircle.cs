using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Please enter the radius of the circle.");
            radius = double.Parse(Console.ReadLine());
            area=(Math.PI * Math.Pow(radius, 2));
            Console.WriteLine("Your circle, with a radius of " + radius+ " has an area of "+ area +" square units.");
            Console.WriteLine("Press enter to exit");
    
            Console.ReadLine();



        }
    }
}
