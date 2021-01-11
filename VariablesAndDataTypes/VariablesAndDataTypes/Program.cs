using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine(); 

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Your page number is: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please anwser \"true\" or \"false.\"");
            string needHelp = Console.ReadLine();
            Console.WriteLine("Your reply is: " + needHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine(posExp + "\nThank you for sharing!!! ");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string specFeedback = Console.ReadLine();
            Console.WriteLine(specFeedback + "\nWe appreciate your feedback " + yourName);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours= Console.ReadLine();
            Console.WriteLine("Nice work today studying: " + studyHours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your anwsers. An instuctor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
