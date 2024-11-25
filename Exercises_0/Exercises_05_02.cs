//▸Create a program with following functions
//- Create an integer matrix N x M (N, M was prompted from user) randomly.
//- Print the matrix.
//- Print the i
//th row/column. (i was prompted from user)
//- Find the max value of the matrix.
//- Find the min value of i
//th row/col of the matrix.
//- Transpose the matrix.
//- Print the main/secondary diagonal values of the matrix
namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_05_02
    {
        public static void Main52(string[] args)
        {
            Console.WriteLine("nhap so dong cua ma tran");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so cot cua ma tran");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            IndexOfMatrix(matrix);
            //Prinmatrix(matrix);
            //Console.WriteLine("nhap hang ban muon in");
            //int row = int.Parse(Console.ReadLine());
            //PrintRow(matrix, row);
            //Console.WriteLine("nhap cot ban muon in");
            //int col = int.Parse(Console.ReadLine());
            //PrintColumn(matrix, col);
            //Console.Write("giatri lon nhat trong ma tran la ");
            //FindMax(matrix);
            //Console.WriteLine("nhap hang ban muon tim vi tri nho nhat");
            //int Hang = int.Parse(Console.ReadLine());
            //MinValueInRow(matrix, Hang);
            TransposeMatrix(matrix);
            PrintSecondaryDiagonal(matrix);
        }
        public static void IndexOfMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 101);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
        static void PrintRow(int[,] matrix, int row)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[row, j] + " ");
            }
            Console.WriteLine();
        }

        static void PrintColumn(int[,] matrix, int col)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, col]);
            }
        }
        static void FindMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int value in matrix)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            Console.WriteLine(max);
        }
        static void MinValueInRow(int[,] matrix, int Hang)
        {
            int min = matrix[0, Hang];
            foreach (int value in matrix)
            {
                if (value < min)
                {
                    min = value;
                }

            }
            Console.WriteLine(min);

        }
        

        static void TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transposedMatrix = new int[cols, rows];

            // Thực hiện chuyển vị
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                   
                }
                
            }
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }



        }
        static void PrintSecondaryDiagonal(int[,] matrix)
        {
            int n = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, n - 1 - i] + "\t");
            }
            Console.WriteLine();
        }

    }
}
