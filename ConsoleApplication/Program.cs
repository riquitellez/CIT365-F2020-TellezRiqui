using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 2
            string myName = "Riqui Tellez";
            string location = "Spain";

            //Part 3
            Console.WriteLine($"My name is {myName}, I'm from {location}");

            //Part 4
            Console.WriteLine(DateTime.Now.ToString("MM-dd-yyyy"));

            //Part 5
            DateTime christmas = new DateTime(2020, 12, 25);
            DateTime today = DateTime.Now;
            int totalDays = (int)(christmas - today).TotalDays;
            Console.WriteLine(totalDays);

            //Part 6
            double width, height, woodLength, glassArea; 
            string widthString, heightString;

            Console.WriteLine("Input Width");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Input height");
            heightString = Console.ReadLine(); 
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadKey();

        }
    }
}
