using Microsoft.Win32.SafeHandles;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_01
    {
        //public static void Main1()
        //{
        //    //Question_01();
        //    //Question_02();
        //    //Question_03();
        //    //Question_04();
        //    //Question_05();
        //    //Question_06();
        //    //Question_07();
        //    //Question_08();
        //    //Question_09();
        //    //Question_10();
        //    Console.ReadKey();
        //}
        public static void Question_01()   // to Add / Sum Two Numbers.//
        {
            Console.Write("nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap so b:");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.Write($" {c} = {a} +{b} ");
        }
        public static void Question_02() //to Swap Values of Two Variables.
        {
            Console.Write("nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap so b:");
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b; b = temp;
            Console.WriteLine($" a = {a}, b= {b}");
        }
        public static void Question_03() //to Multiply two Floating Point Numbers
        {
            Console.Write("nhap so a:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("nhap so b:");
            float b = float.Parse(Console.ReadLine());
            float c = a* b;
            Console.WriteLine(c);
        }
        public static void Question_04() // to convert feet to meter//
        {
            Console.WriteLine("nhap gia tri feet");
            float f = float.Parse(Console.ReadLine());
            double m = f * 30.48;
            Console.WriteLine(m);
        }
        public static void Question_05()    // to convert Celsius to Fahrenheit and vice versa
        {
            Console.WriteLine("Chon mot trong 2 cach muon doi:");
            Console.WriteLine("1. doi do C - F");
            Console.WriteLine("2. doi do F - C");
            double choice = double.Parse(Console.ReadLine());

            if (choice == 1) 
            {
                Console.WriteLine("nhap so C");
                double c = double.Parse(Console.ReadLine());
                double f = (c * 9 / 5) + 32;
                Console.WriteLine(f);
            }
            else if (choice == 2)
            {
                Console.WriteLine("nhap so F");
                double f = double.Parse(Console.ReadLine());
                double c = (f - 32) * 5 / 9;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("ban chi duoc chon 1 hoac 2");
            }

                

        }
        public static void Question_06() //to find the Size of data types
        {
            Console.WriteLine($"size of int = {sizeof(int)} bytes");
            Console.WriteLine($"size of float = {sizeof(float)} bytes");
            Console.WriteLine($"size of double = {sizeof(double)} bytes");
        }
        public static void Question_07()  //. to Print ASCII Value (tip: read character, print number of this char)
        {
            Console.WriteLine("nhap character ");
            char character = Console.ReadLine()[0];
            int ascii = (int)character;
            Console.WriteLine(ascii);
        }
        public static void Question_08()  //to Calculate Area of Circle
        {
            Console.WriteLine("nhap ban kinh cua hinh tron");
            double r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            Console.WriteLine(area);
        }
        public static void Question_09()   //. to Calculate Area of Square
        {
            Console.WriteLine("nhap canh cua hinh vuong");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine(area);

        }
        public static void Question_10()  //to convert days to years, weeks and days
        {
            Console.WriteLine("nhap ngay");
            int ngay = int.Parse(Console.ReadLine());
            int nam = ngay / 365;
            int tuan = (ngay - nam * 365)/7;
            int dayle = ngay - nam * 365 - tuan * 7;
            Console.WriteLine($"{nam}, {tuan},  {dayle}");
        }   
    }
}
