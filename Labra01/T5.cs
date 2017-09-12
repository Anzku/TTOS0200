using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra01
{
    class T5
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä 5. \nTee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.Aikamääre sekuntteina kysytään käyttäjältä.");
            Console.Write("Anna sekunnit > ");

            int s = int.Parse(Console.ReadLine());
            string answer = "Antamasi sekunttiaika voidaan ilmaista muodossa: ";

            //lasketaan tunnit
            int t = s / 3600;
            answer += t;
            if (t == 1) answer += string.Format(" tunti ");
            else answer += " tuntia ";
            s -= t * 3600;
            //lasketaan minuutit
            int m = s / 60;
            answer += m;
            if (m == 1) answer += " minuutti ";
            else answer += " minuuttia ";
            //lasketaan sekunnit

            s -= m * 60;
            answer += s;
            if (s == 1) answer += " sekuntti";
            else answer += " sekunttia";
            Console.WriteLine(answer);


        }
    }
}
