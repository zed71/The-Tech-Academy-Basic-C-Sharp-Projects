using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        // Create SayName method
        // Implimented virtually for overide during inheritance
        public virtual void SayName()
        {

        }
    }
}
