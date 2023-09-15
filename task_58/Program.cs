// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность первой матрицы: ");
        int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write("A[{0}, {1}] = ", i, j);
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Введите размерность второй матрицы: ");
        int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write("B[{0}, {1}] = ", i, j);
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nМатрица A: ");
        Print(A);
        Console.WriteLine("\nМатрица B: ");
        Print(B);
        Console.WriteLine("\nМатрица C = A * B: ");
        int[,] C = Multiplication(A, B);
        Print(C);
    }

    static int[,] Multiplication(int[,] A, int[,] B)
    {
        if (A.GetLength(1) != B.GetLength(0)) throw new Exception("Матрицы нельзя перемножить ");
        int[,] result = new int[A.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return result;
    }

    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}