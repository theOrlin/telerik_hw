/*
 * 9. Write a program that finds the most frequent number in an array. Example: 
 * {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/

using System;

class MostFrequentIntInArr
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] intArr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            intArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(intArr);
        int testElement = intArr[0];
        int element = 0;
        int counter = 0;
        int maxCounter = 0;
        for (int i = 0; i < intArr.Length; i++)
        {
            if (testElement == intArr[i])
            {
                counter++;
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    element = intArr[i];
                }
            }
            else
            {
                testElement = intArr[i];
                counter = 1;
            }
        }
        Console.WriteLine("Most common element in the array: {0}, encountered {1} times.", element, maxCounter);
        Console.WriteLine("encountered: {0}", maxCounter);
    }
}
