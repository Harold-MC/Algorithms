/*
 
Fafa owns a company that works on huge projects. There are n employees in Fafa's company. Whenever the company has a new project to start working on, Fafa has to divide the tasks of this project among all the employees.

Fafa finds doing this every time is very tiring for him. So, he decided to choose the best l employees in his company as team leaders. Whenever there is a new project, Fafa will divide the tasks among only the team leaders and each team leader will be responsible of some positive number of employees to give them the tasks. To make this process fair for the team leaders, each one of them should be responsible for the same number of employees. Moreover, every employee, who is not a team leader, has to be under the responsibility of exactly one team leader, and no team leader is responsible for another team leader.

Given the number of employees n, find in how many ways Fafa could choose the number of team leaders l in such a way that it is possible to divide employees between them evenly.

Input
The input consists of a single line containing a positive integer n (2 ≤ n ≤ 105) — the number of employees in Fafa's company.

Output
Print a single integer representing the answer to the problem.

 */

using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantEmployees = Int32.Parse(Console.ReadLine());
            int employees = 0;
            int solutions = 0;

            for (int i = 0; i < cantEmployees;i++)
            {
                if (i != 0 && cantEmployees % i == 0)
                {
                    solutions++;
                }
            }
            
            Console.WriteLine(solutions);

        }

    }
}