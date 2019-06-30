/*
 
Allen has a LOT of money. He has 𝑛 dollars in the bank. For security reasons, he wants to withdraw it in cash (we will not disclose the reasons here). The denominations for dollar bills are 1, 5, 10, 20, 100. What is the minimum number of bills Allen could receive after withdrawing his entire balance?

Input
The first and only line of input contains a single integer 𝑛 (1≤𝑛≤109).

Output
Output the minimum number of bills that Allen could receive.

 */

using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cant = 0;
            int Money = Int32.Parse(Console.ReadLine());
            int[] Monedas = { 100, 20, 10, 5, 1 };

            for (int i = 0; i < Monedas.Length;i++)
            {
                if (Money == 0)
                {
                    break;
                }
                
                while (Money / Monedas[i] > 0)
                {
                    Money -= Monedas[i];
                    Cant++;
                }
            }
            
            Console.WriteLine(Cant);
      
        }

    }
}