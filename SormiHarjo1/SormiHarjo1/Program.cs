/*
 *Olio-ohjelmointi ensimmäinen harjoitus
 * Programmed by Anzhelika Kettunen 30.8.2017
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SormiHarjo1
{
    class Program
    {
        
        static void AskNames()
        {
            //TODO kysytään käyttäjältä viisi nimeä
            //ja näytetään ne annetussa järjestyksessä ja aakkosjärjestyksessä
            Console.WriteLine("Anna etunimet");
            string[] nimi = new string[5];
            for (int i = 0; i < nimi.Length; i++)
            {
                nimi[i] = Console.ReadLine();
            }
            //tulostetaan nimet konsolille
            string output = "";
            for (int i = 0; i < 5; i++)
            {
                output += nimi[i] + " ";
            }
            Console.WriteLine("Annoit nimet: " + output);
            //lajitellaan aakkosjärjestykseen
            Array.Sort(nimi);
            output = "";
            for (int i = 0; i < 5; i++)
            {
                output += nimi[i] + " ";
            }
            Console.WriteLine("Aakkosjärjestyksessä nimet: " + output);
        }
        
        static void Main(string[] args)
        {
            AskNames();
            Console.ReadLine();
        }
    }
}
