using System;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please dont divide by zero");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //// If an exception is caught, Finally allows for continuous code execution
            //finally
            //{
            //    Console.ReadLine();
            //}
            //Console.ReadLine();

            try
            {
                // Create a list of integers to be divided by
                List<int> myList = new List<int> { 2, 4, 16, 8, 10 };
                // Ask the user to enter a number to divide the list by
                Console.WriteLine("Please enter a number to divide the list by: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int outputNumber;

                for (int i = 0; i < myList.Count(); i++)
                {
                    outputNumber = myList[i] / userInput;
                    Console.WriteLine(outputNumber);
                }
            }
            catch (DivideByZeroException ex)
            {
                // Create prompt when user tries to divide by zero
                Console.WriteLine("Please do not divide by zero!");
            }
            catch (FormatException ex)
            {
                // Create prompt when user divides by string
                Console.WriteLine("Sorry, you cannot divide a number by a word.");
            }
            finally
            {
                Console.ReadLine();
            }
    }
}
