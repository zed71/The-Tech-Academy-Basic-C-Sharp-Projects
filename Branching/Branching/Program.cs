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


            //introduction
            Console.WriteLine("Welcome to Package Express. " +
                "Please follow the instructions below: ");
            Console.ReadLine();

            //takes weight input from user
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            //Checks if weight is too high
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. " +
                    "Have a good day.");
                Console.ReadLine();
            }
            //if the package is less than 50, continue with the process
            else
            {
                Console.WriteLine("Please enter the package width: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height: ");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                //checks the package meets the volume requirement
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                //if the package height is less than 50, continue with the process
                else
                {
                    //variable included in this 'else' statement because
                    //they are local to each block of the branches. 
                    //Next time, store globally....
                    int shippingCost = ((width * height * length) * weight) / 100;
                    Console.WriteLine("Your estimated shipping cost for this package " +
                        "is: $" + shippingCost + ".00 \nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
