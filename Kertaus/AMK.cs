using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaus
{
    class AMK
    {
        static void Main(string[] args)
        {
            
            Tutkinto amkTutkinto = new Tutkinto();
            amkTutkinto.tutkinnonNimi = "Tieto- ja viestintätekniikka";
            HaeTTVOpintojaksot(amkTutkinto);
                        
            Tutkinto amkTutkinto2 = new Tutkinto();
            amkTutkinto2.tutkinnonNimi = "Energia- ja ympäristötekniikka";
            HaeEYOpintojaksot(amkTutkinto2);

            List<Tutkinto> tutkinnot = new List<Tutkinto>();
            tutkinnot.Add(amkTutkinto);
            tutkinnot.Add(amkTutkinto2);
            foreach (Tutkinto tutkinto in tutkinnot)
            {
                Console.WriteLine(tutkinto.ToString());
            }

            Console.WriteLine("Kunkin opintojakson opettajien ja opiskelijoiden lukumäärä ja nimet (vain TTV tutkinnolle)");
            //// Kunkin opintojakson opettajien ja opiskelijoiden lukumäärä ja nimet.
            /*
            foreach (Tutkinto tutkinto in tutkinnot)
            {
                foreach (Opintojakso jakso in tutkinto.opintojaksot)
                {
                    Console.WriteLine("Opintojakson nimi: "+jakso.nimi);
                    Console.WriteLine("Opettajien lukumäärä: " + jakso.opettajat.Count());
                    Console.WriteLine("Opiskelijoiden lukumäärä: " + jakso.opiskelijat.Count());
                }
            }*/
            
            foreach (Opintojakso jakso in amkTutkinto.opintojaksot)
            {
                Console.WriteLine("\n\nOpintojakson nimi: " + jakso.nimi);
                Console.WriteLine("\nOpettajien lukumäärä: " + jakso.opettajat.Count());
                foreach (Opettaja ope in jakso.opettajat)
                {
                    Console.WriteLine(ope.ToString());
                }
                Console.WriteLine("\nOpiskelijoiden lukumäärä: " + jakso.opiskelijat.Count());
                foreach (Opiskelija opi in jakso.opiskelijat)
                {
                    Console.WriteLine(opi.ToString());
                }
                
            }

        }
        public static void HaeTTVOpintojaksot(Tutkinto tutk)
        {
            Opettaja henkilo1 = new Opettaja("Matti Karkki");
            Opettaja henkilo2 = new Opettaja("Antti Niskanen");
            Opettaja henkilo3 = new Opettaja("Jani Kananen");
            Opettaja henkilo4 = new Opettaja("Pirjo Valanen");
            Opiskelija henkilo5 = new Opiskelija("Mika Nurminen");
            Opiskelija henkilo6 = new Opiskelija("Niko Tepponen");
            Opiskelija henkilo7 = new Opiskelija("Emilia Rytkönen");
            Opiskelija henkilo8 = new Opiskelija("Jarmo Salojärvi");

            Opintojakso TTKS0100 = new Opintojakso("TTKS0100", "Data Network Protocols", "en");
            TTKS0100.opettajat.Add(henkilo1);
            TTKS0100.opettajat.Add(henkilo2);
            TTKS0100.opiskelijat.Add(henkilo5);
            TTKS0100.opiskelijat.Add(henkilo6);
            TTKS0100.opiskelijat.Add(henkilo7);
            Opintojakso TTKS0700 = new Opintojakso("TTKS0700", "Data Security Testing", "en");
            TTKS0700.opettajat.Add(henkilo3);
            TTKS0700.opiskelijat.Add(henkilo8);
            Opintojakso TTOS0200 = new Opintojakso("TTOS0200", "Olio-ohjelmointi", "fi");
            TTOS0200.opettajat.Add(henkilo4);
            TTOS0200.opiskelijat.Add(henkilo5);
            TTOS0200.opiskelijat.Add(henkilo6);
            TTOS0200.opiskelijat.Add(henkilo7);
            TTOS0200.opiskelijat.Add(henkilo8);

            tutk.opintojaksot.Add(TTKS0100);
            tutk.opintojaksot.Add(TTKS0700);
            tutk.opintojaksot.Add(TTOS0200);
        }
        public static void HaeEYOpintojaksot(Tutkinto tutk)
        {
            Opettaja henkilo1 = new Opettaja("Matti Karkki");
            Opettaja henkilo2 = new Opettaja("Antti Niskanen");
            Opettaja henkilo3 = new Opettaja("Jani Kananen");
            Opettaja henkilo4 = new Opettaja("Pirjo Valanen");
            Opiskelija henkilo5 = new Opiskelija("Mika Nurminen");
            Opiskelija henkilo6 = new Opiskelija("Niko Tepponen");
            Opiskelija henkilo7 = new Opiskelija("Emilia Rytkönen");
            Opiskelija henkilo8 = new Opiskelija("Jarmo Salojärvi");

            tutk.opintojaksot.Add(new Opintojakso("TERV2000", "Biorefineries and Pulp Processes", "en"));
            tutk.opintojaksot.Add(new Opintojakso("TERP0170", "Teollisuusprosessien energiatehokkuus", "fi"));
            tutk.opintojaksot.Add(new Opintojakso("TERP0900", "Höyrykattilatekniikka", "fi"));
        }
    }
    class Tutkinto
    {
        public List<Opintojakso> opintojaksot { get; set; }
        public string tutkinnonNimi { get; set; }
        public Tutkinto ()
        {
            opintojaksot = new List<Opintojakso>();
            
            //hae opintojaksot
        }
        public override string ToString()
        {
            string text = "";
            text += "\nTutkinto: "+tutkinnonNimi+"\n";
            text += "\nOpintojaksot: \n";
            foreach (Opintojakso opjakso in opintojaksot)
            {
                //text += " - koodi: " + opjakso.koodi + " opintojakson nimi: " + opjakso.nimi + "\n";
                text += opjakso.ToString();
            }
            text += "..................................";
            return text;
        }
    }
    class Opintojakso
    {
        public string koodi { get; set; }
        public List<Opettaja> opettajat { get; set; }
        public List<Opiskelija> opiskelijat { get; set; }
        public string opetuskieli { get; set; }
        public string nimi { get; set; }
        public Opintojakso (string koodi, string nimi, string opetuskieli)
        {
            this.koodi = koodi;
            this.nimi = nimi;
            this.opetuskieli = opetuskieli;
            opettajat = new List<Opettaja>();
            opiskelijat = new List<Opiskelija>();
        }
        public override string ToString()
        {
            string text = "";
            text += " - koodi: " + koodi + " opintojakson nimi: " + nimi + " opetuskieli: "+opetuskieli+"\n";
            return text;
        }
    }
    class Henkilo
    {
        string Name { get; set; }
        public Henkilo (string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Nimi: " + Name;
        }

    }
    class Opettaja : Henkilo
    {
        public Opettaja (string name) 
            : base (name) { }
    }
    class Opiskelija : Henkilo
    {
        string Id { get; set; }
        public Opiskelija(string name) 
            : base (name) { }
        public Opiskelija(string name, string id)
           : base(name)
        {
            Id = id;
        }
    }
}
