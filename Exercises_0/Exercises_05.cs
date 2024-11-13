//namespace Exercises_0
//{
//    internal class Exercises_05
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("enter the number of items (N)");
//            int N = int.Parse(Console.ReadLine());
//            int[] array = new int[N];

//            Console.WriteLine("enter the values for each item");
//            for (int i = 0; i < N; i++)
//            {
//                Console.Write($"item{i+1}:");
//                array[i]= int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("\nArray before modification:");
//            PrintArray(array);
//            IncreaseArrayItems(array);
//            Console.WriteLine("\nArray after adding 2 to each item:");
//            PrintArray(array);
//        }
//        static void PrintArray(int[] array)
//        {
//            foreach (int item in array)
//            {
//                Console.Write(item + " ");
//            }
//                Console.WriteLine();
//        }

//        static void IncreaseArrayItems(int[] array)
//        {
//            for (int i = 0;i < array.Length; i++)
//            {
//                array[i] += 2;

//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Create an array with random integer values
//        int[] array = GenerateRandomArray(10, 1, 100);
//        Console.WriteLine("Array: " + string.Join(", ", array));

//        // 1. Calculate the average value of array elements
//        Console.WriteLine("Average: " + CalculateAverage(array));

//        // 2. Test if an array contains a specific value
//        int testValue = 50;
//        Console.WriteLine($"Contains {testValue}: " + ContainsValue(array, testValue));

//        // 3. Find the index of an array element
//        Console.WriteLine($"Index of {testValue}: " + FindIndex(array, testValue));

//        // 4. Remove a specific element from an array
//        int removeValue = 50;
//        Console.WriteLine($"Array after removing {removeValue}: " + string.Join(", ", RemoveElement(array, removeValue)));

//        // 5. Find the maximum and minimum values of an array
//        Console.WriteLine("Max value: " + FindMax(array));
//        Console.WriteLine("Min value: " + FindMin(array));

//        // 6. Reverse an array of integer values
//        Console.WriteLine("Reversed Array: " + string.Join(", ", ReverseArray(array)));

//        // 7. Find duplicate values in an array
//        Console.WriteLine("Duplicates: " + string.Join(", ", FindDuplicates(array)));

//        // 8. Remove duplicate elements from an array
//        Console.WriteLine("Array without duplicates: " + string.Join(", ", RemoveDuplicates(array)));
//    }

//    // Generate an array with random integer values
//    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
//    {
//        Random rand = new Random();
//        int[] array = new int[size];
//        for (int i = 0; i < size; i++)
//        {
//            array[i] = rand.Next(minValue, maxValue);
//        }
//        return array;
//    }

//    // 1. Calculate the average value of array elements
//    static double CalculateAverage(int[] array)
//    {
//        return array.Average();
//    }

//    // 2. Test if an array contains a specific value
//    static bool ContainsValue(int[] array, int value)
//    {
//        return array.Contains(value);
//    }

//    // 3. Find the index of an array element
//    static int FindIndex(int[] array, int value)
//    {
//        return Array.IndexOf(array, value);
//    }

//    // 4. Remove a specific element from an array
//    static int[] RemoveElement(int[] array, int value)
//    {
//        return array.Where(x => x != value).ToArray();
//    }

//    // 5. Find the maximum value of an array
//    static int FindMax(int[] array)
//    {
//        return array.Max();
//    }

//    // Find the minimum value of an array
//    static int FindMin(int[] array)
//    {
//        return array.Min();
//    }

//    // 6. Reverse an array of integer values
//    static int[] ReverseArray(int[] array)
//    {
//        int[] reversedArray = (int[])array.Clone();
//        Array.Reverse(reversedArray);
//        return reversedArray;
//    }

//    // 7. Find duplicate values in an array
//    static List<int> FindDuplicates(int[] array)
//    {
//        var duplicates = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
//        return duplicates;
//    }

//    // 8. Remove duplicate elements from an array
//    static int[] RemoveDuplicates(int[] array)
//    {
//        return array.Distinct().ToArray();
//    }
//}
