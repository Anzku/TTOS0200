using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T2
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 2. \nTee ohjelma, jossa annetaan oppilaalle koulunumero taulukon mukaan(pistemäärä kysytään ja ohjelma tulostaa numeron)");
            Console.Write("Anna pistemäärä > ");
            int pisteet = int.Parse(Console.ReadLine());
            pisteet = pisteet / 2;
            if (pisteet == 6) pisteet = 5;
            Console.WriteLine("Koulunumero on " + pisteet);
        }
        

    }
}
