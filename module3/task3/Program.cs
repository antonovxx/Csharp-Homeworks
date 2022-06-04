using System;

//Задание 3. Проверка простого числа.

namespace task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some number: ");
            int number = int.Parse(Console.ReadLine());

            bool isSimple = true;

            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            if (isSimple)
                Console.WriteLine("This is simple number");
            else
                Console.WriteLine("This is not simple number");
        }
    }
}
