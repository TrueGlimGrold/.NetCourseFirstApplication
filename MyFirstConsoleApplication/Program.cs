using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Luke Bullock";
            string myLocation = "Lethbridge, Alberta, Canada";

            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {myLocation}");

            Console.WriteLine("Current Date: 14/01/2024");

            Console.WriteLine("Days till Christmas: 346");

            Console.WriteLine(@"
---
");

            // Project from this weeks readings.
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("What is the width of the wood? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the length of the wood? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine(@"
---
");

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();


        }
    }
}
