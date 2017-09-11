using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T14
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 14. \nKirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0 - 5 ohjelmointi - opintojaksosta.\nTulosta arvosanajakauma käyttäen tähtimerkkejä");
            int[] arvosana = new int[8];
            for (int i=0;i<8;i++)
            {
                Console.Write("Anna arvosana > ");
                arvosana[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Arvosanat:");
            for (int i=0;i<=5;i++)
            {
                Console.Write(i + ": ");
                for (int j=0;j<8;j++)
                {
                    if (arvosana[j] == i) Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
