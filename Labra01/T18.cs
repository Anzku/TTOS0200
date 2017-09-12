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
            bool polinome = false;
            
            lause = Console.ReadLine();

            int i = 0;
            char[] array = new char[lause.Length];
            char[] reverse_array = new char[lause.Length];
            foreach (char c in lause)
            {
                
                array[i] = c;
                reverse_array[i] = c;
                Console.WriteLine(array[i]);
            }


            Console.WriteLine("Lause length " + lause.Length);

            for (int k = 3; k >= 0; k--)
            {
                reverse_array[k]=array[(3-k)];
                Console.Write(reverse_array[k]);

            }
            Console.WriteLine();


            for (int j=0; j<lause.Length; j++) { // vertaillaan
                if (array[j] == reverse_array[j]) 
                    {
                        polinome = true;
                    }
                
            }
            if (polinome) Console.WriteLine("Se on polinome");
            else Console.WriteLine("Se ei ole polinome");
        }
    }
}
