using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica10
{
    class Program
    {
        private static int reverse(int num, int acc)
        {
            while (num > 0) { acc = acc * 10 + num % 10; num /= 10; }
            return acc;
        }

        public static void Main()
        {
            Console.WriteLine("ввод числа: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num == 0) || (reverse(num, 0) == num));
            Console.ReadKey(true);
        }
    }
}
