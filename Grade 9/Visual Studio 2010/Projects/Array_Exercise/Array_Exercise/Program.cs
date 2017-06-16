using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // entriesDesired, numbers=array name, 
            Console.WriteLine("How many entries would you like to enter?");
            int entriesDesired= int.Parse(Console.ReadLine());
            int[] numbers = new int[entriesDesired];

            for(int entries=1;entries<numbers.Length+1; entries++)
            {
                Console.WriteLine("Number"+entries);
                numbers[entries-1]=int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The entries in the order entered:");

            for (int counter = 0; counter < numbers.Length; counter++)
            {
                Console.WriteLine(numbers[counter]);
            }
            Console.WriteLine("The entries in their reverse sequence:");

            for (int counter = numbers.Length-1; counter > -1; counter = counter - 1)
            {
                Console.WriteLine(numbers[counter]);
            }

            Console.WriteLine("The squares of all the entries:");

            for(int counter=0; counter<numbers.Length; counter++)
            {
                Console.WriteLine(Math.Pow(numbers[counter],2));
            }

            Console.WriteLine("The sum of all the entries:");

            int sum = 0;
            for (int counter = 0; counter < numbers.Length; counter++)
            {
                sum = sum + numbers[counter];
            }
            Console.WriteLine(sum);

            Console.WriteLine("The average of all the entries:");

            double average = sum / numbers.Length;
            Console.WriteLine(average);

            Console.WriteLine("The minimum number entered:");
            Console.WriteLine(numbers.Min());

           Console.WriteLine("The maximum number entered:");
           Console.WriteLine(numbers.Max());

           Console.WriteLine("The new array where each number is worth twice its original amount");
           int[] numbers2 = new int[numbers.Length];

           for (int counter = 0; counter < numbers.Length; counter++)
           {
               numbers2[counter] = numbers[counter] * 2;
               Console.WriteLine(numbers2[counter]);
           }
        


                Console.ReadKey();


        }
    }
}
