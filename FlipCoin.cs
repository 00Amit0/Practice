using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("Please enter the value for number of flips");
           // int Head = 0;
           // int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;
            double HeadPercentage;
            double TailPercentage;
            int flipcoin = Convert.ToInt32(Console.ReadLine());
            if (flipcoin > 0)
            {
                for (int i = 1; i <= flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    if (number == 1)
                    {
                        HeadCount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                    Console.WriteLine(number);
                }
                Console.WriteLine("----------------");
                HeadPercentage = HeadCount * 100 / flipcoin;
                TailPercentage = TailCount * 100 / flipcoin;
                Console.WriteLine("Head Percentage :"+ HeadPercentage);
                Console.WriteLine("Tail Percentage :"+ TailPercentage);

            }
        }
    }
}
