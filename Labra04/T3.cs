using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class T3
    {
        public static void Test()
        {
            Seura seura1 = new Seura("HPK", "Hämeenlinna");
            Seura seura2 = new Seura("Pelicans", "Lahti");
            seura1.PelaajaAdd(new Pelaaja("Joonas", "Hämäläinen", "mv", true));
            seura1.PelaajaAdd(new Pelaaja("Hannu", "Salojarvi", "p", false));
            seura1.PelaajaAdd(new Pelaaja("Pekka", "Hämäläinen", "mv", true));
            seura1.PelaajaAdd(new Pelaaja("Janus", "Nurminen", "h", true));
            seura1.PelaajaAdd(new Pelaaja("Antti", "Niskanen", "mv", true));
            seura1.PelaajaAdd(new Pelaaja("Otto", "Järvinen", "p", true));
            seura2.PelaajaAdd(new Pelaaja("Mika", "Hämäläinen", "mv", true));
            seura2.PelaajaAdd(new Pelaaja("Jarno", "Sarvinen", "p", false));
            seura2.PelaajaAdd(new Pelaaja("Juha", "Talonpoika", "mv", true));
            seura2.PelaajaAdd(new Pelaaja("Pasi", "Hevosen", "p", false));
            seura2.PelaajaAdd(new Pelaaja("Joonas", "Mäkinen", "mv", true));
            seura2.PelaajaAdd(new Pelaaja("Mika", "Salojarvi", "h", false));
            seura2.PelaajaAdd(new Pelaaja("Niko", "Hämäläinen", "mv", true));
            seura2.PelaajaAdd(new Pelaaja("Harri", "Salojarvi", "h", false));
            seura2.PelaajaAdd(new Pelaaja("Teppo", "Hämäläinen", "mv", true));
            seura2.PelaajaAdd(new Pelaaja("Hannu", "Salojarvi", "p", false));
            Console.WriteLine(seura1);
            Console.WriteLine(seura2);
            
        }
        class Pelaaja
        {
            string etunimi;
            string sukunimi;
            string pelipaikka;
            bool katisyysR;
            public Pelaaja (string etunimi, string sukunimi, string pelipaikka, bool katisyysR)
            {
                //etunimi, sukunimi, pelipaikka(mv, p, h), kätisyys(L tai R)
                this.etunimi = etunimi;
                this.sukunimi = sukunimi;
                this.pelipaikka = pelipaikka;
                this.katisyysR = katisyysR;
            }
            public override string ToString()

            {
                string katisyys;
                if (katisyysR) katisyys = "R";
                else katisyys = "L";
                return "Pelaaja: " + etunimi + " " + sukunimi + ", pelipaikka: " + pelipaikka+", kätisyys ("+katisyys+");";
            }

        }
        class Seura
        {
            string nimi;
            string kaupunki;
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            public Seura (string nimi, string kaupunki) {
                this.nimi = nimi;
                this.kaupunki = kaupunki;
                Console.WriteLine("Uusi seura - nimi: " + nimi + ", kaupunki: " + kaupunki);
            }
            public void PelaajaAdd(Pelaaja henkilo)
            {
                pelaajat.Add(henkilo);
                Console.WriteLine(henkilo + " added to seura " + nimi);
            }
            public override string ToString()
            {
                string text= "\nTulostetaan kaikki tiedot\nSeuran nimi: " + nimi + ", kaupunki: " + kaupunki;
                foreach(Pelaaja henkilo in pelaajat)
                {
                    text += "\n   - "+henkilo;
                }
                return text;
            }

            //nimi, kaupunki ja kokoelma Pelaaja-olioita
        }
    }
}
