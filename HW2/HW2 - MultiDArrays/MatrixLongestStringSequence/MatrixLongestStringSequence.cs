/*
 * 3. We are given a matrix of strings of size N x M.
 * Sequences in the matrix we define as sets of several neighbor elements
 * located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix. 
 * Note: Please edit the matrix in the code.
 */

using System;

class MatrixLongestStringSequence
{
    static int checkRow(string[,] m, int row, int col)
    {
        string test = m[row, col];
        int counter = 0;
        for (int i = col; i < m.GetLength(1); i++)
        {
            if (m[row, i] == test)
                counter++;
            else
                break;
        }
        return counter;
    }
    static int checkCol(string[,] m, int row, int col)
    {
        string test = m[row, col];
        int counter = 0;
        for (int i = row; i < m.GetLength(0); i++)
        {
            if (m[i, col] == test)
                counter++;
            else
                break;
        }
        return counter;
    }
    static int checkRightDiagonal(string[,] m, int row, int col)
    {
        string test = m[row, col];
        int counter = 0;
        for (int i = row, j = col; i < m.GetLength(0) && j < m.GetLength(1); i++, j++)
        {
            if (m[i, j] == test)
                counter++;
            else
                break;
        }
        return counter;
    }
    static int checkLeftDiagonal(string[,] m, int row, int col)
    {
        string test = m[row, col];
        int counter = 0;
        for (int i = row, j = col; i < m.GetLength(0) && j >= 0; i++, j--)
        {
            if (m[i, j] == test)
                counter++;
            else
                break;
        }
        return counter;
    }
    static void Main()
    {
        string[,] m = new string[3, 4]
            {
                {"ha", "fi", "hi", "hi"},
                {"fo", "ha", "hi", "xx"},
                {"xx", "hi", "ha", "xx"}
            };
        int bestLen = 1;
        string longestSequenceString = m[0, 0];
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                int rowLen = checkRow(m, i, j);
                int colLen = checkCol(m, i, j);
                int rDiagLen = checkRightDiagonal(m, i, j);
                int lDiagLen = checkLeftDiagonal(m, i, j);
                if (rowLen > bestLen)
                {
                    bestLen = rowLen;
                    longestSequenceString = m[i, j];
                }
                if (colLen > bestLen)
                {
                    bestLen = colLen;
                    longestSequenceString = m[i, j];
                }
                if (rDiagLen > bestLen)
                {
                    bestLen = rDiagLen;
                    longestSequenceString = m[i, j];
                }
                if (lDiagLen > bestLen)
                {
                    bestLen = lDiagLen;
                    longestSequenceString = m[i, j];
                }
            }
        }
        string finalSequence = longestSequenceString;
        for (int i = 1; i < bestLen; i++)
        {
            finalSequence += ", ";
            finalSequence += longestSequenceString;
        }
        Console.WriteLine("Longest sequence: {0}", finalSequence);
    }
}