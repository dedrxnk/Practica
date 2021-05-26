using System;

namespace Practica8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Размер: ");
            int n = int.Parse(Console.ReadLine());
            int[,] m = new int[n, n];
            Random r = new Random();

            int max = 0;
            int ro = 0, c = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m[i, j] = r.Next(100) + 1;
                    if (i == j || i > j)
                        if (m[i, j] > max)
                        {
                            max = m[i, j];
                            ro = i;
                            c = j;
                        }
                    Console.Write("{0,4}", m[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Координаты: ({0}:{1})", ro, c);

            Console.ReadKey();
        }
    }
}
