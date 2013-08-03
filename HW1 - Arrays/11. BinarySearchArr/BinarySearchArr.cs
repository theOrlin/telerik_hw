/*
 * 11. Write a program that finds the index of given element in a sorted array of integers
 * by using the binary search algorithm (find it in Wikipedia).
*/

using System;

internal class BinarySearchArr
{
    private static int Midpoint(int min, int max)
    {
        return (min + max) / 2;
    }

    private static void Main()
    {
        Console.Write("Enter array size: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        for (int i = 0; i < arr.Length; i++) //populate the array
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int arrMin = 0;
        int arrMax = arr.Length - 1;
        while (arrMin <= arrMax)
        {
            int arrMid = Midpoint(arrMin, arrMax);
            if (n < arr[arrMid])
            {
                arrMax = arrMid - 1;
            }
            else if (n > arr[arrMid])
            {
                arrMin = arrMid + 1;
            }
            else
            {
                Console.WriteLine(arrMid);
                break;
            }
        }

    }
}