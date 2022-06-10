using System;

/*Задание 1. Метод разделения строки на слова
    * Что нужно сделать
    Пользователь вводит в консольном приложении длинное предложение. 
    Каждое слово в этом предложении отделено одним пробелом. 
    Необходимо создать метод, который в качестве входного параметра принимает строковую переменную,
    а в качестве возвращаемого значения — массив слов.
    После вызова данного метода программа вызывает второй метод, который выводит каждое слово в отдельной строке.   
 */

namespace task1
{
    public static class Program
    {
        /// <summary>
        /// Разделение целой строки на подстроку
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] SplitString(string str)
        {
            string[] strArr = str.Split(' ');
            return strArr;
        }
        /// <summary>
        /// Вывод массива в консоль
        /// </summary>
        /// <param name="str"></param>
        public static void PrintString(string[] str)
        {
            foreach(string word in str)
            {
                Console.WriteLine(word);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some sentence: ");
            string str = Console.ReadLine();

            string [] strArr = SplitString(str);
            PrintString(strArr);
        }
    }
}