using System;

namespace Practica2
{
    class MainClass
    {
        public static string translit(string a)
        {
            string result = "";
            string [] Rus_letters = {"А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ","Ъ", "Ы","Ь",
          "Э","Ю", "Я","а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н",
          "о","п","р","с","т","у","ф","х", "ц", "ч", "ш", "щ","ъ", "ы","ь",
          "э","ю", "я", " "};
            string[] Eng_letters = {"A","B","V","G","D","E","E","ZH","Z","I","I","K","L","M","N",
          "O","P","R","S","T","U","F","KH","TS","CH","SH","SHCH","IE","Y",null,
          "E","IU","YA","a","b","v","g","d","e","e","zh","z","i","i","k","l","m","n",
          "o","p","r","s","t","u","f","kh","ts","ch","sh","shch","ie","y",null,
          "e","iu","ya"," "};
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < Rus_letters.Length; j++)
                {
                    if (a.Substring(i,1)== Rus_letters[j]) 
                    {
                        result = result + Eng_letters[j];
                    }
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("#1"); 
            string stroka = "";
            char find = 'f';
            Console.Write("Введите строку: ");
            stroka = Console.ReadLine(); 
            stroka = stroka.ToLower();
            int count = 0;
            int index = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == find)
                {
                    count++;
                    if (count == 2)
                    {
                        index = i;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("-2");
            } else if (count == 1)
            {
                Console.WriteLine("-1");
            } else if (count > 1)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine("#2");
            Console.WriteLine(translit("яма"));
            Console.WriteLine("#3");
            stroka = "";
            Console.WriteLine("Введите строку: ");
            stroka = Console.ReadLine();
            find = 'h';
            int first_index = stroka.IndexOf(find); 
            int last_index = stroka.LastIndexOf(find);
            for (int i = 0; i < stroka.Length; i++)
            {
                if(stroka[i]==find )
                {
                    if(i != first_index && i != last_index)
                    {
                        stroka = stroka.Remove(i, 1).Insert(i,"H");
                    }
                }
            }
            Console.WriteLine(stroka);
        }
    }
}