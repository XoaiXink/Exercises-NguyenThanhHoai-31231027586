using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENTHANHHOAI_31231027586_24C1INF50900503
{
    internal class Exercises_04_0
    {
        public static void Main4()
        {
            //Session04_00();
        }
        public static void Session04_00()
        {
            do
            {
                //Máy nghĩ ngẫu nhiên 1 số
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                //Hỏi người dùng đoán số
                //Đoán cho đến chừng nào đúng thì thôi
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("Ban doan so may? <1...10>");
                    int user_num = int.Parse(Console.ReadLine());
                    //Kiểm tra kết quả
                    if (user_num == comp_num)
                    {
                        Console.WriteLine("Ban la thien tai");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("So ban doan lon hon may nghi");
                        else
                            Console.WriteLine("So ban doan nho hon may nghi");
                    }
                } while (isContinue);

                Console.WriteLine("==================================================");
                Console.WriteLine("Choi nua khong? <C/K>: ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Thang ma khong cho go. Lan sau khong choi nua!");
                    return;
                }
            } while (true);
        }
    }
}
