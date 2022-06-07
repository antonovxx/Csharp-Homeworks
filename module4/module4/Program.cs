using System;


/* Задание 1. Случайная матрица

 * Что нужно сделать:
Выведите на экран матрицу заданного размера и заполните её случайными числами. Детальный алгоритм работы приложения:

Сначала пользователю предлагается ввести количество строк в будущей матрице.
Затем — ввести количество столбцов в будущей матрице.
После того, как данные будут получены, нужно создать в памяти матрицу заданного размера.
Используя Random, заполнить матрицу случайными целыми числами.
Вывести полученную матрицу на экран. 
Вывести суммы всех элементов этой матрицы на экран отдельной строкой. 
 */

namespace task1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Cols: ");
            int cols = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[,] matrix = new int[rows, cols];

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                    sum += matrix[i, j];
                }
            }

            for(int i = 0; i < cols; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine("Sum of the whole elements: " + sum);
        }
    }
}