/*
 * 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
 * Use variable number of arguments.
*/

using System;

namespace VariableArgumentMethods
{
    class Program
    {
        static int GetMinimum(params int[] intArr)
        {
            if (intArr.Length > 0)
            {
                int min = intArr[0];
                for (int i = 0; i < intArr.Length; i++)
                {
                    if (intArr[i] < min)
                    {
                        min = intArr[i];

                    }
                }
                return min;
            }
            else
            {
                return -1;
            }
        }
        static int GetMaximum(params int[] intArr)
        {
            if (intArr.Length > 0)
            {
                int max = intArr[0];
                for (int i = 0; i < intArr.Length; i++)
                {
                    if (intArr[i] > max)
                    {
                        max = intArr[i];

                    }
                }
                return max;
            }
            else
            {
                return -1;
            }
        }
        static int calculateSum(params int[] intArr)
        {
            if (intArr.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < intArr.Length; i++)
                {
                    sum += intArr[i];
                }
                return sum;
            }
            else
                return -1;
        }
        static double CalculateAverage(params int[] intArr)
        {
            if (intArr.Length > 0)
            {
                return calculateSum(intArr) / intArr.Length;
            }
            else
            {
                return -1;
            }
        }
        static decimal calculateProduct(params int[] intArr)
        {
            if (intArr.Length > 0)
            {
                decimal product = 1;
                for (int i = 0; i < intArr.Length; i++)
                {
                    product *= intArr[i];
                }
                return product;
            }
            else
            {
                return -1;
            }
        }
        static void Main()
        {
            int[] intArr = new int[] {1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine("Minimum of array: {0}", GetMinimum(intArr));
            Console.WriteLine("Maximum of array: {0}", GetMaximum(intArr));
            Console.WriteLine("Average of array: {0}", CalculateAverage(intArr));
            Console.WriteLine("Sum of array: {0}", calculateSum(intArr));
            Console.WriteLine("Product of array: {0}", calculateProduct(intArr));
        }
    }
}
