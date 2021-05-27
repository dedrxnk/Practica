using System;

namespace _10_Practic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[,] a = new int[n, n];
            int[,] c = new int[n, n]; //массив для сортировки по столбцам

            Random ran = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = ran.Next(0, 100);
                    c[i, j] = a[i, j];
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.WriteLine();
            }
            int[] temp = new int[n];

            Console.WriteLine("\nСортировка по столбцам: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    temp[j] = c[j, i];
                Array.Sort(temp);
                for (int k = 0; k < n; k++)
                    c[k, i] = temp[k];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", c[i, j]);
                Console.WriteLine();
            }
        }
    }
}
