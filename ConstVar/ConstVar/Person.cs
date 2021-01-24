using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Person
    {
        public Person(string userFName) : this(userFName, "Fuhrer")
        {
        }
        public Person(string userFName, string userLName)
        {
            FName = userFName;
            LName = userLName;
        }
        public string FName { get; set; }
        public string LName { get; set; }
    }
}


