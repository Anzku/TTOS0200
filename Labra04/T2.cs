using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class T2
    {
        public static void Test()
        {
            List<Jaakaappi> ruokatuote = new List<Jaakaappi>();
            ruokatuote.Add(new maitotuote("maito", "12.10.2017"));
            ruokatuote.Add(new maitotuote("rahka", "11.08.2017"));
            ruokatuote.Add(new vihannekset("kurkku", "28.10.2017"));
            ruokatuote.Add(new vihannekset("porkkana", "30.11.2017"));
            ruokatuote.Add(new liha("jauheliha", "9.10.2017"));
            ruokatuote.Add(new liha("naudanliha", "13.10.2017"));
            Console.WriteLine("Jääkaapissa löytyy seuravat tuoteet:");
            foreach (Jaakaappi tuote in ruokatuote)
            {
                Console.WriteLine(tuote);
            }
            Console.WriteLine("\nYritetään kokata ruokaa:");
            foreach (Jaakaappi tuote in ruokatuote)
            {
                
                Console.WriteLine(tuote);
                tuote.Valmistaminen();
            }
        }
        abstract class Jaakaappi
        {
            string parastaennen;
            protected bool raaka = true;
            public Jaakaappi (string parastaennen)
            {
                this.parastaennen = parastaennen;
            }
            public void Valmistaminen()
            {
                if (raaka) {
                    Console.WriteLine("Let's produce heat treatment of the product");
                    raaka = false;
                }
                else
                {
                    Console.WriteLine("The product is ready for use");
                }
            }
            public override string ToString()
            {
                string onkoraaka = "";
                if (raaka) onkoraaka = ", on raaka, ";
                else onkoraaka = ", on käyttövalmis, ";
                return onkoraaka + "parastaennen: " + parastaennen;
            }


        }
        class maitotuote : Jaakaappi
        {
            private string tyypi { get; set; }
            
            public maitotuote (string tyypi, string parastaennen)
                :base (parastaennen)
            {
                this.tyypi = tyypi;
                raaka = false;
            }
            public override string ToString()
            {
                return "Maitotuote - tyypi: "+ tyypi + base.ToString();
            }

        }
        class vihannekset: Jaakaappi
        {
            private string nimi { get; set; }
            public vihannekset (string nimi, string parastaennen) 
                :base (parastaennen)
            {
                this.nimi = nimi;
                raaka = false;
            }
            public override string ToString()
            {
                return "Vihannekset - nimi: " + nimi + base.ToString();
            }
        }
        class liha : Jaakaappi
        {
            private string nimi { get; set; }
            public liha(string nimi, string parastaennen)
                : base(parastaennen)
            {
                this.nimi = nimi;
            }
            public override string ToString()
            {
                return "Liha - nimi: " + nimi + base.ToString();
            }
        }
    }
}
