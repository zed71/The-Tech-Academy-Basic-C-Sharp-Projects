﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Employee : Person
    {

        public int Id { get; set; }


        //Calls the base constructor (Person)
        public Employee(string FirstName, string LastName, int Id) : base(FirstName, LastName)
        {
            this.Id = Id;

        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + "[" + base.FirstName + " " + base.LastName + "]");
        }


    }
}
