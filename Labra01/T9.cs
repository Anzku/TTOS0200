/* Olio-ohjelmointi Labra 01, Teht�v� 9
 * Prorammed by Anzhelika Kettunen 11.9.2017
 *
 * Ohjelma, joka kysyy k�ytt�j�lt� lukuja, kunnes h�n sy�tt�� luvun 0. Ohjelman tulee tulostaa sy�tettyjen lukujen summa.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T9
    {
        public static void Tehtava()
        {
            Console.WriteLine("Teht�v� 9. \nOhjelma kysyy k�ytt�j�lt� lukuja, kunnes h�n sy�tt�� luvun 0. Ohjelman tulee tulostaa sy�tettyjen lukujen summa.\n\n");

            int[] number = new int {};
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
        }


    }
}
