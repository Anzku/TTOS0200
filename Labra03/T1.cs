/*Tee luokka, jolla on seuraavat staattiset metodit:
bool OnkoLuku(string syote) ja bool OnkoPvm(string syote) 
Metodi OnkoLuku tutkii annetun merkkijonon ja palauttaa true jos syöte on muunnettavissa luvuksi (kokonaisluku tai desimaaliluku erottimena pilkku, pistettä ei hyväksytä).
Metodi OnkoPvm tutkii annetun merkkijonon ja palauttaa true jos syöte on suomalaisessa päivämäärämuodossa siis joko muotoa "pp.kk.vv" tai "pp.kk.vvvv", eli metodi esimerkiksi tunnistaa seuraavat merkkijonot päivämääriksi "1.2.13", "1.10.2017", "12.12.2017", "24.12.17"
Seuraavia syötteitä ei kelpuuteta: "12,12,2016" --> väärä erotin, tai "12.13.2017" --> väärä kuukausi tai "30.2.2017" --> helmikuussa ei ole kolmeakymmentä päivää! 
Tee testausta varten luokka TestiPeti, ja sinne sopiva metodi jolla testaat erilaisia vaihtoehtoja.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T1
    {
        public static void Tehtava()
        {
            Console.Write("Anna merkkijonon > ");
            string syote = Console.ReadLine();
            string vastaus;
            if (JokuLuokka.OnkoPvm(syote)) vastaus = "Merkkijono on Pvm";
            else vastaus = "Merkkijono ei ole Pvm";
            Console.WriteLine(vastaus);
            if (JokuLuokka.OnkoLuku(syote)) vastaus = "Merkkijono on kokonaisluku tai desimaaliluku";
            else vastaus = "Merkkijono ei ole luku";
            Console.WriteLine(vastaus);
        }
        
    }
    public class JokuLuokka
    {
        public static bool OnkoLuku(string syote)
        {
            /*kokonaisluku tai desimaaliluku erottimena pilkku*/
            char[] array = new char[syote.Length];
            int i = 0;
            bool change = false;
            foreach (char c in syote)
            {
                if (c == ',') return false;
                else array[i] = c;

                if (c == '.')
                {
                    array[i] = ',';
                    change = true;
                }
                    i++;
            }
            if (change)
            {
                string uusiSyote = "";
                for (int j = 0; j < array.Length; j++) uusiSyote += array[j];
                syote = uusiSyote;
            }
            
            int num;
            double d;
            if ((int.TryParse(syote, out num)) || (double.TryParse(syote, out d)))
                return true;
            else return false;
        }
        public static bool OnkoPvm(string syote)
            /*"pp.kk.vv" tai "pp.kk.vvvv"*/
        {
            
            foreach (char c in syote)
            {
                if (c == ',') return false;
            }
            DateTime dateValue;
            if (DateTime.TryParse(syote, out dateValue))
                return true;
            else return false;
        }
    }
    
}
