using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_05_01
    {
        public static void Main51(string[] args)
        {
            Console.WriteLine("day gom 5 phan tu");
            int[] arrays = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("nhap so ban muon tim kiem trong day");
            int N = int.Parse(Console.ReadLine());
            LinearSearch(arrays, N);
            if (LinearSearch(arrays, N) == -1)
            {
                Console.WriteLine("N khong nam trong day");
            }
            else
            {
                Console.WriteLine("N nam trong day");
            }

        }
        public static int LinearSearch (int[] arrays,int N)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == N)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
