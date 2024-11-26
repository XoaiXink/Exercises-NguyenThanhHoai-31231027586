using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("nhap string:");
            string input = Console.ReadLine();
            //1.in mang
            Console.WriteLine($"mang ban vua nhap la :{input} ");
            //2.tim length
            int count = 0;
            foreach (char c in input)
            {
                //Console.WriteLine(c);
                count++;
            }
            Console.WriteLine(count);
            //3. seperate chars from a string
            foreach (char c in input)
            {
                Console.Write(c + " ");
            }
            //4.print in reverse order
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);

            }
            //5.count total num
            int wordCount = 1;
            foreach (char c in input)
            {
                if (c == ' ') wordCount++;
            }
            Console.WriteLine("Total number of words: " + wordCount);
            //6.compare 2 strings
            Console.WriteLine("nhap them 1 mang de so sanh");
            string anotherinput = Console.ReadLine();
            bool equal = true;
            if (input.Length != anotherinput.Length)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != anotherinput[i])
                    {
                        equal = false;
                    }
                }
            }
            if (equal)
            {
                Console.WriteLine("2 strings = nhau");
            }
            else
            {
                Console.WriteLine("2 strings khac nhau");
            }
            //7.count alphabets, digits, special characters
            Console.WriteLine("nhap 1 string");
            string s = Console.ReadLine();
            int countdigit = 0;
            int countletter = 0;
            int countspecialchar = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    countdigit++;
                }
                else if (char.IsLetter(s[i]))
                {
                    countletter++;
                }
                else
                {
                    countspecialchar++;
                }
            }
            Console.WriteLine($"digit: {countdigit},letter :{countletter},special char :{countspecialchar}");
            //8. count vowels, consonants
            int vowel = 0;
            int cons = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // Check if the character is a vowel (both lowercase and uppercase)
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' ||
                    s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel++;
                }
                // Check if the character is an alphabet (both lowercase and uppercase) but not a vowel
                else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    cons++;
                }
            }
            //9.to check whether a given substring is present in the given string
            Console.WriteLine("enter s1");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter s2");
            string s2 = Console.ReadLine();
            bool m;
            m = s1.Contains(s2);

            if (m)
                Console.Write("The substring exists in the string.");
            else
                Console.Write("The substring does not exist in the string.");

            // 10. Search for the position of a substring within a string
            int position = s1.IndexOf(s2);
            Console.WriteLine("Substring position: " + (position >= 0 ? position.ToString() : "not found"));

            // 11. Check whether a character is an alphabet and its case
            Console.WriteLine("Enter a character to check if it is an alphabet and its case:");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(ch))
            {
                string caseType = char.IsUpper(ch) ? "uppercase" : "lowercase";
                Console.WriteLine($"The character is an alphabet and it is {caseType}.");
            }
            else
            {
                Console.WriteLine("The character is not an alphabet.");
            }

            // 12. Find the number of times a substring appears in a given string
            count = 0;
            int startIndex = 0;
            while ((startIndex = input.IndexOf(s2, startIndex)) != -1)
            {
                count++;
                startIndex += s2.Length;
            }
            Console.WriteLine($"The substring appears {count} times.");

            // 13. Insert a substring before the first occurrence of a string
            Console.WriteLine("Enter the substring to insert:");
            string insertSubstring = Console.ReadLine();
            int insertPosition = input.IndexOf(s2);
            if (insertPosition != -1)
            {
                string result = input.Substring(0, insertPosition) + insertSubstring + input.Substring(insertPosition);
                Console.WriteLine("Modified string: " + result);
            }
            else
            {
                Console.WriteLine("Substring not found, no insertion made.");
            }
        }


    }
}
 
