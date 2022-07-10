using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Employees
{
    class Program
    {
        public static void Main()
        {
            string path = @"/Users/antonkurin/Documents/C# Projects/Tasks/Tasks/Employees/note.txt";
            
            bool menu = true;
            while (menu is true)
            {
                Console.WriteLine("МЕНЮ");

                Console.WriteLine("\nДля вывода данных на экран нажмите - 1" +
                                  "\nЗаполнить данные и добавить новую запись в конец файла - 2" +
                                  "\nВыйти из меню - 3");

                int answer = Int32.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        NoteBook.ReadNote(path);
                        break;
                    case 2:
                        NoteBook.AddNote(Employees.CreateEmployee(), path);
                        break;
                    case 3:
                        menu = false;
                        break;
                }
            }
        }
    }
}