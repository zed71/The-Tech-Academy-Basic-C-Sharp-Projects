using System;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            // this is a simple program 
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;
            //char randomLetter = 'X';
            //decimal moneyInBank = 100.5m;
            //double heightInCentinmeteres = 211.30202092;
            //float secondsLeft = 2.62f;
            //short temperatureOnMars = -341;

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);

            //Console.WriteLine(yearsOld);
            //Console.ReadLine();

            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.ReadLine(); 

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName= Console.ReadLine();
            Console.WriteLine("Your course is: " + courseName);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your page number is: " + pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please anwser \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your reply is: " + needHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("\nThank you for sharing!!! ");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string specFeedback = Console.ReadLine();
            Console.WriteLine("\nWe appreciate your feedback " + yourName);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nice work today studying: " + studyHours);
            Console.ReadLine();

            Console.WriteLine("Thank you for your anwsers. An instuctor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
