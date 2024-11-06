namespace Exercises_0
{
    internal class _3
    {
        /*public static void Main()
        {
            Question_1();
        }*/
        public static void Question_01()
        /*Write a C# Sharp program to display certain values of the function x = y2
+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).*/
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y= {y}, x={x}");
            }

        }
        public static void Question_02()
        /*Write a C# Sharp program that takes distance and time (hours, minutes,
seconds) as input and displays speed in kilometers per hour (km/h) and
miles per hour (miles/h). */
        {
            Console.WriteLine("nhap khoang cach");
            double kc = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap gio");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap phut");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap giay");
            int s = int.Parse(Console.ReadLine());
            double gio = h + p / 60.00 + s / 3600.00;
            double kmtrenh = kc / gio;
            double kcachmiles = kc * 0.621371;
            double milestrenh = kcachmiles / gio;
            Console.WriteLine($"{kmtrenh}, {milestrenh}");

        }
        public static void Question_03()
        /*Write a C# Sharp program that takes the radius of a sphere as input and
calculates and displays the surface and volume of the sphere. V =
4/3*π*r3*/
        {
            Console.WriteLine("nhap radius");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volume = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"suf= {surface}, vol = {volume}");

        }
        public static void Question_04()
        {
            Console.WriteLine("nhap mot char bat ki");
            char inputchar = Convert.ToChar(Console.ReadLine());
            if ("ueoaiUEOAI".IndexOf(inputchar) >= 0)
            {
                Console.WriteLine("la mot nguyen am");
            }
            else if (char.IsDigit(inputchar))
            {
                Console.WriteLine("la mot chu so");
            }
            else
            {
                Console.WriteLine("la mot ki tu");
            }
        }
        public static void Question_05()
        /* Write a C# Sharp program to check whether a given number is even or odd.*/
        {
            Console.WriteLine("nhap mot so bat ki");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("a la so chan");
            }
            else
            {
                Console.WriteLine("a la so le");
            }


        }
        public static void Question_06()
        /* Write a C# Sharp program to find the largest of three numbers.*/
        {
            Console.WriteLine("nhap so thu 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu 3");
            int c = int.Parse(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("a la so lon nhat");
            }
            else if ((a < b) && (b > c))
            {
                Console.WriteLine("b la so lon nhat");
            }
            else
            {
                Console.WriteLine("c la so lon nhat");
            }
        }
        public static void Question_07() /*Write a C# Sharp program to accept a coordinate point in an XY
coordinate system and determine in which quadrant the coordinate
point lies.*/
        {
            Console.WriteLine("nhap x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap y");
            int y = int.Parse(Console.ReadLine());
            if (((x > 0) && (x > 0)))
            {
                Console.WriteLine(" nam o 1st quadrant.");
            }
            else if (((x > 0) && (y < 0)))
            {
                Console.WriteLine(" nam o 4th quadrant.");
            }
            else if (((x < 0) && (y > 0)))
            {
                Console.WriteLine("nam o 2nd quadrant.");
            }
            else if (((x < 0) && (y < 0)))
            {
                Console.WriteLine("nam o 3rd quadrant");
            }


        }
        public static void Question_08()
        /*Write a program to check whether a triangle is Equilateral, Isosceles or
Scalene*/
        {
            Console.WriteLine("nhap do dai canh thu 1");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap do dai canh thu 2");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap do dai canh thu 3");
            int side3 = int.Parse(Console.ReadLine());
            if ((side1 == side2) && (side1 == side3))
            {
                Console.WriteLine("tam giac tren la tam giac deu");
            }
            else if ((side1 == side2) || (side1 == side3) || (side3 == side2))
            {
                Console.WriteLine("tam giac tren latam giac can");

            }
            else
            {
                Console.WriteLine("tam giac tren la tam giac thuong");
            }
        }
        public static void Question_09()
        /*Write a program to read 10 numbers and find their average and sum.*/
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"nhap cac gia tri {i} ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            double average = sum / 10.0;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
        public static void Question_10()
        /*Write a program to display the multiplication table of a given integer.*/
        {
            Console.Write($"nhap so bat ki");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int x = num * i;
                Console.WriteLine($"{num}*{i}={x}");
            }

        }

        public static void Question_11()
        /*  Write a program to display a pattern like triangles with a number*/
        {
            Console.WriteLine("viet so hang ban muon");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        public static void Question_12()
        {
            Console.WriteLine("viet so hang ban muon");
            int hang = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            for (int i = 1; i <= hang; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{num} ");
                    num++;
                }
                Console.WriteLine();
            }
        }
        public static void Question_13()
        {
            int numb = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{numb} ");
                    numb++;
                }
                Console.WriteLine();
            }

        }
        public static void Question_14()
        /* Write a program to display the n terms of harmonic series and their
sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms*/

        {
            Console.WriteLine("nhap mot so");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.Write($"1/{a}");
                if (i < a)
                { Console.Write("+"); }

            }
        }
        public static void Question_15()
        /* Write a program to display the n terms of harmonic series and their
sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms*/

        {
            Console.WriteLine("nhap mot so");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.Write($"1/{i}");
                if (i < a)
                { Console.Write("+"); }
                sum += 1 / i;

            }
        }
        public static void Question_16()
        /*Write a program to find the ‘perfect’ numbers within a given number range.*/
        {
            Console.WriteLine(" chon range ");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"give rangee se bau dau tu 1 den {range}");
            for (int i = 1; i <= range; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
    
        
        /*Write a program to determine whether a given number is prime or not.*/
       /* static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
       */