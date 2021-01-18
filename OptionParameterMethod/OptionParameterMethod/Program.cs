using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations MO2 = new MathOperations();

            // Ask user for input
            Console.WriteLine("Please enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter a second number, or skip by " +
                "entering nothing:");
            string y = Console.ReadLine();

            //Checks if input for 2ns number was null or empty
            bool MO1 = string.IsNullOrEmpty(y);

            // Converts value of input if !null
            if (MO1 != true)
            {
                int z = Convert.ToInt32(y);

                // Pass values to method
                MO2.Multiply(x, z);

                Console.WriteLine(x + " + " + z + " = " + MO2.Multiply(x, z), MO2.Multiply(x, z));
                Console.ReadLine();
            }
            else
            {
                // Passes in default value!
                Console.WriteLine(x + " + 1 = " + MO2.Multiply(x), MO2.Multiply(x));
                Console.ReadLine();
            }
        }
    }
}
