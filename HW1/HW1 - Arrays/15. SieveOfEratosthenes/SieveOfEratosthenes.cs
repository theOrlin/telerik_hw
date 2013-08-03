/*
 * 15. Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
 * !!!!NOTE!!!!
 * The program outputs the numbers to a file named primenumbers.txt located in the project /bin/Debug folder.
 * This was done because the console output takes too long and I would not want to take too much of your time.
 * You're welcome ;)
 * Make sure to delete the file afterwards as it's almost 6 megabytes worth of useless prime numbers.
*/

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = 2;
        int limit = 10000001;
        bool[] boolArr = new bool[limit];
        for (int i = n; i * i < limit; i++)
        {
            for (int j = i * i; j < limit; j += i)
            {
                if (!boolArr[j])
                    boolArr[j] = true;
            }
        }
        System.IO.StreamWriter file = new System.IO.StreamWriter("primenumbers.txt");
        for (int i = n; i < limit; i++)
        {
            if (!boolArr[i])
            {
                file.WriteLine(i);
//                Console.WriteLine(i);
            }
        }
        file.Close();
    }
}