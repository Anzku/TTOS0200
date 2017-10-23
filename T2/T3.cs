using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra05
{
    class T3
    {
        public static void Start()
        {
            List<Card> Kortit = new List<Card>();
            Kortit = TekeKortit();
            int i = 1;
            foreach (Card kortti in Kortit)
            {
                Console.WriteLine(i+" kortti on " + kortti);
                i++;
            }
            Console.WriteLine("\nKorttipakkasi on sekoitettu");
            Korttipakka pakka = new Korttipakka("52 korttia",Kortit);
            pakka.Shuffle();
            Console.WriteLine(pakka.ToString());

        }
        
        public static List<Card> TekeKortit()
        {
            List<Card> kortit = new List<Card>();
            string tyypi="";
            int number = 1;
            for (int t = 1; t<=4; t++)
            {
                switch (t)
                {
                    case 1:
                        tyypi = "hertta";
                        break;
                    case 2:
                        tyypi = "ruutu";
                        break;
                    case 3:
                        tyypi = "risti";
                        break;
                    case 4:
                        tyypi = "pata";
                        break;
                }
                for (int i = 1; i <= 13; i++)
                {
                    kortit.Add(new Card(tyypi, i));
                    number++;
                }
            }
            return kortit;
        }
        
    }
    class Card
    {

        string tyypi;
        int value;
        public Card(string tyypi, int value)
        {

            this.tyypi = tyypi;
            this.value = value;
        }
        public override string ToString()
        {
            return tyypi + " #" + value;
        }
    }
    class Korttipakka
    {
        List<Card> pakka;
        string nimi;
        public Korttipakka(string nimi, List<Card> pakka)
        {
            this.nimi = nimi;
            this.pakka = pakka;
        }
        public void Shuffle()
        {
            Card temp;
            Random rnd = new Random();
            for (int i = 0; i < pakka.Count; i++)
            {
                int index = rnd.Next(i, pakka.Count);
                temp = pakka[i];
                pakka[i] = pakka[index];
                pakka[index] = temp;

            }

        }
        public override string ToString()
        {
            string text = "";
            text += nimi + "\n";
            int i = 1;
            foreach (Card kortti in pakka)
            {
                text += " -- " + i + " kortti on " + kortti + "\n";
                i++;
            }
            return text;
        }
    }
}
