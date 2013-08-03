/*
 * 5. You are given an array of strings.
 * Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

using System;
class StringArraySizeSort
{
    static void StrArrSizeSort(string[] stringArray)
    {
        Array.Sort(stringArray, (a, b) => a.Length.CompareTo(b.Length));
    }
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int arrSize = int.Parse(Console.ReadLine());
        string[] strArr = new string[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            Console.Write("Enter element {0}: ", i + 1);
            strArr[i] = Console.ReadLine();
        }
        StrArrSizeSort(strArr);
        foreach (var s in strArr)
        {
            Console.WriteLine(s);
        }
    }
}