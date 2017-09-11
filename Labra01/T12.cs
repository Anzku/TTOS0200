using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T12
    {
        public static void Tehtava()
        {
            Console.WriteLine("Ohjelma kysyy käyttäjältä 5 kokonaislukua ja tulostaa annetut luvut käänteisessä järjestyksessä.");
            int[] number = new int[5];
            for (int i=0;i<5;i++)
            {
                Console.Write("Anna Luku > ");
                number[i] = Convert.ToInt32(Console.ReadLine());


            }
            Console.Write("Luvut ovat ");
            Array.Sort(number);
            for (int i=4;i>=0;i--)
            {
                Console.Write(number[i]);
                if (i != 0) Console.Write(", ");
                    
            }
            Console.Read();
        }
    }
}
