using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T11
    {
        public static void Tehtava()
        {
            Console.WriteLine("Kahden sisäkkäisen for-silmukan ohjelma, joka tulostaa kuvion");
            Console.Write("Anna rivien määrä > ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int rivi=0; rivi<number; rivi++)
            {
                for (int column=0; column<=rivi; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
