/*
 * 3. Write a method that returns the last digit of given integer as an English word.
 * Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
*/

using System;

class SpellLastDigit
{
    static string SpellNum(char num)
    {
        switch (num)
        {
            case '0':
                return "zero";
                break;
            case '1':
                return "one";
                break;
            case '2':
                return "two";
                break;
            case '3':
                return "three";
                break;
            case '4':
                return "four";
                break;
            case '5':
                return "five";
                break;
            case '6':
                return "six";
                break;
            case '7':
                return "seven";
                break;
            case '8':
                return "eight";
                break;
            case '9':
                return "nine";
                break;
            default:
                return "unrecognized integer";
                break;

        }
    }
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string num = Console.ReadLine();
        char lastDigit = num[num.Length - 1];
        Console.WriteLine("The last digit of {0} is {1}.", num, SpellNum(lastDigit));
    }
}