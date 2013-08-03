/*
 * 4. Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly.
 * 
 * NOTE: Please edit the array in the code for testing.
*/

using System;

class CountInArray
{
    static int Count(int[] arr, int n)
    {
        int counter = 0;
        foreach (var i in arr)
        {
            if (i == n)
                counter++;
        }
        return counter;
    }
    static void Main()
    {
        int[] intArr = new int[] {1, 2, 1, 4, 1, 2}; // Edit here
        int searchFor = 1;
        Console.WriteLine("{0} found {1} times in the array.", searchFor, Count(intArr, searchFor));

    }
}