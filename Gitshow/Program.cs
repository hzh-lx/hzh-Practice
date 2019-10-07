using System;

namespace Gitshow
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(1000);
            Console.WriteLine("请输入你所要猜的字符只有5次机会,数字范围在0到1000以内的整数。");
            for (int i = 0; i < 5; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (random == number)
                { Console.WriteLine("恭喜你答对了"); }
                else
                { if (i != 4)
                    { Console.WriteLine($"不好意思你答错了，你还有{4 - i}次机会"); }
                else
                    { Console.WriteLine($"不好意思你输了,正确数值为{random}"); }
                }
             
            }


        }
    }
}
