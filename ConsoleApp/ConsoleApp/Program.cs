using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// *PART 1*
            //// Create a 1-dimensional string[]
            //string[] weekDays = { "Sunday' - ", "Monday - ", "Tuesday - ", "Wednesay - ", "Thursday - ", "Friday - ", "Saturday - " };

            //// Create a loop that iterates through the array and adds
            //// User input at the end of each string

            //for (int i = 0; i < weekDays.Length; i++)
            //{
            //    // Ask the user to input text
            //    Console.WriteLine("What is your favorite day of the week? Such as \'{0}\'", weekDays);
            //    weekDays[i] = weekDays[i] + Console.ReadLine();
            //}

            //// Create a loop that prints each string in the [] on a separate line
            //for (int i = 0; i < weekDays.Length; i++)
            //{
            //    Console.WriteLine(weekDays[i]);
            //}
            //Console.ReadLine();

            //// *PART 2*
            //// create an infinite loop
            //bool whileTrue = true;
            //while (whileTrue)
            //{
            //    // a while loop without a condition to switch to the other state
            //    // continues the loop
            //    Console.WriteLine("True Forever!");
            //    Console.ReadLine();
            //    whileTrue = false;
            //}

            //// *PART 3*
            //// Create comparison loop with '<'
            //for (int j = 0; j < 3; j++)
            //{
            //    // this comparison loop will print the string 3x
            //    Console.WriteLine("Keep em coming");
            //}
            //Console.ReadLine();
            //// Create comparison loop with '<='
            //// increments the value of 'n' per loop until its value
            //// is <= to 4
            //int n = 0;
            //for (int k = 0; k <= 4; k++)
            //{
            //    n += 1;
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();

            // *PART 4*
            // Create a list of strings where each item is unique
            string userInput;
            List<string> nameList = new List<string> { "Santa", "Clause", "Easter", "Bunny", "ToothFairy" };

            // asks the user to input text to search the list
            Console.WriteLine("Please enter a name like, \"Santa\", \"Clause\", \"Easter\",\n \"Bunny\", \"ToothFairy\", or something else:");

            // code that loops to check if input item was on list,
            // if not, continues loop
            bool gotName = false;
            while (!gotName)
            {
                //takes user input for searching list
                userInput = Convert.ToString(Console.ReadLine());
                if (nameList.Contains(userInput))
                {
                    // loops through the entire list by the number of indexes
                    for (int i = 0; i < nameList.Count(); i++)
                    {
                        if (userInput == nameList[i])
                        {
                            //once true, break the while loop
                            gotName = true;
                            Console.WriteLine(userInput + " - " + i);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
                else
                {
                    // Displays if the user input doesn't match an index string
                    Console.WriteLine("Sorry, please try a different name.");
                }
            }

            // *PART 5*
            // Add a list of strings with at least two identical values
            List<string> myList2 = new List<string> { "Muhammad Ali", "Larry Holmes",
                "Jack Dempsey", "Mike Tyson", "Mike Tyson" };

            // Create prompt asking user to search of it
            Console.WriteLine("Please search for a famous Heavyweight Boxer, but first search \"Mike Tyson\".");

            // Create a loop that searches through the list and displays the matching indexes
            bool proBoxers = false;
            while (!proBoxers)
            {
                userInput = Convert.ToString(Console.ReadLine());
                if (myList2.Contains(userInput))
                {
                    // Loops through the entire list by the number of indexes
                    for (int i = 0; i < myList2.Count(); i++)
                    {
                        if (userInput == myList2[i])
                        {
                            proBoxers = true;
                            Console.Write(userInput + " - " + i + " ");
                            
                        }
                    }
                }
                else
                {
                    // Displays if the user input doesn't match an index string
                    Console.WriteLine("Sorry, please try a different Heavyweight Boxer.");
                }
            }

            // *PART 6*
            // Create a list that contains at least one identical string with another
            List<string> myList3 = new List<string> { "baseball", "football", "football", "soccer", "basketball" };

            // Create a list to filter duplicated out of myList3
            List<string> myFilteredList3 = new List<string> { };
            // Create a foreach loop that evaluates the list, 
            // and returns a message if a match is found within it

            foreach (string sports in myList3)
            {
                // Checks if the filtere list contains the current string
                // If it does, it is a duplicate
                if (myFilteredList3.Contains(sports))
                {
                    Console.WriteLine("{0} has already appeared in the list", sports);
                }
                else // If the filtered list does not contain the current string,
                     // then add it to the list and state it is not a duplicate
                {
                    myFilteredList3.Add(sports);
                    Console.WriteLine("This is the first time {0} has appeared in the list", sports);
                }
            }
            Console.ReadLine();
        }
    }
}
