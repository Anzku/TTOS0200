/* Olio-ohjelmointi Labra 01, Tehtävä 7
 * Prorammed by Anzhelika Kettunen 6.9.2017
 *
 * Ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
 */
  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    public class T7
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 7. Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi.Vuosiluku kysytään käyttäjältä.");
            Console.Write("Anna vuosi > ");
            int vuosi = int.Parse(Console.ReadLine());
            if ((vuosi % 4 == 0)) Console.WriteLine("Vuosi on karkausvuosi");
            else Console.WriteLine("Vuosi ei ole karkausvuosi");

        }

    }
}
