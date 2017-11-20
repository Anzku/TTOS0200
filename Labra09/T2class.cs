using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra09
{
    public static class Joukkoe
    {
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> lista = new List<Pelaaja>();
            lista.Add(new Pelaaja("ANTTONI", "HONKA", "R", 3));
            lista.Add(new Pelaaja("JUUSO", "VAINIO", "R", 5));
            lista.Add(new Pelaaja("MIKKO", "KALTEVA", "L", 7));
            lista.Add(new Pelaaja("JAAKKO", "JOKINEN", "L", 16));
            lista.Add(new Pelaaja("ALEX", "LINDROOS", "L", 34));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
            lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
            return lista;
        }
    }
    public class Pelaaja
    {
        public string etunimi { get; set; }
        public string sukunimi { get; set; }
        public string katisyys { get; set; }
        public int numero { get; set; }
        public Pelaaja(string etunimi, string sukunimi, string katisyys, int num)
        {

            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.katisyys = katisyys;
            numero = num;
        }

    }
    /*
    public class Pelaaja
    {
        string etunimi;
        string sukunimi;
        string katisyys;
        int numero;
        public Pelaaja(string etunimi, string sukunimi, string katisyys, int num)
        {
            
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.katisyys = katisyys;
            numero = num;
        }
        /*
        public override string ToString()

        {
            string katisyys;
            if (katisyysR) katisyys = "R";
            else katisyys = "L";
            return "Pelaaja: " + etunimi + " " + sukunimi + ", numero #" + numero + ", kätisyys (" + katisyys + ");\n";
        }*/

}
/*public class Joukkue
{
    string nimi;
    string kotikaupunki;
    public List<Pelaaja> pelaajat;
    public Joukkue(string Nimi, string Kotikaupunki)
    {
        nimi = Nimi;
        kotikaupunki = Kotikaupunki;
        pelaajat = HaePelaajat();

    }
    public static List<Pelaaja> HaePelaajat1()
    {
        List<Pelaaja> lista = new List<Pelaaja>();
        lista.Add(new Pelaaja("ANTTONI", "HONKA", "R", 3));
        lista.Add(new Pelaaja("JUUSO", "VAINIO", "R", 5));
        lista.Add(new Pelaaja("MIKKO", "KALTEVA", "L", 7));
        lista.Add(new Pelaaja("JAAKKO", "JOKINEN", "L", 16));
        lista.Add(new Pelaaja("ALEX", "LINDROOS", "L", 34));
        lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
        lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
        lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
        lista.Add(new Pelaaja("Nimi", "Sukunimi", "R", 0));
        return lista;
    }
/*
public override string ToString()
{
    string list = "";
    foreach (Pelaaja henkilo in pelaajat)
    {
        list += henkilo.ToString();
    }
    return "Joukko: " + nimi + ", kotikaupunki: " + kotikaupunki + "\nPelaajat:\n" + list;
}
}
}*/
