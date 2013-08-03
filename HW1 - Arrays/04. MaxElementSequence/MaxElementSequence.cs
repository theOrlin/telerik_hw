/*
 * 4. Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
*/

using System;

class MaxElementSequence
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
        int sequenceSize = 0;
        int tempInt = intArr[0];
        int tempSequence = 0;
        for (int i = 0; i < arrSize; i++)
        {
            if (intArr[i] == tempInt)
            {
                tempSequence++;
            }
            else
            {
                if (tempSequence > sequenceSize)
                {
                    sequenceSize = tempSequence;
                    sequenceInt = tempInt;
                }
                    tempSequence = 1;
                    tempInt = intArr[i];
            }
        }
        string longestSequcence = "{" + sequenceInt.ToString();
        for (int i = 1; i < sequenceSize; i++)
        {
            longestSequcence += ", ";
            longestSequcence += sequenceInt.ToString();
        }
        longestSequcence += "}";
        Console.WriteLine("Longest sequence is {0}", longestSequcence);
    }
}