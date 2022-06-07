using System;

/*
 * Задание 3. Игра «Угадай число» 
 * 
Что нужно сделать
Разработайте программу по следующему алгоритму:

Пользователь вводит максимальное целое число диапазона. 
На основе диапазона целых чисел (от 0 до «введено пользователем») программа генерирует случайное целое число из диапазона. 
Пользователю предлагается ввести загаданное программой случайное число. 
Пользователь вводит свои предположения в консоли приложения. 
Если число меньше загаданного, программа сообщает об этом пользователю. 
Если больше, то тоже сообщает, что число больше загаданного. 
Программа завершается, когда пользователь угадал число. 
Если пользователь устал играть, то вместо ввода числа он вводит пустую строку и нажимает Enter. 
Тогда программа завершается, предварительно показывая, какое число было загадано.

*/
namespace task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Let's play to the game Guess the Number! " +
                "Enter the maximum number in the range: ");
            int size = int.Parse(Console.ReadLine());

            Random random = new Random();
            int correctNumber = random.Next(0, size);

            string guessedNumber = "abracadabra";

            Console.WriteLine("Answer: " + correctNumber);
            Console.WriteLine("Enter number: ");

            bool work = true;

            while(work)
            {
                guessedNumber = Console.ReadLine();

                int intUserAnswer = 0;

                bool checkNumber = int.TryParse(guessedNumber, out intUserAnswer);

                if (intUserAnswer > size || intUserAnswer < 0)
                {
                    Console.WriteLine("Out of the range!");
                    continue;
                }

                if (checkNumber && intUserAnswer < correctNumber)
                {
                    Console.WriteLine("The number is less than the correct number. Try again.");
                    continue;
                }
                else if (checkNumber && intUserAnswer > correctNumber)
                {
                    Console.WriteLine("The number is more than the correct number. Try again.");
                    continue;
                }
                else if (checkNumber && intUserAnswer == correctNumber)
                {
                    Console.WriteLine("You win!");
                    work = false;
                }
                else if (!checkNumber)
                {
                    if (guessedNumber == " ")
                    {
                        Console.WriteLine("Goodbye!");
                        Console.WriteLine("Guessed number is " + correctNumber);
                        work = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Try again");
                        continue;
                    }
                }
            }

        }
    }
}