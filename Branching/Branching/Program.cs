using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemperature = 70;
            //int roomTemperature = 71;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Is is not exactly room temperature");
            //}

            //int currentTemperature = 70;
            //int roomTemperature = 71;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer thatn room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhh....something when wrong here");
            //}

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite numbner." : "You do not have an awesome favorite number";

            //Console.WriteLine(result);


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            

            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());
            int actWeight = 50;
            if (packWeight > actWeight)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }

            Console.WriteLine("Please enter package width:");
            int packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height:");
            int packHeight = Convert.ToInt32(Console.ReadLine());
            int actHeight = 50;
            if (packHeight > actHeight)
            {
                Console.WriteLine("Package to big to be shipped via Package Express");
            }

            Console.WriteLine("Please enter package length:");
            int packLength = Convert.ToInt32(Console.ReadLine());

            int sum = packWeight * packWidth * packHeight * packLength;
            Console.WriteLine(sum / 100);

            Console.WriteLine("Your estimated total for shipping is: $528.00");

            Console.ReadLine();
        }
    }
}
