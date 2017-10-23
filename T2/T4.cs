using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra05
{
    class T4
    {
        public static void Test()
        {
            Joukkue jouk = new Joukkue("JYP", "Jyväskylä");
            Console.WriteLine(jouk);
        }
    }
    class Pelaaja
    {
        string etunimi;
        string sukunimi;
        bool katisyysR;
        int numero;
        public Pelaaja(string etunimi, string sukunimi, bool katisyysR, int num)
        {
            //etunimi, sukunimi, kätisyys(L tai R), numero
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.katisyysR = katisyysR;
            numero = num;
        }
        public override string ToString()

        {
            string katisyys;
            if (katisyysR) katisyys = "R";
            else katisyys = "L";
            return "Pelaaja: " + etunimi + " " + sukunimi + ", numero #" + numero + ", kätisyys (" + katisyys + ");\n";
        }

    }
    class Joukkue
    {
        string nimi;
        string kotikaupunki;
        List<Pelaaja> pelaajat;
        public Joukkue(string Nimi, string Kotikaupunki)
        {
            nimi = Nimi;
            kotikaupunki = Kotikaupunki;
            pelaajat = HaePelaajat(nimi);

        }
        public List<Pelaaja> HaePelaajat(string joukkue)
        {
            List<Pelaaja> lista = new List<Pelaaja>();
            lista.Add(new Pelaaja("ANTTONI", "HONKA", true, 3));
            lista.Add(new Pelaaja("JUUSO", "VAINIO", true, 5));
            lista.Add(new Pelaaja("MIKKO", "KALTEVA", false, 7));
            lista.Add(new Pelaaja("JAAKKO", "JOKINEN", false, 16));
            lista.Add(new Pelaaja("ALEX", "LINDROOS", false, 34));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", true, 0));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", true, 0));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", true, 0));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", true, 0));
            return lista;
        }
        public override string ToString()
        {
            string list="";
            foreach (Pelaaja henkilo in pelaajat)
            {
                list += henkilo.ToString();
            }
            return "Joukko: "+nimi+", kotikaupunki: "+kotikaupunki+"\nPelaajat:\n"+list;
        }
    }
}
