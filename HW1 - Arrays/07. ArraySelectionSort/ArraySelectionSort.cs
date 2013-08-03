/*
 * 7. Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
 * find the smallest from the rest, move it at the second position, etc.
*/

using System;

class ArraySelectionSort
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrSize; i++)
        {
            for (int j = 0; j < arrSize; j++)
            {
                if (arr[i] <= arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    continue;
                }
            }
        }
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}