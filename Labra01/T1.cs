using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T1
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 1. \nTee ohjelma, joka tulostaa käyttäjän antamaa lukua(1, 2 tai 3) vastaavan luvun sanana(yksi, kaksi tai kolme).Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: 'joku muu luku'");
            Console.Write("Anna luku > ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1) Console.Write("Annoit luvun yksi");
                else if (num == 2) Console.Write("Annoit luvun kaksi");
                else if (num == 3) Console.Write("Annoit luvun kolme");
                else Console.WriteLine("Annoit joku muu luku");
            
        }
    }
}
