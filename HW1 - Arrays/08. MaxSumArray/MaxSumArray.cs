/*
 * 8. Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;

class MaxSumArray
{
    static void Main()
    {
        Console.Write("Enter the array size: ");
        int arrSize = int.Parse(Console.ReadLine());
        int[] largeArr = new int[arrSize];
        for (int i = 0; i < largeArr.Length; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            largeArr[i] = int.Parse(Console.ReadLine());
        }
        int maxSoFar = 0;
        int maxTotal = 0;
        int endIndex = 0;
        int counter = 0;
        int sequenceCounter = 0;
        for (int i = 0; i < largeArr.Length; i++)
        {
            maxSoFar += largeArr[i];
            counter++;
            if (maxSoFar < 0)
            {
                maxSoFar = 0;
                counter = 0;
            }
            if (maxTotal < maxSoFar)
            {
                maxTotal = maxSoFar;
                endIndex = i;
                sequenceCounter = counter;
            }
        }
        int startpoint = endIndex - sequenceCounter + 1;
        string bestSumSequence = "{ " + largeArr[startpoint].ToString();
        for (int i = startpoint + 1; i <= endIndex; i++)
        {
            bestSumSequence += ", ";
            bestSumSequence += largeArr[i];
        }
        bestSumSequence += " }";
        Console.WriteLine(bestSumSequence);
    }
}