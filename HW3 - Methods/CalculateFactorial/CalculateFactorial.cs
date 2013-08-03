/*
 * 10. Write a program to calculate n! for each n in the range [1..100]. 
 */

using System;
using System.Numerics;

namespace CalculateFactorial
{
    class CalculateFactorial
    {
        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main()
        {
            Console.Write("Enter a number in the range [1 - 100]: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }
    }
}
