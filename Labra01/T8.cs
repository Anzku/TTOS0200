/* Olio-ohjelmointi Labra 01, Tehtävä 8
 * Prorammed by Anzhelika Kettunen 6.9.2017
 *
 * Ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T8
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 8. \nOhjelma kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.\n\n");
         
            int[] number = new int[3];
            for (int i=0;i<3;i++)
            {
                Console.Write("Anna luku > ");
                number[i] = Convert.ToInt32(Console.ReadLine());
                    
            }

            Array.Sort(number);
            Console.WriteLine("Suurin luku on " + number[2]);
        }
        
        
    }
}
