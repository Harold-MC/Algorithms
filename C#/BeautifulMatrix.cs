using System;

namespace BeautifulMatrix
{
    class Program
    {
        private static int SIZE_MATRIX = 5;
        private static int PERFECT_POSITION;
        private static int[,] Matrix;
        
        static void Main(string[] args)
        {
            Matrix = new int[SIZE_MATRIX, SIZE_MATRIX];
            int[] temp = new int[SIZE_MATRIX], OriginalPos = new int[2];
            PERFECT_POSITION = (SIZE_MATRIX / 2);
            int steps = 0;
            
            for (int i = 0; i < SIZE_MATRIX;i++)
            {
                temp = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x));
                
                for (int j = 0;j < SIZE_MATRIX;j++)
                {
                    Matrix[i, j] = temp[j];
                    
                    if (temp[j] == 1)
                    {
                        OriginalPos[0] = i;
                        OriginalPos[1] = j;
                    }
                }
            }
            
            for (int i = 0; i < 2;i++)
            {
                while (OriginalPos[i] != PERFECT_POSITION)
                {
                    if (OriginalPos[i] > PERFECT_POSITION)
                    {
                        OriginalPos[i]--;
                    }
                    else
                    {
                        OriginalPos[i]++;
                    }
                    steps++;
                }
            }

            Console.WriteLine(steps);
            
        }
    }
}