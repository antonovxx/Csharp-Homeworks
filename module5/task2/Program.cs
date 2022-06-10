using System;
/*Задание 2. Перестановка слов в предложении
    * Что нужно сделать
    Пользователь вводит в программе длинное предложение. Каждое слово раздельно одним пробелом. 
    После ввода пользователь нажимает клавишу Enter. Необходимо создать два метода:
    * первый метод разделяет слова в предложении;
    * второй метод меняет эти слова местами (в обратной последовательности). 
    При этом важно учесть, что один метод вызывается внутри другого метода,
    то есть в методе main вызывается метод cо следующей сигнатурой — ReversWords (string inputPhrase). 
    Внутри этого метода вызывается метод по разделению входной фразы на слова.
*/

namespace task2
{
    public class Program
    {
        public static string SplitString(string str)
        {
            string[] strArr = str.Split(' ');
            string newStr = ReverseString(strArr);
            return newStr;
        }
        public static string ReverseString(string[] strArr)
        {
            Array.Reverse(strArr);
            string str = string.Join(" ", strArr);
            return str;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some string: ");
            string str = Console.ReadLine();

            str = SplitString(str);
            Console.WriteLine(str);
        }
    }
}