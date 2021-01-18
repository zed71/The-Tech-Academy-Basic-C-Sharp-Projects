using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionParameterMethod
{
    class MathOperations
    {
        public int Multiply(int x, int z = 1)
        {
            int sum = x * z;
            return sum;
        }
    }
}
