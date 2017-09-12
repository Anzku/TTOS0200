using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T17
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 17.\nTee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon.");
            int[] taulukko1 = new int []{ 10, 20, 30, 40, 50 };
            int[] taulukko2 = new int[] { 5, 15, 25, 35, 45 };
            Console.Write("\nLuvut taulukossa 1 : ");
            for (int i = 0; i < taulukko1.Length; i++)
            {
                Console.Write(taulukko1[i]);
                if (i < (taulukko1.Length - 1)) Console.Write(",");
            }
            Console.Write("\nLuvut taulukossa 2 : ");
            for (int i = 0; i < taulukko2.Length; i++)
            {
                Console.Write(taulukko2[i]);
                if (i < (taulukko2.Length - 1)) Console.Write(",");
            }
            int pituus = taulukko1.Length + taulukko2.Length;
            int[] taulukko3 = new int[pituus];
            for (int i=0; i<taulukko1.Length; i++)
            {
                taulukko3[i] = taulukko1[i];
            }
            for (int i = 0; i < taulukko2.Length; i++)
            {
                taulukko3[i+taulukko1.Length] = taulukko2[i];
            }
            Array.Sort(taulukko3);
            Console.Write("\nLuvut yhdistetyssä taulukossa : ");
            for (int i=0; i<taulukko3.Length; i++)
            {
                Console.Write(taulukko3[i]);
                if (i < (taulukko3.Length - 1)) Console.Write(",");
            }
        }
    }
}
