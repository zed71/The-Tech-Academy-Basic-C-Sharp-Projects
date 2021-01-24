using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user for their age
                Console.WriteLine("Hi. How old are you?");
                var age = Convert.ToInt32(Console.ReadLine());

                var today = DateTime.Today;
                var yearBorn = today.Year - age;
                bool validAnswer = false;
                while (!validAnswer)
                {
                    if (age < 1)
                    {
                        // Displays error message if input is less than 1
                        throw new Exception();
                    }
                    else if (age > 200)
                    {
                        // Displays error if input is over a range
                        throw new WhatAgeException();
                    }

                    else
                    {
                        // Display the year the user was born
                        validAnswer = true;
                        Console.WriteLine("You were born {0}", yearBorn);
                        Console.ReadLine();
                    }
                }
            }
            // Thrown exception in the case of decimals or strings
            catch (FormatException)
            {
                Console.WriteLine("Please only enter whole numbers");
                Console.ReadLine();
            }
            // Thrown to catch unlikely ages
            catch (WhatAgeException)
            {
                Console.WriteLine("Smells like old people farts now, gross!!");
                Console.ReadLine();
            }
            // Thrown if user input is less that 1
            catch (Exception)
            {
                Console.WriteLine("Enter your real age!!!");
                Console.ReadLine();
            }
        }
    }
}
