namespace Exercises_0
{
    internal class _2
    {
        /*public static void Main(string[] args)
        {
            Question_03();
        }*/
        /*to convert from degrees Celsius to Kelvin and Fahrenheit*/
        public static void Question_01() 
        {
            Console.WriteLine("nhap do C:");
            double c = double.Parse(Console.ReadLine());
            double k = c + 273;
            double f = (c*18 / 10) + 32;
            Console.WriteLine($"kelvin = {k}, fahrenheit = {f}");

        }
        /*Create a program in C# for calculate the surface and volume of a sphere, given its
radius.
- surface= 4 * pi * radius squared
- volume= 4 / 3 * pi * radius cubed
- Input
• 60
- Output
• Surface: 45238,93
• Volume: 678584,1
*/
        public static void Question_02() 
        {
            Console.WriteLine("nhap ban kinh r:");
            double r = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volume = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"sur= {surface}, vol = {volume}");
        }

        /* Write a program in C# that calculates the result of adding, subtracting,
multiplying and dividing two numbers entered by the user.
- In addition you should also calculate the rest of the division on the last line.
- Input
• 12
• 3
- Output
• 12 + 3 = 15
• 12 - 3 = 9
• 12 x 3 = 36
• 12 / 3 = 4
• 12 mod 3 = 0  */
        public static void Question_03()
        {
            Console.WriteLine("nhap so a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b:");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($@"{a} + {b} = {sum}
           {a} - {b} = {difference}
           {a} x {b} = {product}
           { a} / { b} = { quotient}
           {a} mod {b} = {remainder}");

        }
    }
}
