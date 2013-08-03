/*
 * 9. Write a method that return the maximal element in a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in ascending / descending order.
 * 
 * NOTE: Please edit the array in the code for testing.
 */

using System;

namespace MaxIntInArrSort
{
    class MaxIntInArrSort
    {
        static int GetMax(int[] arr, int startIndex)
        {
            int maxIndex = startIndex;
            int max = arr[startIndex];
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        static void reverseArr(int[] arr)
        {
            int temp = arr[0];
            for (int i = 0; i <= arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - (1 + i)];
                arr[arr.Length - (1 + i)] = temp;
            }
        }
        static void printArr(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            int[] intArr = new int[] {1, 3, 45, 2, 3, 4}; // <- Edit this
            int temp = intArr[0];
            int maxIndexThisIteration = intArr[0];
            for (int i = 0; i < intArr.Length; i++)
            {
                temp = intArr[i];
                maxIndexThisIteration = GetMax(intArr, i);
                intArr[i] = intArr[maxIndexThisIteration];
                intArr[maxIndexThisIteration] = temp;
            }
            printArr(intArr);
            reverseArr(intArr);
            printArr(intArr);
        }
    }
}
