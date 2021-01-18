using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps MO1 = new MathOps();

            Console.WriteLine(" Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter a second number, or skip by not entering a number ");
            string y = Console.ReadLine();

            bool num1 = string.IsNullOrEmpty(y);

            if (num1 != true)
            {
                int z = Convert.ToInt32(y);

                MO1.Division(x, z);

                Console.WriteLine(x + " * " + z + " = " + MO1.Division(x, z), MO1.Division(x, z));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(x + " + 1 = " + MO1.Division(x), MO1.Division(x));
                Console.ReadLine();
            }
        }
    }
}
