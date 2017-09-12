using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T4
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 4. \nTee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta 'alaikäinen', jos se on 18 - 65 vuotta, tulosta 'aikuinen', muussa tapauksessa tulosta 'seniori'.");
            //TODO kysytään käyttäjältä ikä

            Console.Write("Anna ikä > ");

            int age = int.Parse(Console.ReadLine());
            //analysöidään ikä
            if (age < 18) Console.WriteLine("Sinä olet alaikäinen!");
            if (age > 17 && age < 66) Console.WriteLine("Sinä olet aikuinen!");
            if (age > 65) Console.WriteLine("Sinä olet seniori!");


        }
    }
}
