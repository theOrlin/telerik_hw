/*
 * 12. Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class AlphabetArr
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        word = word.ToLower();
        char[] alphabet = new char[26];
        int counter = 0;
        char letter = 'a';
        while (counter != 26)
        {
            alphabet[counter] = letter;
            counter++;
            letter++;
        }
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("'{0}' has index {1}", word[i], j);
                    break;
                }
            }
        }
    }
}