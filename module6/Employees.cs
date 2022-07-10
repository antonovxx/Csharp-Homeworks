namespace Employees;

public class Employees
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
            return $"\nID: {id}#" +
                   $"Время добавления записи: {timeNow}#" +
                   $"Ф.И.О.: {_fullName}#" +
                   $"Возраст: {_age}#" +
                   $"Рост: {_height}#" +
                   $"Дата рождения: {_birthday}#";
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