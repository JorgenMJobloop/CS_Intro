using System.Numerics;

namespace CS_Intro;

class Program
{
    static void Main(string[] args)
    {
        // // we use the string datatype and assign it to a variable called helloWorld
        // string helloWorld = "Hello, World!";
        // // we use the int datatype (whole numbers) and assign it to the variable myNumber
        // int myNumber = 10;
        // // double, decimal datatype
        // double mySecondNumber = 12.5;
        // // bool boolean values
        // bool myBool = true;
        // // char, single alphanumeric characther
        // char a = 'A';

        // Console.WriteLine(helloWorld);

        // Console.WriteLine(myNumber + mySecondNumber);

        // Console.WriteLine(myBool);

        // Console.WriteLine(a);

        // string message = "Hei ";

        // string? name = Console.ReadLine();

        // Console.WriteLine(message + name);

        // 01.10.2024

        // Arrays, store multiple values of the same datatype
        int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        // Loop through the array, using index-based iterator
        // iterator++ is the same as: iterator = it self + 1...
        for (int iterator = 0; iterator < myIntArray.Length; iterator = iterator + 1)
        {
            Console.WriteLine($"Iterator on position: {iterator}, index of the numbers in the array: {myIntArray[iterator]}");
        }

        // we assign a new string array, using string[] myStringArray = {"some", "strings"};
        string[] myStringArray = { "Hello", "From", "A", "String", "Array!" };

        // string[] is the array, string myStrings is a single variable

        // we can use a foreach loop, to loop through the string array, using a single string variable
        foreach (string myStrings in myStringArray)
        {
            Console.WriteLine(myStrings);
        }

        // long longNumber = 1234567891011121314;
        // Console.WriteLine(longNumber);

    }
    // Example of an array outside the main scope
    //public static string[] outsideOfMainScopeArray = { "Hello", "From", "Outside", "The", "Main", "Method" };
}
