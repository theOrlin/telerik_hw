/*
 * 2. Write a program that reads a rectangular matrix of size N x M and finds in it
 * the square 3 x 3 that has maximal sum of its elements.
 * Note: Edit the array in the code to test - I didn't require user input to generate the matrix
 * as inputting all these ints would be tedious and dull - I am sure you have better things to do with your time.
*/

using System;

class RectangularMatrixGreatestSum
{
    static int squareSum(int[,] m, int x, int y)
    {
        int sum = 0;
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                sum += m[i, j];
            }
        }
        return sum;
    }
    static void printBestSumSquare(int[,] m, int bestX, int bestY)
    {
        for (int i = bestX - 1; i <= bestX + 1; i++)
        {
            for (int j = bestY - 1; j <= bestY + 1; j++)
            {
                Console.Write("{0} ", m[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] inputArr = new int[6, 7]
                {
                    {10, 2, 3, 4, 5, 4, 12},
                    {4, 5, 8, 5, 3, 7, 4},
                    {14, 5, 8, 5, 3, 19, 11},
                    {4, 5, 8, 5, 3, 8, 7},
                    {1, 6, 39, 15, 18, 1, 5},
                    {7, 3, 9, 5, 7, 6, 2}
                };
        int bestSum = 0;
        int tempSum = 0;
        int bestX = 0;
        int bestY = 0;
        for (int i = 1; i < inputArr.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < inputArr.GetLength(1) - 1; j++)
            {
                tempSum = squareSum(inputArr, i, j);
                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                    bestX = i;
                    bestY = j;
                }
            }
        }
        printBestSumSquare(inputArr, bestX, bestY);
    }
}