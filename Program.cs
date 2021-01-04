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
    {
        // Using Arithmetic Operators
        static void Main(string[] args)
        {
            int myInt = 5 + 5;
            Console.WriteLine(myInt);

            double myDouble = 45.0 / 2;
            Console.WriteLine(myDouble);

            double remain = 5 % 4;
            Console.WriteLine(remain);

            int result = 2 + 3 * 4;
            Console.WriteLine("The result is {0}", result);
        }
    }
}