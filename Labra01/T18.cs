using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T18
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 18. Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause).Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.");
            Console.WriteLine("\nAnna merkkijonon > ");
            String lause;
            
            
            lause = Console.ReadLine();

            int i = 0;
            int pituus = lause.Length;
            char[] array = new char[pituus];
            char[] reverse_array = new char[pituus];
            bool palidrom = false;
            foreach (char c in lause)
            {
                
                array[i] = c;
                
                //Console.WriteLine(array[i]);
                i++;
            }


            //Console.WriteLine("Lause length " + pituus);
            i = pituus-1;
            for (int k = 0; k < pituus; k++)
            {
                reverse_array[k]=array[i];
                Console.WriteLine("reverse_array[" + k + "] = " + reverse_array[k]);
                i--;
               
            }
            Console.WriteLine();


            for (int j=0; j<pituus; j++) { // vertaillaan
                if (array[j] == reverse_array[j])
                {
                    palidrom = true;
                    Console.WriteLine("array[" + j + "] == reverse_array[" + j + "] = " + array[j]);
                }
                else
                {
                    palidrom = false;
                    break;
                }
                
            }
            if (palidrom) Console.WriteLine("Se on palidromi");
            else Console.WriteLine("Se ei ole palidromi");
        }
    }
}
