/*
 * 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;

class QuickSortArr
{
    static List<string> quickSort(List<string> strList)
    {
        List<string> left = new List<string>();
        List<string> right = new List<string>();
        if (strList.Count <= 1)
            return strList;
        else
        {
            int middle = getMiddle(strList);
            string midStr = strList[middle];
            for (int i = 0; i < strList.Count; i++)
            {
                if (strList[i] != strList[middle])
                {
                    if (string.Compare(strList[middle], strList[i]) < 0) //strlist[middle] is less than strlist[i]
                    {
                        right.Add(strList[i]);
                    }
                    else
                    {
                        left.Add(strList[i]);
                    }
                }
            }
            left = quickSort(left);
            right = quickSort(right);
            strList.Clear();
            strList.AddRange(left);
            strList.Add(midStr);
            strList.AddRange(right);
            return strList;
        }
    }
    static int getMiddle(List<string> strList)
    {
        if (strList.Count == 1)
            return 0;
        else
        {
            return strList.Count / 2;
        }
    }
    static void Main()
    {
        string[] stringArr = new string[]
            {
                "ab", "gh", "ef", "fdg", "inn", "ji", "kl",
                "ops", "cd", "dbrsdf"
            };
        List<string> stringList = new List<string>(stringArr);
        stringList = quickSort(stringList);
        foreach (var VARIABLE in stringList)
        {
            Console.WriteLine(VARIABLE);
        }

    }
}