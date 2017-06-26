using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            string input;
            do
            {
                Console.WriteLine("Enter Length:");
                string length = Console.ReadLine();
                Console.WriteLine("Enter Width: ");
                string width = Console.ReadLine();

                double x = double.Parse(length);
                double y = double.Parse(width);
                double area = x * y;
                Console.WriteLine("Area: " + area);
                double perimeter = ((2 * x) + (2 * y));
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("Continue? (y/n): ");
               input = Console.ReadLine();
            }

            while (input == "y");

            
 



        }

    }
}


        
    
