using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        // two constructions with one overloading the other and having them implement the same that Exeption does
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }


    }
}
