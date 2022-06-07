using System;

/*
 * Задание 2. Наименьший элемент в последовательности
 
 * Что нужно сделать
Найдите наименьший элемент в последовательности, которую вводит пользователь. Последовательность нужно сохранить в массив. 
Детальный алгоритм программы:

Пользователь вводит длину последовательности. 
Затем пользователь последовательно вводит целые числа (как положительные, так и отрицательные). Числа разделяются клавишей Enter.
Каждое введённое число помещается в соответствующий элемент массива.
После окончания ввода данных отдельный цикл проходит по последовательности и находит минимальное число. 
Для этого он сравнивает каждое число в итерации с предыдущим найденным минимальным числом. 

 */
namespace task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int [] array = new int[size];

            Console.WriteLine("Please, fill the array: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            int min = MinValue(array);

            Console.WriteLine("Array: ");

            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nMinimal value in the collection is " + min);
            Console.WriteLine("Maximum value in the collection is " + array.Max());
        }

        public static int MinValue(int[] array)
        {
            int min = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}