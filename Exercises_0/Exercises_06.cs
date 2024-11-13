using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_0
{
    internal class Exercises_06
    {
        private static int[,] a;

        static void Main()
        {
            // Nhập số dòng và cột của ma trận
            Console.Write("Nhap so dong cua ma tran (N): ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran(M): ");
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = CreateRandomMatrix(N, M);
            Console.WriteLine("tao ma tran:");
            PrintMatrix(matrix);
            Console.Write("nhap vi tri de xem: ");
            int user_num = int.Parse(Console.ReadLine());
            Searchlinear(matrix, user_num);
            Console.WriteLine();
            int max = FindMaxValue(matrix);
            Console.Write($"gia tri lon nhat trong ma tran la: {max}");
        }

        static int[,] CreateRandomMatrix(int N, int M)
        {
            int[,] matrix = new int[N, M];
            Random rand = new Random();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(1, 100); // Generate a random number between 1 and 99
                }
            }

            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Searchlinear(int[,]matrix, int user_num)
        {
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == user_num)
                    {
                        Console.Write($"{user_num} xuat hien tai dong {i} cot {j}");
                    }
                }
            }
        }
        static int FindMaxValue(int[,] matrix)
        {
            int max = int.MinValue;
            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for(int j = 0;j < matrix.GetLength(1); j++)
                {
                    if ((matrix[i, j] > max))
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

    }
}
