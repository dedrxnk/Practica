using System;
using System.Collections;
using System.IO;

namespace Practica6

{
    class Program
    {
        public class Student
        {
            public string Age { get; set; }
            public string FIO { get; set; }
            public string Gruppa { get; set; }
            public override string ToString()
            {
                return string.Format("ФИО:{0},Группа:{1}, Возраст:{2}", FIO, Gruppa, Age);
            }
        }

        static void Main(string[] args)
        {
            bool kones = true;
            ArrayList al = new ArrayList();

            while (kones)
            {
                Console.WriteLine("Меню");
                PrintMessage();
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    AddStudent(al);
                }
                else if (a == 2)
                {
                    PrintStudent(al);
                }
                else if (a == 3)
                {
                    RemoveStudent(al);
                }
                else kones = false;
            }

        }

    
        private static void RemoveStudent(ArrayList al)
        {
            Console.WriteLine("Введите фамилию:");
            string findFIO = Console.ReadLine();
            bool fd = false;
            Student findSt = new Student();
            foreach (var item in al)
            {
                Student st = (Student)item;
                if (findFIO == st.FIO)
                {
                    findSt = st;
                    al.Remove(st);
                    fd = true;
                    break;
                }
            }
            if (fd) { Console.WriteLine(findSt.ToString()); }
            else { Console.WriteLine("Студент не найден"); }
        }
        
        

        private static void PrintMessage()
        {
            Console.WriteLine("Добавления студента нажмите на 1");
            Console.WriteLine("Получения списка нажмите на 2");
            Console.WriteLine("Удаления студента нажмите на 3");
            Console.WriteLine("Для выхода на 9");
        }
        

        private static void PrintStudent(ArrayList al)
        {
            foreach (var item in al)
            {
                Student p = (Student)item;
                Console.WriteLine(p.ToString());
            }
        }

        private static void AddStudent(ArrayList al)
        {
            string fio; string age; string grupa;
            Console.WriteLine("ФИО студента ");
            fio = Console.ReadLine();
            Console.WriteLine("Возраст: ");
            age = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Группа: ");
            grupa = Console.ReadLine();
            al.Add(new Student { Age = age, FIO = fio, Gruppa = grupa });
        }
    }
}
