/*
 * 2. Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
*/

using System;

class MaxOfThreeInts
{
    static int GetMax(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }
    static void Main()
    {
        Console.WriteLine("Enter three integers.");
        Console.Write("The first one: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("The second one: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("And the third one: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The largest of the three is {0}.", GetMax(GetMax(a, b), c));
    }
}