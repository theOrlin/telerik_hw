/*
 * 8. Write a method that adds two positive integer numbers represented as arrays of digits
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 * 
 * NOTE: Please edit the arrays in the code for testing.
*/

using System;

namespace NumericArrayAddition
{
    class NumericArrayAddition
    {
        static string addArrays(int[] shorterArr, int[] longerArr)
        {
            string returnNum = "";
            Array.Reverse(shorterArr);
            Array.Reverse(longerArr);
            bool carryOver = false;
            for (int i = 0; i < shorterArr.Length; i++)
            {
                int sum = shorterArr[i] + longerArr[i];
                if (carryOver)
                {
                    sum++;
                    carryOver = false;
                }
                if (sum > 9)
                {
                    carryOver = true;
                    sum = sum % 10;
                }
                returnNum += sum;
            }
            if (shorterArr.Length < longerArr.Length) //check if arrays are not equal length and get the rest of the numbers
            {
                for (int i = shorterArr.Length; i < longerArr.Length; i++)
                {
                    if (carryOver)
                    {
                        returnNum += (longerArr[i] + 1);
                        carryOver = false;
                    }
                    else
                    {
                        returnNum += longerArr[i];
                    }
                }
            }
            else //if they are equal length, check for carryover
            {
                if (carryOver)
                {
                    returnNum += 1;
                }
            }
            char[] numCharArray = returnNum.ToCharArray(); // to easily reverse the string, convert it to a char array
            Array.Reverse(numCharArray); //reverse the char array
            return new string(numCharArray); // return a new string created from the now reversed char array
        }
        static void Main()
        {
            int[] arr1 = new int[] { 1, 0, 4, 3, 9, 2, 1, 3 }; // Edit here
            int[] arr2 = new int[] { 2, 1, 9 }; // Edit here
            string sum = "";
            if (arr1.Length > arr2.Length)
            {
                sum = addArrays(arr2, arr1);
            }
            else
            {
                sum = addArrays(arr1, arr2);
            }
            Console.WriteLine("The sum of the numbers is {0}.", sum);
        }
    }
}
