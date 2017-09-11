using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T15
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 15. Tee ohjelma, joka tulostaa kuvion - 'kuusi'.\nKysy käyttäjältä puunkorkeus, käytä juurena kaksi korkeuden yksikkö.");
            Console.Write("Anna Luku > ");
            int korkeus = Convert.ToInt32(Console.ReadLine());
            korkeus-= 2;
            for (int i=1;i<=korkeus;i++)
            {
                for (int j = 1; j <= (korkeus - i); j++) Console.Write(" ");
                for (int j = 1; j <= (i*2-1); j++) Console.Write("*");
                for (int j = 1; j <= (korkeus - i); j++) Console.Write(" ");
                Console.WriteLine();
            }
            for (int i=0;i<2;i++)
            {
                for (int j = 1; j <= (korkeus - 1); j++) Console.Write(" ");
                Console.WriteLine("*");
            }
            

        }
    }
}
