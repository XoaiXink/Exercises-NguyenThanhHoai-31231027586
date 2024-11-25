using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_05_03
    {
        //static void Main()
        //{
        //    int[][] jaggedArray = new int[][]
        //    {
        //    new int[] { 1, 1, 1, 1, 1 },
        //    new int[] { 2, 2 },
        //    new int[] { 3, 3, 3, 3 },
        //    new int[] { 4, 4 }
        //    };
        //    Console.WriteLine("Jagged Array:");
        //    PrintJaggedArray(jaggedArray);
        //}
        //static void PrintJaggedArray(int[][] jaggedArray)
        //{
        //    foreach (var row in jaggedArray)
        //    {
        //        Console.WriteLine(string.Join(" ", row));
        //    }
        //}
       
        static void Main()
        {
            // Nhập số hàng và số cột của từng hàng từ người dùng
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter the number of columns for row {i + 1}: ");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[cols];

                Console.WriteLine($"Enter {cols} elements for row {i + 1}:");
                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged Array:");
            PrintJaggedArray(jaggedArray);

            // 1. Tìm số lớn nhất của từng hàng và toàn mảng
            FindLargestNumbers(jaggedArray);

            // 2. Sắp xếp các giá trị trong từng hàng
            SortRows(jaggedArray);
            Console.WriteLine("\nSorted Jagged Array:");
            PrintJaggedArray(jaggedArray);

            // 3. In các số nguyên tố trong mảng
            PrintPrimes(jaggedArray);

            // 4. Tìm tất cả các vị trí của một số
            Console.Write("\nEnter the number to search: ");
            int searchNumber = int.Parse(Console.ReadLine());
            SearchNumber(jaggedArray, searchNumber);
        }

        static void PrintJaggedArray(int[][] jaggedArray)
        {
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static void FindLargestNumbers(int[][] jaggedArray)
        {
            int globalMax = int.MinValue;
            Console.WriteLine("\nLargest number in each row:");
            foreach (var row in jaggedArray)
            {
                int rowMax = row.Max();
                Console.WriteLine(rowMax);
                if (rowMax > globalMax) globalMax = rowMax;
            }
            Console.WriteLine($"Largest number in the entire array: {globalMax}");
        }

        static void SortRows(int[][] jaggedArray)
        {
            foreach (var row in jaggedArray)
            {
                Array.Sort(row);
            }
        }

        static void PrintPrimes(int[][] jaggedArray)
        {
            Console.WriteLine("\nPrime numbers in the array:");
            foreach (var row in jaggedArray)
            {
                foreach (var num in row)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static void SearchNumber(int[][] jaggedArray, int number)
        {
            Console.WriteLine("\nPositions of the number:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == number)
                    {
                        Console.WriteLine($"Row {i + 1}, Column {j + 1}");
                    }
                }
            }
        }
    }

}




