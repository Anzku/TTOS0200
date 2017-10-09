using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class T1
    {
        public static void Test()
        {
            Kulkuneuvo car1 = new Kulkuneuvo("Porsche", "911", 4);
            for (int i = 0; i<4; i++)
            {
                car1.TyreAdd("Nokia", "Hakkapeliitta", "205R16");
            }
            
            Console.WriteLine(car1.ToString());
            Kulkuneuvo motorbike = new Kulkuneuvo("Ducati", "Diavel", 2);
            motorbike.TyreAdd("MIC", "Pilot", "160R17");
            motorbike.TyreAdd("MIC", "Pilot", "140R16");
            Console.WriteLine(motorbike.ToString());

        }
    }
    class Rengas
    {
        public string merkki { get; set; }
        public string tyyppi { get; set; }
        public string rengaskoko { get; set; }
        public Rengas (string merkki, string tyyppi, string koko)
        {
            this.merkki = merkki;
            this.tyyppi = tyyppi;
            rengaskoko = koko;
        }
    }
    class Kulkuneuvo
    {
        private string nimi;
        private string malli;
        private int pyorienlukumaara;
        //private Rengas[] renkaat = new Rengas[4];
        List<Rengas> tyres = new List<Rengas>();

        public Kulkuneuvo (string nimi, string malli, int lkm)
        {
            this.nimi = nimi;
            this.malli = malli;
            pyorienlukumaara = lkm;
            
            Console.WriteLine("Created a new vehichle " + nimi + " model" +malli + ", number of wheels: "+pyorienlukumaara);
        }
        public void TyreAdd (string merkki, string tyyppi, string koko) 
        {
            Rengas tyre = new Rengas(merkki, tyyppi, koko);
            tyres.Add(tyre);
            
            Console.WriteLine("Tyre " + merkki + " added to vehicle " + malli);
            
            
        }
        public override string ToString()
        {
            string print = "";
            print += "Vechicle Name: " + nimi + " Model:" + malli;
            print += "\nTyres:\n";
            foreach (Rengas tyre in tyres)
            {
                print += "-Merkki: " + tyre.merkki + " Tyypi:" + tyre.tyyppi + " TyreSize:" + tyre.rengaskoko +"\n";
            }

               
            print += "\n";
            return print;
        }
    }
}
