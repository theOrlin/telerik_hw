/*
 * 6. Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
*/

using System;

class KNMaxSum
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        int[] emptyArr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter value {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.Write("Enter a number of elements to sum (less than {0}): ", arrSize);
        int numElements = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("The elements that will produce the largest sum: ");
        Console.Write(arr[0]);
        int sum = arr[0];
        for (int i = 1; i < numElements; i++)
        {
            Console.Write(", ");
            Console.Write(arr[i]);
            sum += arr[i];
        }
        Console.WriteLine();
        Console.WriteLine("Sum: {0}", sum);
    }
}