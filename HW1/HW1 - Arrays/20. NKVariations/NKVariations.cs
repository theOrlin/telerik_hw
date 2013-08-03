/*
 * 20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
 * Example:	N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/

using System;

class Program
{
    static void GetCombos(int[] tempArr, int upperLimit, int index)
    {
        if (index == tempArr.Length) // if the size of the combination == desired combination size
        {
            //print each element
            Console.Write("{ " + tempArr[0]);
            for (int i = 1; i < tempArr.Length; i++)
            {
                Console.Write(", {0}", tempArr[i]);
            }
            Console.WriteLine(" }");
        }
        else
        {
            for (int i = 1; i <= upperLimit; i++)
            {
                tempArr[index] = i;
                GetCombos(tempArr, upperLimit, index + 1);
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter upper limit N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter variation size K: ");
        int k = int.Parse(Console.ReadLine());
        int[] tempArr = new int[k];

        GetCombos(tempArr, n, 0);
    }
}