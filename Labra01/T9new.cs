/* Olio-ohjelmointi Labra 01, Tehtävä 9
 * Prorammed by Anzhelika Kettunen 11.9.2017
 *
 * Ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    public class T9new
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 9. \nOhjelma kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.\n\n");

            int[] number = new int [50];
            int sum = 0;
            int i = -1;
            do
            {
                Console.Write("Anna luku > ");
                i++;
                number[i] = Convert.ToInt32(Console.ReadLine());
                sum += number[i];

            } while (number[i] != 0);


            Console.WriteLine("Lukujen summa on " + sum);
            Console.Read();
        }


    }
}
