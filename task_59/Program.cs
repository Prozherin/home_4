// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArray = new int[4, 4];

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.WriteLine("Введите элемент массива myArray[{0}, {1}]:", i, j);
                myArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int minValue = myArray[0, 0];
        int minRowIndex = 0;
        int minColumnIndex = 0;

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if (myArray[i, j] < minValue)
                {
                    minValue = myArray[i, j];
                    minRowIndex = i;
                    minColumnIndex = j;
                }
            }
        }

        Console.WriteLine("Минимальный элемент: {0}", minValue);
        Console.WriteLine("Индекс минимального элемента: [{0}, {1}]", minRowIndex, minColumnIndex);

        int[,] newMatrix = new int[myArray.GetLength(0) - 1, myArray.GetLength(1) - 1];

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            if (i == minRowIndex)
                continue;

            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                if (j == minColumnIndex)
                    continue;

                int newRow = i < minRowIndex ? i : i - 1;
                int newColumn = j < minColumnIndex ? j : j - 1;

                newMatrix[newRow, newColumn] = myArray[i, j];
            }
        }

        Console.WriteLine("Массив после удаления минимального элемента");
        Console.WriteLine("и строки по вертикали и горизонтали от него: ");
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                Console.Write(newMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}