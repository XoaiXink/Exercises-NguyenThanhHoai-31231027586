

using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercises_0
{
    internal class _4
    {
        //1. Write a C# function to find the maximum of three numbers.
        /*static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c)); // Tìm số lớn nhất trong ba số
        }
        static void Main()
        {
            Console.WriteLine(MaxOfThree(3, 5, 2)); // Kết quả: 5
        }
       //1.1 Improve the next version that accept at least 1 parameter
        static int MaxOfThree(int a, int b = int.MinValue, int c = int.MinValue)
        {
            return Math.Max(a, Math.Max(b, c)); // Tìm số lớn nhất với ít nhất 1 tham số
        }
        static void Main()
        {
            Console.WriteLine(MaxOfThree(3)); // Kết quả: 3
            Console.WriteLine(MaxOfThree(3, 5)); // Kết quả: 5
            Console.WriteLine(MaxOfThree(3, 5, 2)); // Kết quả: 5
        }*/
        //2.Write a C# function to calculate the factorial of a number (a non-negativeinteger). The function accepts the number as an argument.
        /* static int Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("Số phải là không âm.");
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine(Factorial(5)); // Kết quả: 120
        }*/
        //3.Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /*static bool IsPrime(int number)
        {
            if (number <= 1) return false; // Các số <= 1 không phải là số nguyên tố
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false; // Nếu chia hết thì không phải là số nguyên tố
            }
            return true;
        }

        static void Main()
        {
            Console.WriteLine(IsPrime(11)); // Kết quả: True
            Console.WriteLine(IsPrime(4));  // Kết quả: False
        }*/

        //4.Write a C# function to print:1. all prime numbers that less than a number(enter prompt keyboard).
        /*static void PrintPrimesLessThan(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i); // In ra số nguyên tố
                }
            }
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Nhập một số: ");
            int n = int.Parse(Console.ReadLine());
            PrintPrimesLessThan(n);*/


        //the first N prime numbers
        /*static void PrintFirstNPrimes(int n)
        {
            int count = 0;
            int number = 2;
            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number); // In ra số nguyên tố
                    count++;
                }
                number++;
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Nhập số lượng số nguyên tố cần hiển thị: ");
            int n = int.Parse(Console.ReadLine());
            PrintFirstNPrimes(n);
        } */
        //Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000
      /*  static bool IsPerfect(int number)
        {
            int sum = 1;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i; // Cộng các ước của number
                }
            }
            return sum == number && number != 0;
        }

        static void PrintPerfectNumbers(int limit)
        {
            for (int i = 1; i < limit; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i); // In ra số hoàn hảo
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Các số hoàn hảo nhỏ hơn 1000:");
            PrintPerfectNumbers(1000);
        } */
      //  Write a C# function to check whether a string is a pangram or not.
        static bool IsPangram(string input)
        {
            input = input.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!input.Contains(c))
                {
                    return false; // Nếu thiếu bất kỳ chữ cái nào, không phải pangram
                }
            }
            return true;
        }

        static void Main()
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(IsPangram(sentence)); // Kết quả: True
        }
    }
}

