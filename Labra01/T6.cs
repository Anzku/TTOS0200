using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T6
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 6. \nAuton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.\nTee ohjelma, joka tulostaa ajetulla matkalla(kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.\n\n");
            //TODO kysytään matka

            Console.Write("Anna matka > ");

            double matka = double.Parse(Console.ReadLine());
            double kulutus = 7.02;
            double hinta = 1.595;
            //lasketaan bensan kulutus
            double bensaa_kuluu = matka / 100 * kulutus;
            //lasketaan kustannus
            double kustannus = bensaa_kuluu * hinta;
            string answer = "Bensaa kuluu " + Math.Round(bensaa_kuluu, 2) + " litraa, kustannus " + Math.Round(kustannus, 2) + " euroa";

            Console.WriteLine(answer);


        }
    }
}
