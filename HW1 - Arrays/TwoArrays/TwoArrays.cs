/*
 * 2. Write a program that reads two arrays from the console and compares them element by element.
*/

using System;

class TwoArrays
{
    static void Main()
    {
        Console.WriteLine("Let's compare two integer arrays.");
        Console.Write("Enter the size of the arrays:");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arrOne = new int[arrSize];
        int[] arrTwo = new int[arrSize];
        Console.WriteLine("Enter the elements of the first array.");
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arrOne[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Thank you. And now the second array.");
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arrTwo[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Thanks. Let's compare them element by element.");
        Console.WriteLine("{0}{1,15}", "Array 1:", "Array 2:");
        for (int i = 0; i < arrSize; i++)
        {
            string compareString = (arrOne[i] == arrTwo[i]) ? "==" : "!=";
            Console.WriteLine("{0,8}{1,4}{2,4}", arrOne[i], compareString, arrTwo[i]);
        }
        Console.WriteLine("There you have it.");
    }
}
