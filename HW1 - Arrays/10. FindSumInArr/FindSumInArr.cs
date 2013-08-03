/*
 * 10. Write a program that finds in given array of integers a sequence of given sum S (if present).
 * Example:	{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}	
*/

using System;
using System.Collections.Generic;

class FindSumInArr
{
    static void DisplayList(List<int> l)
    {
        Console.Write("{ " + l[0]);
        for (int i = 1; i < l.Count; i++)
        {
            Console.Write(", {0}", l[i]);
        }
        Console.WriteLine(" }");
    }
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int sizeArr = int.Parse(Console.ReadLine());
        int[] intArr = new int[sizeArr];
        for (int i = 0; i < intArr.Length; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            intArr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());
//        int[] intArr = new int[] { 4, 3, 1, 4, 2, 5, 8 };
//        int sum = 11;
        List<int> sequence = new List<int>();
        List<List<int>> sequenceList = new List<List<int>>();
        for (int i = 0; i < intArr.Length; i++)
        {
            int arrSum = intArr[i];
            sequence.Add(intArr[i]);
            for (int j = i + 1; j < intArr.Length; j++)
            {
                if (arrSum == sum)
                {
                    sequenceList.Add(new List<int>(sequence));
                    sequence.Clear();
                    break;
                }
                else if (arrSum > sum)
                {
                    sequence.Clear();
                    break;
                }
                arrSum += intArr[j];
                sequence.Add(intArr[j]);
            }
        }
        if (sequenceList.Count == 0)
            Console.WriteLine("No sequences found.");
        else
        {
            if (sequenceList.Count > 1)
            {
                Console.WriteLine("{0} possible sequences found:", sequenceList.Count);
                foreach (var seq in sequenceList)
                {
                    DisplayList(seq);
                }
            }
            else
            {
                Console.WriteLine("One possible sequence found:");
                DisplayList(sequenceList[0]);
            }
        }
    }
}