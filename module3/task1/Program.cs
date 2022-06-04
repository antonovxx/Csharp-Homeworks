using System;

// Задание 1. Приложение по определению чётного или нечётного числа.

namespace task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                    Console.WriteLine("This is even number");
                else
                    Console.WriteLine("This is odd number");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Format exception. Probably, the number is not integer");
            }

            Console.ReadKey();
        }
    }
}