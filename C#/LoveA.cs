/**
Alice has a string 𝑠. She really likes the letter "a". She calls a string good if strictly more than half of the characters in that string are "a"s. For example "aaabb", "axaa" are good strings, and "baca", "awwwa", "" (empty string) are not.

Alice can erase some characters from her string 𝑠. She would like to know what is the longest string remaining after erasing some characters (possibly zero) to get a good string. It is guaranteed that the string has at least one "a" in it, so the answer always exists.

Input
The first line contains a string 𝑠 (1≤|𝑠|≤50) consisting of lowercase English letters. It is guaranteed that there is at least one "a" in 𝑠.

Output
Print a single integer, the length of the longest good string that Alice can get after erasing some characters from 𝑠.
*/


using System;

namespace LoveA
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrance = Console.ReadLine();
            int Count = 0;

            for (int i = 0;i < Entrance.Length;i++)
            {
                if (Entrance[i] == 'a')
                {
                    Count++;
                }
            }

            int cantA = Count;
            int others = Entrance.Length - cantA;

            if (others >= cantA)
            {
                Console.WriteLine(Entrance.Length - ((others - cantA) + 1));
            }
            else
            {
                Console.WriteLine(Entrance.Length);
            }
            
            
        }
    }
}
