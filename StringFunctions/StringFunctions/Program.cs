using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = fileName.Length;

            //Console.WriteLine(length);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("My name is Brandon");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            string fullName = "Brandon Fuhrer, ";
            string upperfullName = fullName.ToUpper();
            string cityState = "Portland Oregon,  ";
            string countryUsa = "United States of America";

            Console.WriteLine(upperfullName + "" + cityState  + "" + countryUsa);
            Console.ReadLine();


            StringBuilder sb = new StringBuilder("So ", 50);
            sb.Append("in 1992, Tim Berners-Lee circulated a document titled “HTML Tags,” which outlined just 20 tags, \nmany of which are now obsolete or have taken other forms.");
            sb.AppendLine("The first surviving tag to be defined in the document, \nafter the crucial anchor tag, is the paragraph tag. ");
            sb.AppendLine("It wasn’t until 1993 that a discussion emerged on the proposed image tag.");
    

            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
