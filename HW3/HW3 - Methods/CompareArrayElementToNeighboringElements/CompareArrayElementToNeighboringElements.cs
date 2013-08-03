/*
 * 5. Write a method that checks if the element at given position in given array of integers
 * is bigger than its two neighbors (when such exist).
 * 
 * NOTE: Please edit the array in the code for testing.
*/

using System;

class CompareArrayElementToNeighboringElements
{
    static bool checkAtPosition(int[] arr, int pos)
    {
        if (arr[pos] > arr[pos + 1] && arr[pos] > arr[pos - 1])
            return true;
        else
            return false;
    }
    static void Main()
    {
        int[] intArr = new int[] {12, 123, 435, 12, 435, 234, 456, 134, 523, 234}; // Edit here
        int position = 9;
        if (position > intArr.Length - 2 || position == 0)
        {
            Console.WriteLine("The element at the given position does not have two neighboring elements.");
        }
        else
        {
            if (checkAtPosition(intArr, position))
            {
                Console.WriteLine("The element at the given position is larger than its two neighboring ones.");
            }
            else
            {
                Console.WriteLine("The element at the given position is not larger than its two neighboring ones.");
            }
        }
    }
}