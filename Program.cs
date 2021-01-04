using System;

namespace DeclaringVariables
{
    class Program
    //{
    //    // Declaring Variables in C#

    //    static void Main(string[] args)
    //    {
    //        int myInt = 555;
    //        double myDouble = 5.5;
    //        string myString = "Hello World";
    //        bool myBool = true;
    //        char myChar = 'A';

    //        Console.WriteLine("The value of myInt is {0,5} and the value of myDouble is {1,-5}.", myInt, myDouble);

    //        Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " + myDouble + " .");
    //    }
    //}
    //{
    // Using Arithmetic Operators
    //    static void Main(string[] args)
    //    {
    //        int myInt = 5 + 5;
    //        Console.WriteLine(myInt);

    //        double myDouble = 45.0 / 2;
    //        Console.WriteLine(myDouble);

    //        double remain = 5 % 4;
    //        Console.WriteLine(remain);

    //        int result = 2 + 3 * 4;
    //        Console.WriteLine("The result is {0}", result);
    //    }
    //}
    {
        // Using String Data Types
        static void Main(string[] args)
        {
            string myString = "Hello Universe";

            string name1 = "Libby";
            string name2 = "Josh";

            //int namesEqual = string.Compare(name1, name2);
            int namesEqual = name1.CompareTo(name2);
            Console.WriteLine("Names equal {0}", namesEqual);

            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            string firstCharOfName = name1.Substring(0, 1);
            string middleSectionOfName = name1.Substring(1, 3);

            bool startsWith = name1.StartsWith("Li");

        }
    }
}