using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_05
    {
        //public static void Main(string[] args)
        //{
        //    //Swap();
        //    Game_TaiXiu();
        //    //Question_01();
        //    //Question_02();
        //    //Question_04a();
        //    //Question_04b();
        //    //Question_05();
        //    //Question_06();
        //    Console.ReadKey();
        //}
        public static void Swap()
        {
            int a = 6; int b = 7;
            Console.WriteLine($"Before call a = {a}, b = {b}");
            swap(ref a, ref b);
            Console.WriteLine($"After call a = {a}, b = {b}");
            Console.ReadKey();
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// Máy tính sẽ đổ 3 con xúc sắc ngẫu nhiên
        /// Người chơi sẽ đoán là tài hay xỉu
        /// </summary>
        public static void Game_TaiXiu()
        {
            Game_engine();
        }
        static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void playOneRound(ref int user_money, ref int bet)
        {
            int comp_dice = rollDice();
            Console.WriteLine();
            Console.Write("Ban doan Tai hay Xiu? <T/X> ");
            string uesr_guessing = Console.ReadLine();
            if (uesr_guessing.ToUpper().Equals("T"))
            {
                if (comp_dice >= 10)//Tài
                {
                    Console.WriteLine("You Win!");
                    user_money += bet;
                    Console.WriteLine($"Nhan duoc them {bet}$");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    user_money -= bet;
                    Console.WriteLine($"{bet}$ thuoc ve chung toi!");
                }
            }
            else if (uesr_guessing.ToUpper().Equals("X"))
            {
                if (comp_dice < 10)//Xỉu
                {
                    Console.WriteLine("You Win!");
                    user_money += bet;
                    Console.WriteLine($"Nhan duoc them {bet}$");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    user_money -= bet;
                    Console.WriteLine($"{bet}$ thuoc ve chung toi!");
                }
            }
            else
            {
                Console.WriteLine("Vui long chon cho dung");
            }
        }
        static void Game_engine()
        {
            Console.WriteLine("___Chao mung den voi Game Tai Xiu ><___");
            Console.WriteLine("So tien hien co la: 1000$");
            Console.WriteLine();
            Console.WriteLine("Ban muon cuoc bao nhieu?");
            int bet = int.Parse(Console.ReadLine());
            int count = 0;
            int user_money = 1000;
            do
            {
                playOneRound(ref user_money, ref bet);
                count++;
                Console.Write("Ban co muon choi tiep hong? <C/K> ");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                {
                    Console.WriteLine();
                    Console.WriteLine("--/TONG KET/--");
                    Console.WriteLine($"So lan choi: {count}");
                    Console.WriteLine($"So tien ban co: {user_money}$");
                    Console.WriteLine("See you again! ><");
                    break;
                }
            } while (true);
        }
    }
}