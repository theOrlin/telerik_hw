/*
 * Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
*/

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        string arrSizeStr = Console.ReadLine();
        int arrSize = int.Parse(arrSizeStr);
        int[] intArr = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            string elementStr = Console.ReadLine();
            intArr[i] = int.Parse(elementStr);
        }
        int sequenceInt = intArr[0];
        int sequenceSize = 1;
        int tempInt = intArr[0];
        int tempSequence = 1;
        for (int i = 1; i < arrSize; i++)
        {
            if (intArr[i] == tempInt + 1)
            {
                tempSequence++;
            }
            else
            {
                tempSequence = 1;
            }
            tempInt = intArr[i];
            if (tempSequence > sequenceSize)
            {
                sequenceSize = tempSequence;
                sequenceInt = tempInt;
            }
        }
//        Console.WriteLine("Sequence size: " + sequenceSize);
        sequenceInt = (sequenceInt - sequenceSize) + 1;
//        Console.WriteLine("Sequence int: " + sequenceInt);
        string longestSequcence = "{" + sequenceInt.ToString();
        for (int i = sequenceInt + 1; i < sequenceInt + sequenceSize; i++)
        {
            longestSequcence += ", ";
            longestSequcence += i.ToString();
        }
        longestSequcence += "}";
        Console.WriteLine("Longest sequence is {0}", longestSequcence);
    }
}