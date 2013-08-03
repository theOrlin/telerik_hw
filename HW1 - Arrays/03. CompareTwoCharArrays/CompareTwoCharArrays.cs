/*
 * 3. Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.WriteLine("Now let's compare two char arrays.");
        Console.Write("Enter the size of the arrays:");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arrOne = new int[arrSize];
        int[] arrTwo = new int[arrSize];
        Console.WriteLine("Enter the elements of the first array.");
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            string charStr = Console.ReadLine();
            arrOne[i] = char.Parse(charStr);
        }
        Console.WriteLine("Thank you. And now the second array.");
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            string charStr = Console.ReadLine();
            arrTwo[i] = char.Parse(charStr);
        }
        Console.WriteLine("Thanks. Let's compare them element by element.");
        Console.WriteLine("{0}{1,15}", "Array 1:", "Array 2:");
        for (int i = 0; i < arrSize; i++)
        {
            string compareString = (arrOne[i] == arrTwo[i]) ? "==" : "!=";
            Console.WriteLine("{0,8}{1,4}{2,4}", (char)arrOne[i], compareString, (char)arrTwo[i]);
        }
        Console.WriteLine("And that is that.");
    }
}