using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class VoidMethod
    {
        // Create a void method that takes 2 assigned parameters
        public void Assign(int x, int y)
        {
            // Do a math operation on parm 1
            int sum = x + 10;
            Console.WriteLine(x + " + 10 = " + sum);

            // Display int parm 2 to screen
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
