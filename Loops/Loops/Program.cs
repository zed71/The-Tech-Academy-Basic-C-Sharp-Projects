using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my name?");
            string name = Console.ReadLine();
            bool theName = name == ("Brandon");

            do
            {
                switch (name)
                {
                    case ("Joe"):
                        Console.WriteLine("You guess Joe. Try again.");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;
                    case ("Cory"):
                        Console.WriteLine("You guess Cory. Try again.");
                        Console.WriteLine("Guess my name ? ");
                        name = Console.ReadLine();
                        break;
                    case ("Lucy"):
                        Console.WriteLine("You guess 55. Try again.");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;
                    case ("Brandon"):
                        Console.WriteLine("You guessed Brandon. That is correct!.");
                        theName = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess my name?");
                        name = Console.ReadLine();
                        break;
                }
            }
            while (!theName);

            Console.WriteLine(name);
            Console.ReadLine();

            Console.WriteLine("Whats my lucky number?");
            int luckyNum = Convert.ToInt32(Console.ReadLine());
            bool myNumber = luckyNum == 125;
            

            
            while (!myNumber)
            {
                switch (luckyNum)
                {
                    case 5:
                        Console.WriteLine("You guessed 5. Nope guess again.");
                        Console.WriteLine("Whats my lucky number?");
                        luckyNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("You guessed 29. Getting Warmer, keep guessing.");
                        Console.WriteLine("Whats my lucky number?");
                        luckyNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 81:
                        Console.WriteLine("You guessed 81. Almost warm, guess again.");
                        Console.WriteLine("Whats my lucky number?");
                        luckyNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 125:
                        Console.WriteLine("You guessed 125. Thats right!! Did you cheat?");
                        myNumber = true;
                        break;
                    default:
                        Console.WriteLine("Nope, keep trying.");
                        Console.WriteLine("Whats my lucky number?");
                        luckyNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
