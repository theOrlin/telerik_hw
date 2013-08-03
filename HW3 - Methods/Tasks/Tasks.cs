/*
 * 13. Write a program that can solve these tasks:
 *   Reverses the digits of a number
 *   Calculates the average of a sequence of integers
 *   Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 *   The decimal number should be non-negative
 *   The sequence should not be empty
 *   a should not be equal to 0
 */

using System;

namespace Tasks
{
    class Tasks
    {
        static string ReverseDec(decimal num)
        {
            string reversedDecimal = num.ToString();
            char[] reversedCharArr = reversedDecimal.ToCharArray();
            Array.Reverse(reversedCharArr);
            return new string(reversedCharArr);
        }
        static double CalculateAverage(int[] intArr)
        {
            double sum = 0.0;
            for (int i = 0; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }
            double average = sum / (double)intArr.Length;
            return average;
        }
        static double SolveLinearEquation(int a, int b)
        {
            return (double)-b / a;
        }
        static bool isNegative(decimal num)
        {
            return (num < 0);
        }
        static bool isZero(int a)
        {
            return a == 0;
        }
        static void Main()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("  [A] Reverse the digits of a number.");
            Console.WriteLine("  [B] Calculate the average of a sequence of integers.");
            Console.WriteLine("  [C] Solve a linear equation of the type a * x + b = 0.");
            Console.WriteLine("  [Q] Quit.\n");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "a":
                case "A":
                    Console.Write("Enter the number: ");
                    decimal num = decimal.Parse(Console.ReadLine());
                    if (isNegative(num))
                        Console.WriteLine("The number should be non-negative. Goodbye!");
                    else
                    {
                        Console.WriteLine("{0} reversed is {1}.", num, ReverseDec(num));
                    }
                    break;
                case "b":
                case "B":
                    Console.Write("Enter the length of the sequence: ");
                    int arrLen = int.Parse(Console.ReadLine());
                    if (isZero(arrLen))
                        Console.WriteLine("The sequence cannot be empty. Goodbye!");
                    else
                    {
                        int[] intArr = new int[arrLen];
                        for (int i = 0; i < arrLen; i++)
                        {
                            Console.Write("Enter element {0}: ", i + 1);
                            intArr[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("The average of the sequence is {0:0.000}.", CalculateAverage(intArr));
                    }
                    break;
                case "c":
                case "C":
                    Console.Write("Enter the coefficient a: ");
                    int a = int.Parse(Console.ReadLine());
                    if (isZero(a))
                        Console.WriteLine("The coefficient a cannot be zero. Goodbye!");
                    else
                    {
                        Console.Write("Enter b: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("The root of {0} * x + {1} is {2}.", a, b, SolveLinearEquation(a, b));
                    }
                    break;
                case "q":
                case "Q":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Unrecognized option. Goodbye!");
                    break;
            }
        }
    }
}
