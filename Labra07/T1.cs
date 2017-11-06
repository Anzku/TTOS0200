using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra07
{
    class T1
    {
        
        public static void Test()
        {
            Random rnd = new Random();
            int[] pisteet = new int[6];
            
            int value = rnd.Next(1, 7);
            Console.WriteLine("Dice, one test throw value is " + value);
            int sum=0;
            Console.WriteLine("How many times you want to throw a dice : ");

            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i<times; i++)
            {
                value = rnd.Next(1, 7);
                pisteet[value - 1]++;
                sum += value;
            }
            float fsum;
            fsum = sum;
            Console.WriteLine("Dice is now thrown {0} times, average is {1}",times,fsum/times);
            for (int i=0;i<6;i++)
            {
                Console.WriteLine("- {0} count is {1}", i + 1, pisteet[i]);

            }
        }
        
    }
}
