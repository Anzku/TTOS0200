using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T16
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 16. \nTee ohjelma, joka arpoo satunnaisluvun väliltä 0 - 100. \nKäytä C#:n Random -luokkaa. \nTämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. \nOhjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. \nTämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. \nTulosta lopuksi arvausten määrä näytölle. \n\n\n");
            Random rnd = new Random();
            int number = rnd.Next(0, 100);
            int arvo = 0;
            int luku;
            
            do
            {
                Console.Write("Arvaa luku > ");
                luku = Convert.ToInt32(Console.ReadLine());
                arvo++;
                if (luku > number) Console.WriteLine("Luku on pienempi");
                else if (luku < number) Console.WriteLine("Luku on suurempi");
                else Console.WriteLine("Hienoa, arvasit luvun " + arvo + " kerralla.");
            } while (luku != number);
            

        }
    }
}
