/*
 * 1. Write a program that fills and prints a matrix of size (n, n).
*/

using System;

class Program
{
    static void PrintMatrix(int[,] m)
    {
        for (int rows = 0; rows < m.GetLength(0); rows++)
        {
            for (int cols = 0; cols < m.GetLength(1); cols++)
            {
                Console.Write("{0, 3}", m[rows, cols]);
            }
            Console.WriteLine();
        }
    }
    static void fillMatrixVertical(int[,] m, int size)
    {
        int filler = 1;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                m[j, i] = filler++;
            }
        }
    }
    static void fillMatrixVerticalSnake(int[,] m, int size)
    {
        int filler = 1;
        for (int i = 0; i < size; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    m[j, i] = filler++;
                }
            }
            else
            {
                for (int j = 0; j < size; j++)
                {
                    m[j, i] = filler++;
                }
            }
        }
    }
    static void fillMatrixDiagonal(int[,] m, int size)
    {
        int filler = 1;
        for (int i = size - 1; i >= 0; i--)
        {
            int temp = i;
            for (int j = 0; j <= (size - 1) - i; j++)
            {
                m[temp,j] = filler++;
                temp++;
            }
        }
        for (int i = size - 1; i > 0; i--)
        {
            int temp = size - i;
            for (int j = 0; j < i; j++)
            {
                m[j, temp] = filler++;
                temp++;
            }
        }
    }

    private static void Main()
    {
        Console.Write("Enter size of the matrix: ");
        int mSize = int.Parse(Console.ReadLine());
        int[,] m = new int[mSize,mSize];
        Console.WriteLine("\nSelect the style you would like the matrix to be displayed in: ");
        Console.WriteLine("  [A] vertical top to bottom");
        Console.WriteLine("  [B] vertical top-bottom-top continuous");
        Console.WriteLine("  [C] diagonally");
        Console.Write("\nYour choice: ");
        string style = Console.ReadLine();
        Console.WriteLine();
        switch (style)
        {
            case "a":
            case "A":
                fillMatrixVertical(m, mSize);
                PrintMatrix(m);
                break;
            case "b":
            case "B":
                fillMatrixVerticalSnake(m, mSize);
                PrintMatrix(m);
                break;
            case "c":
            case "C":
                fillMatrixDiagonal(m, mSize);
                PrintMatrix(m);
                break;
            default:
                Console.WriteLine("Invalid choice. Goodybe.");
                break;
        }
    }
}