/*
 * 1. Write a program that allocates array of 20 integers and initializes each element
 * by its index multiplied by 5. Print the obtained array on the console.
*/
using System;

class TwentyInts
{
    static void Main()
    {
        int[] intArr = new int[20];
        for (int i = 0; i < intArr.Length; i++)
        {
            intArr[i] = i * 5;
        }
        foreach (var i in intArr)
        {
            Console.WriteLine(i);
        }
    }
}