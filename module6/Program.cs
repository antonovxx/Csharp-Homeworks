using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Employees
{
    class Program
    {
        public static void Main()
        {
            string path = @"note.txt";
            
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("МЕНЮ");

                Console.WriteLine("\nДля вывода данных на экран нажмите - 1" +
                                  "\nЗаполнить данные и добавить новую запись в конец файла - 2" +
                                  "\nВыйти из меню - 3");

                int answer = Int32.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        if (NoteBook.CheckNote(path))
                        {
                            NoteBook.ReadNote(path);
                        }
                        else
                        {
                            Console.WriteLine("Для начала, внесите данные");
                        }
                        break;
                    case 2:
                        if (NoteBook.CheckNote(path))
                        {
                            NoteBook.AddNote(Employees.CreateEmployee(), path);
                        }
                        else
                        {
                            NoteBook.CreateNote(Employees.CreateEmployee(), path);
                        }
                        break;
                    case 3:
                        menu = false;
                        break;
                }
            }
        }
    }
}