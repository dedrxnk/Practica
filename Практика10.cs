using System;
using System.Collections.Generic;

namespace Practica10
{
    public class RIM
    {
        Dictionary<string, string> dictionaryChar = new Dictionary<string, string>()
            {
{"1","I"},
{"2","II"},
{"3","III"},
{"4","IV"},
{"5","V"},
{"6","VI"},
{"7","VII"},
{"8","VIII"},
{"9","IX"},
{"10","X"},
};

        public string TranslitFileName(string source)
        {
            var result = "";
            // проход по строке для поиска символов подлежащих замене которые находятся в словаре dictionaryChar
            foreach (var ch in source)
            {
                var ss = "";

                if (dictionaryChar.TryGetValue(ch.ToString(), out ss))
                {
                    result += ss;
                }

                else
                {
                    result += ch;
                }
                    
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RIM rim = new RIM();

            Console.WriteLine("Ввод римский цифр от 1 до 10 (Больше не завезли)");

            string text = Console.ReadLine();

            string textOut = rim.TranslitFileName(text);

            Console.WriteLine("Исходная строка \'{0}\'", text);
            Console.WriteLine("Cтрока после замены \'{0}\'", textOut);
            Console.ReadLine();

        }

        static void PP()
        {
            RIM rim = new RIM();

        }
    }
}
