using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T13
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 13. \nMäkihypyssä käytetään viittä arvostelutuomaria. \nKirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, \nettä summasta on vähennetty pois pienin ja suurin tyylipiste.\n\n");
            int[] pisteet = new int[5];
            for (int i=0;i<5;i++)
            {
                Console.Write("Anna pisteet > ");
                pisteet[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(pisteet);
            int sum=0;
            for (int i = 1; i < 4; i++) sum += pisteet[i];
            Console.WriteLine("Kokonaispisteet ovat " + sum);
            
        }
    }
}
