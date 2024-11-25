using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_05_0
    {
        //        Create a random integer values array, then create functions that:
        //1. to calculate the average value of array elements.
        //2. to test if an array contains a specific value.
        //3. to find the index of an array element.
        //4. to remove a specific element from an array.
        //5. to find the maximum and minimum value of an array.
        //6. to reverse an array of integer values.
        //7. to find duplicate values in an array of values.
        //8. to remove duplicate elements from an array.
        public static void Main5(string[] args)
        {
            Console.WriteLine("nhap so phan tu N cua day");
            int N = int.Parse(Console.ReadLine());
            int[] arrays = new int[N];
            Random rnd = new Random();
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                arrays[i] = rnd.Next(1, 101);
                Console.Write(arrays[i] + " ");
                sum += arrays[i];
            }
            Console.WriteLine();
            double avr = sum / N;
            Console.WriteLine($"Gia tri trung binh la: {avr:F2}");
            Console.WriteLine("nhap gia tri can tim kiem");
            int x = int.Parse(Console.ReadLine());
            int y = LinearSearch(arrays, x);
            if (y == -1)
            {
                Console.WriteLine("gia tri ban nhap khong nam trong day");
            }
            else
            {
                Console.WriteLine("gia tri ban nhap nam trong day");
            }
            Console.WriteLine("nhap mot gia tri nao do trong mang");
            int giatri = int.Parse(Console.ReadLine());
            timkiemvitri(arrays, giatri);
            Console.WriteLine("nhap phan tu ban muon xoa khoi day");
            int phantumuonxoa = int.Parse(Console.ReadLine());
            Xoaphantukhoimang(arrays, phantumuonxoa);
            Console.WriteLine("gia tri lon nhat trong day la");
            Maxofarrays(arrays);
            Console.WriteLine("gia tri nho nhat trong day la"); Minofarrays(arrays);
            Console.WriteLine("dao nguoc mang");
            ReverseArrays(arrays);
            Console.WriteLine("gia tri trung lap trong mang");
            Timkiemgiatritrunglaptrongmang(arrays);
            Console.WriteLine("xoa gia tri trung lap khoi mang");
            XoaGiaTriTrungLap(arrays);
        }
        public static int LinearSearch(int[] arrays, int x)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void timkiemvitri(int[] arrays, int giatri)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] == giatri)
                {
                    Console.WriteLine($"gia tri ban nhap nam o vi tri thu {i + 1} trong day");
                }
            }
            Console.WriteLine();
        }
        public static void Xoaphantukhoimang(int[] arrays, int phantumuonxoa)
        {
            arrays = arrays.Where(x => x != phantumuonxoa).ToArray();

            string result = string.Join(", ", arrays);
            Console.WriteLine($"day moi la: {result} ");
        }
        public static void Maxofarrays(int[] arrays)
        {
            int max = arrays[0];
            for(int i = 0;i < arrays.Length; i++)
            {
                if (arrays[i] > max)
                {
                    max = arrays[i];
                }
            }
            Console.WriteLine(max);
        }
        public static void Minofarrays(int[] arrays)
        {
            int min = arrays[0];
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] < min)
                {
                    min = arrays[i];
                }
            }
            Console.WriteLine(min);
        }
        public static void ReverseArrays (int[] arrays)
        {
           Array.Reverse(arrays);
          string result = string.Join(", ", arrays); Console.WriteLine(result);
        }
        public static void Timkiemgiatritrunglaptrongmang(int[] arrays)
        {
            bool cogiatritrunglap = false;
            for(int i = 0;i<arrays.Length;i++)
             
            {
                for (int j = i + 1; j < arrays.Length; j++)
                {
                    if (arrays[i] == arrays[j])
                    {
                        Console.WriteLine(arrays[i]);
                        cogiatritrunglap = true;
                        break;
                    }

                }
            }
            if (!cogiatritrunglap) // Nếu không tìm thấy giá trị trùng lặp
            {
                Console.WriteLine("Không có giá trị trùng lặp trong mảng.");
            }

        }
        public static void XoaGiaTriTrungLap(int[] arrays)
        {
            // Sử dụng Distinct để loại bỏ giá trị trùng lặp
            arrays = arrays.Distinct().ToArray();

            // In ra mảng mới sau khi loại bỏ giá trị trùng lặp
            Console.WriteLine("Mảng sau khi loại bỏ giá trị trùng lặp:");
            Console.WriteLine(string.Join(", ", arrays));
        }

    }
}

