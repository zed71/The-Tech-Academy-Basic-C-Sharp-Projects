using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //How to create integer list:
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //to remove list item use:
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //List<string> intList = new List<string>();
        //intList.Add("Hi");
        //intList.Add("There");

        //To add an image to the C# database use:
        //byte[] byteArray = new byte[size of image goes here]

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();



        //Create an Array
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = {5, 2, 10, 200, 5000, 600, 2300};
        //To change a number in an arry use the below method
        //numArray2[6] = 5050;

        //Console.WriteLine(numArray2[6]);
        //Console.ReadLine();

        
        string[] colors = { "red", "blue", "yellow", "green", "purple" };


        Console.WriteLine("Pick a number between 0 and 4");
        int colorIndex = Convert.ToInt32(Console.ReadLine());
        if (colorIndex < 0 || colorIndex > 4)
        {
            Console.WriteLine("That was not a number between 0 and 4");
        }
        else Console.WriteLine(colors[colorIndex]);

        int[] numbers = { 100, 200, 300, 400, 500 };

        Console.WriteLine("Pick a number between 0 and 4");
        int intIndex = Convert.ToInt32(Console.ReadLine());
        if (intIndex < 0 || intIndex > 4)
        {
            Console.WriteLine("That was not a number between 0 and 4");
        }
        else Console.WriteLine(numbers[intIndex]);

        List<string> animals = new List<string>
            {
                "cat", "dog", "tortoise", "squirrel", "rabbit"
            };

        Console.WriteLine("Pick a number between 0 and 4");
        int animalIndex = Convert.ToInt32(Console.ReadLine());
        if (animalIndex < 0 || animalIndex > 4)
        {
            Console.WriteLine("That was not a number between 0 and 4");
        }
        else Console.WriteLine(animals[animalIndex]);

        Console.ReadLine();


    }
}

