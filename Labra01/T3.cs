using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T3
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 3. \nTee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.");
            //TODO kysytään käyttäjältä 3 numeroa

            Console.WriteLine("Anna 3 lukua");
            int[] num = new int[3];
            int sum = 0;
            double keskiarvo;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                sum += num[i];
            }
            //tulostetaan summan
            Console.WriteLine("Summa: " + sum);
            //tulostetaan keskiarvon
            keskiarvo = (double)sum / 3;
            Console.WriteLine("Keskiarvo: " + keskiarvo);


        }
    }
}
