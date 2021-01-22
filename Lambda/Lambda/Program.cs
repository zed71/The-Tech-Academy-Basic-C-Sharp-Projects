using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Joe", "Jonas", 0));
            list.Add(new Employee("Joe", "Jameson", 1));
            list.Add(new Employee("Chris", "Downey", 2));
            list.Add(new Employee("Robert", "Evans", 3));
            list.Add(new Employee("Dave", "Pratt", 4));
            list.Add(new Employee("Zoe", "Johnson", 5));
            list.Add(new Employee("Karen", "Gilan", 6));
            list.Add(new Employee("Arya", "Stark", 7));
            list.Add(new Employee("Bran", "Stark", 8));
            list.Add(new Employee("Jon", "Snow", 9));

            List<Employee> joes = new List<Employee>();
            //Using a foreach loop, create a new list of all employees with the first name "Joe".

            foreach (Employee emp in list)
                if (emp.FirstName.Equals("Joe"))
                    joes.Add(emp);


            //Using a lambda expression, create a new list of all employees with the first name "Joe"
            joes.Clear();
            list.ForEach(i => { if (i.FirstName.Equals("Joe")) joes.Add(i); });

            Console.WriteLine("The Joes in list: ");
            foreach (Employee emp in joes)
                emp.SayName();

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> greaterId = new List<Employee>();
            list.ForEach(i => { if (i.Id > 5) greaterId.Add(i); });

            Console.WriteLine("The ID greater than 5: ");
            foreach (Employee emp in greaterId)
                emp.SayName();

            Console.ReadLine();





        }
    }
}
