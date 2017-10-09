using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class T4
    {
        public static void Test()
        {
            List<Nisakas> persons = new List<Nisakas>();
            persons.Add(new Ihminen(11, 30, 130, "Peppi"));
            persons.Add(new Aikuinen(25, 68, 172, "Pekka","BMW"));
            persons.Add(new Vauva(0, 7, 62, "Sofia", "Libero"));
            Console.WriteLine("\nTestataan liikkuvuus:");
            foreach (Ihminen henkilo in persons)
            {
                henkilo.Liiku();
            }
        }
        
    }
    abstract class Nisakas
    {
        protected int ika;
        public Nisakas (int ika)
        {
            this.ika = ika;
        }
        public abstract void Liiku();
    }
    class Ihminen:Nisakas
    {
        protected int paino;
        protected int pituus;
        protected string nimi;
        public Ihminen (int ika, int paino, int pituus, string nimi)
            :base(ika) {
            this.paino = paino;
            this.pituus = pituus;
            this.nimi = nimi;
            Console.WriteLine("Uusi olio: " + this);
        }
        public override void Liiku ()
        {
            Console.WriteLine(nimi + " liikkuu");
        }
        public void Kasva()
        {
            this.ika++;
            Console.WriteLine(nimi + " on kasvanut vuodeksi, nyt hänen ikä on " + ika);
        }
        public override string ToString()
        {
            return GetType().Name+" - nimi: " + nimi + ", ikä: " + ika + ", paino: " + paino + ", pituus: " + pituus;
        }
    }
    class Vauva : Ihminen
    {
        private string vaippa;
        public Vauva(int ika, int paino, int pituus, string nimi, string vaippa)
            : base(ika, paino, pituus, nimi)
        {
            this.vaippa = vaippa;
            
        }
        public override void Liiku()
        {
            Console.WriteLine("Vauva "+ this.nimi + " konttaa");
        }
        public override string ToString()
        {
            return base.ToString()+", vaippa: " + this.vaippa;
        }
    }
    class Aikuinen:Ihminen
    {
        private string car;
        public Aikuinen(int ika, int paino, int pituus, string nimi, string auto)
            : base(ika,paino,pituus,nimi)
        {
            this.car = auto;
            
        }
        public override void Liiku()
        {
            Console.WriteLine("Aikuinen " + this.nimi + " kävelee");
        }
        public override string ToString()
        {
            string text = ", auto: " + this.car;
            return base.ToString() + text;
        }

    }
}
