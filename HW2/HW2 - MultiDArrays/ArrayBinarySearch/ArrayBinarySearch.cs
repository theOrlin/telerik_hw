/*
 * 4. Write a program, that reads from the console an array of N integers and an integer K,
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
*/

using System;

class ArrayBinarySearch
{
    private static void Main()
    {
        Console.Write("Enter size of array: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter number K to search for in the array: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr); // sort array for binary search
        int n = Array.BinarySearch(arr, k); // get index of search item: negative if not in array, non-negative if present
        if (n >= 0)
        {
        Console.WriteLine(arr[n]);
            
        }
        else //if item is negative, binary negate the answer to get the index of the first integer larger than K and subtract one to get the largest element smaller than K
        {
            Console.WriteLine(arr[(~n) - 1]);
        }

    }
}