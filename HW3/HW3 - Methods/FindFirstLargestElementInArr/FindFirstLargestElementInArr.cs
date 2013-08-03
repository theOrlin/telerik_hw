/*
 * 6. Write a method that returns the index of the first element in array
 * that is bigger than its neighbors, or -1, if there’s no such element.
 * 
 * NOTE: Please edit the array in the code for testing.
*/

using System;

class FindFirstLargestElementInArr
{
    static bool checkAtPosition(int[] arr, int pos)
    {
        if (arr[pos] > arr[pos + 1] && arr[pos] > arr[pos - 1])
            return true;
        else
            return false;
    }
    static int findFirstLargest(int[] arr)
    {
        for (int i = 1; i < arr.Length - 2; i++)
        {
            if (checkAtPosition(arr, i))
                return i;
        }
        return -1;
    }
    static void Main()
    {
        int[] intArr = new int[] { 12, 123, 435, 12, 435, 234, 456, 134, 523, 234 }; // Edit here
        int index = findFirstLargest(intArr);
        if (index > 0)
            Console.WriteLine("The index of the first element of the array larger than both its neighboring elements is {0}.", index);
        else
            Console.WriteLine("There is no element larger than both its neighboring elements in the given array.");
    }
}