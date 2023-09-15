// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            int value = 1;
            int startX = 0, startY = 0;
            int endX = n - 1, endY = n - 1;

            while (value <= n * n)
            {
                // Вправо
                for (int i = startX; i <= endX; i++)
                {
                    array[startY, i] = value;
                    value++;
                }
                startY++;

                // Вниз
                for (int i = startY; i <= endY; i++)
                {
                    array[i, endX] = value;
                    value++;
                }
                endX--;

                // Влево
                for (int i = endX; i >= startX; i--)
                {
                    array[endY, i] = value;
                    value++;
                }
                endY--;

                // Вверх
                for (int i = endY; i >= startY; i--)
                {
                    array[i, startX] = value;
                    value++;
                }
                startX++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}