using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T10
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 10. \nOhjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. \nKäy sovelluksessa taulukko läpi ja tulosta ruutuun 'HEP'-sana aina kun taulukossa oleva luku on parillinen.");
            int[] numbers = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i=0; i<numbers.Length; i++)
            {
                String text = "number[" + i + "]=" + numbers[i] + " ";
                if (numbers[i] % 2 == 0) Console.WriteLine(text + "HEP!");
                else Console.WriteLine(text);
            }
            Console.Read();

        }
    }
}
