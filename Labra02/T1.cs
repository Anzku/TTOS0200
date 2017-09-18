using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T1
    {
        public static void Tehtava()

        {
            Console.WriteLine("Tehtävä: ohjelmoida kiukaan toiminta");
            Kiuas kiuas = Start();
            Aseta_lampotila(kiuas);
            Console.Write("Aseta kosteus > ");
            kiuas.Kosteus = Convert.ToInt32(Console.ReadLine());
            string vastaus;
            do
            {
                Console.Write("Haluatko laittaa pois päältä? (y/n)");
                vastaus = Console.ReadLine();
                if (vastaus == "y")
                {
                    kiuas.on_paalla = false;
                    Console.Write("Kiuas on pois päältä");

                }
                else Aseta_lampotila(kiuas);
            } while (vastaus != "y");
            

            

        }
         
        public static Kiuas Start()
        {
            Console.Write("Aseta ilma lämpötila > ");
            int ilma_lampotila = Convert.ToInt32(Console.ReadLine());
            Kiuas kiuas;
            
            string vastaus;
            do
            {
                Console.WriteLine("Kiuas on pois päältä. Haluatko laittaa sen päälle? (y/n)");
                vastaus = Console.ReadLine();
                if (vastaus == "n")
                {
                    Console.WriteLine("Hyvästi!");
                    Console.ReadLine();
                    System.Environment.Exit(1);

                } 
                
            } while (vastaus != "y");

            kiuas = new Kiuas(ilma_lampotila);
            
            return kiuas;

        }
        
        static Kiuas Aseta_lampotila(Kiuas kiuas)
        {
            Console.Write("Aseta haluamasi lämpötilä > ");
            int lampo = Convert.ToInt32(Console.ReadLine());
            if (kiuas.Lampotila < lampo) kiuas.Lampenee(lampo);
            if (kiuas.Lampotila > lampo) kiuas.Viilentaa(lampo);
                
            
            return kiuas;
        }
    }
    public class Kiuas
    {
        public int Lampotila { get; set; }
        public int Kosteus { get; set; }
        public bool on_paalla { get; set; }
        public Kiuas ()
        {
            this.on_paalla = true;
        }
        public Kiuas (int ilma_lampotila) :base()
        {
            this.Lampotila = ilma_lampotila;
            Console.WriteLine("Nyt kiuas on päällä, sen lämpötila on sama, kuin ilman lämpötila: {0} astetta", ilma_lampotila);
        }
        // Methods
        
        public void Lampenee(int lampo)
        {
            do
            {
                this.Lampotila += 1;
                Console.WriteLine("Kiuan lämpötila nousee ({0})", (this.Lampotila));

            } while (this.Lampotila < lampo);
            Console.WriteLine("Kiuan lämpötila on ({0})", (this.Lampotila));


        }
        public void Viilentaa(int lampo)
        {
            do
            {
                this.Lampotila -= 1;
                Console.WriteLine("Kiuan lämpötila laskee ({0})", (this.Lampotila));

            } while (this.Lampotila > lampo);
            Console.WriteLine("Kiuan lämpötila on ({0})", (this.Lampotila));
        }
        
    }
}
