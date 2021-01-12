using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean Expression && means AND it means are both of these true//
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Boolean Expression || means OR its means is one of them true
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //Boolean Expression == means EQUAL it means do they equal to eachother
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Boolean Expression != means Not Equal to
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Boolean Expression XOR operator ^ will evaluate to true is one is true and the other is false but both cant be the same
            //Console.Write(true ^ true);
            //Console.Write(true ^ false);
            //Console.Write(false ^ false);

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && !dui && tickets <= 3);
            Console.ReadLine();



        }
    }
}
