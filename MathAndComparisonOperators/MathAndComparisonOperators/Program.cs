using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotions = 200 / 3;
            //Console.WriteLine(quotions);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueorFalse = 12 > 5;
            //Console.WriteLine(trueorFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            ////bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Enter a number to multiply by 50");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int X = 50;
            double sum = userNumber * X;
            Console.WriteLine(sum);
            Console.ReadLine();

            Console.WriteLine("Enter a number to multiply by 25");
            int userNumbers = Convert.ToInt32(Console.ReadLine());
            int Y = 25;
            double sums = userNumbers * Y;
            Console.WriteLine(sums);
            Console.ReadLine();

            Console.WriteLine("Enter a number to divide by 12.5");
            int userNumbe = Convert.ToInt32(Console.ReadLine());
            double Z = 12.5;
            double sumi = userNumbe / Z;
            Console.WriteLine(sumi);
            Console.ReadLine();

            Console.WriteLine("Enter a number to check greater than 50");
            int userNumb = Convert.ToInt32(Console.ReadLine());
            bool boolean = userNumb > 50;
            Console.WriteLine(boolean.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a number to divide by 7 and see remainder");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int seven = 7;
            int totals = userNum % seven;
            Console.WriteLine(totals);
            Console.ReadLine();


        }
    }
}
