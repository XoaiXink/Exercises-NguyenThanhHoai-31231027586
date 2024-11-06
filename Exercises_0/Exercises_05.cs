namespace Exercises_0
{
    internal class Exercises_05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number of items (N)");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            Console.WriteLine("enter the values for each item");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"item{i+1}:");
                array[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nArray before modification:");
            PrintArray(array);
            IncreaseArrayItems(array);
            Console.WriteLine("\nArray after adding 2 to each item:");
            PrintArray(array);
        }
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
                Console.WriteLine();
        }
        
        static void IncreaseArrayItems(int[] array)
        {
            for (int i = 0;i < array.Length; i++)
            {
                array[i] += 2;

            }
        }
    }
}
