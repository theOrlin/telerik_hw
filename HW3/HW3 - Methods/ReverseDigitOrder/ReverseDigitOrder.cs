/*
 * Write a method that reverses the digits of given decimal number.
 * Example: 256 -> 652
*/

using System;

namespace ReverseDigitOrder
{
    class ReverseDigitOrder
    {
        static string ReverseDecimal(decimal num)
        {
            string decimalString = num.ToString();
            string returnString = "";
            for (int i = decimalString.Length - 1; i >= 0 ; i--)
            {
                returnString += decimalString[i];
            }
            return returnString;
        }
        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            decimal decNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0} reversed is {1}.", decNum, ReverseDecimal(decNum));
        }
    }
}
