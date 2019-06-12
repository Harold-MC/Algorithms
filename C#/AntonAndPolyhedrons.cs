using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cant = Int32.Parse(Console.ReadLine());
            int Counter = 0;
            string[] array = new string[Cant];

            for (int i = 0; i < Cant;i++)
            {
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i < Cant;i++)
            {
                switch (array[i])
                {
                    case "Tetrahedron" :
                        Counter += 4;
                        break;
                    case "Cube" :
                        Counter += 6;
                        break;
                    case "Octahedron" : 
                        Counter += 8;
                        break;
                    case "Dodecahedron" :
                        Counter += 12;
                        break;
                    case "Icosahedron" :
                        Counter += 20;
                        break;
                    default :
                        break;
                }
                
            }
            Console.WriteLine(Counter);
        }
    }
