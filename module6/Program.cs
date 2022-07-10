using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Employees
{
    class Employees
    {
        public readonly Guid id = Guid.NewGuid();
        
        public readonly DateTime timeNow = DateTime.Now;
        

        private string _fullName;
        public string fullName
        {
            get { return _fullName; }
            set { _fullName = value; } 
        }

        private int _age;
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        private double _height;
        public double height
        {
            get { return _height; }
            set
            {
                if (_height > 120 && _height < 220)
                {
                    _height = value;
                }
                else
                    _height = 170;
            }
        }

        private DateTime _birthday;
        public DateTime birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private string _placeOfBirth; 
        public string placeOfBirth
        {
            get { return _placeOfBirth; }
            set { _placeOfBirth = placeOfBirth; }
        }

        public Employees()
        {
        }

        public Employees(string fullName, int age, double height, DateTime birthday, string placeOfBirth)
        {
            id = Guid.NewGuid();
            timeNow = DateTime.Now;
            _fullName = fullName;
            _age = age;
            _height = height;
            _birthday = birthday;
            _placeOfBirth = placeOfBirth;
        }
        
        
        public override string ToString()
        {
            return $"\nID: {id}" +
                   $"\nВремя добавления записи: {timeNow}" +
                   $"\nФ.И.О.: {_fullName}" +
                   $"\nВозраст: {_age}" +
                   $"\nРост: {_height}" +
                   $"\nДата рождения: {_birthday}";
        }

        public static Employees CreateEmployee()
        {
            Employees employee = new Employees();
            Console.WriteLine("Введите данные: ");
            Console.WriteLine($"Ф.И.О.: ");
            employee.fullName = Console.ReadLine();
                
            Console.WriteLine($"Возраст: ");
            employee.age = Int32.Parse(Console.ReadLine());
                
            Console.WriteLine($"Рост: ");
            employee.height = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Дата рождения: ");
            employee.birthday = DateTime.Parse(Console.ReadLine());
            return employee;
        }
    }
    
    class NoteBook
    {
        public static void AddNote(Employees employee, string path)
        {
            string info = $"\nID: {employee.id}#" +
                          $"Время добавления записи: {employee.timeNow}#" +
                          $"Ф.И.О.: {employee.fullName}#" +
                          $"Возраст: {employee.age}#" +
                          $"Рост: {employee.height}#" +
                          $"Дата рождения: {employee.birthday}#";

            if (!File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(info);
                }
            }
            else
            {
                FileStream fs = new FileStream(path, FileMode.Append);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(info);
                }
            }
        }

        public static void ReadNote(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                string[] lines = text.Split('#').ToArray();
                foreach (var line in lines)
                { 
                    Console.WriteLine(line); 
                }
                sr.Close();
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            string path = @"/Users/antonkurin/Documents/C# Projects/Tasks/Tasks/Employees/note.txt";
            // Employees firstNote = new Employees
            // ("Вася Пупкин",
            //         23,
            //         180.2,
            //         new DateTime(1995, 02, 01),
            //         "Волгоград"
            // );
            Employees firstNote = new Employees();

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