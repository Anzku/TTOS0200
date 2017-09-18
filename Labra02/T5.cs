using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T5
    {
        public static void Tehtava()
        {
            string[] nimet = new string[5] { "Anna", "Emma", "Niko", "Mika", "Satu" };
            int[] vuodet = new int[5] { 1987, 1991, 1990, 1992, 1993};
            Opiskelja[] opiskelja = new Opiskelja[5];
            for (int i=0;i<5;i++)
            {
                Console.WriteLine("Opiskelja #" + (i + 1));
                Console.WriteLine("Nimi: " + nimet[i]);
                Console.WriteLine("Syntymävuosi: " + vuodet[i]);
                
                opiskelja[i] = new Opiskelja(nimet[i], vuodet[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                
                opiskelja[i].PrintData();
            }
        }
    }
    class Opiskelja
    {
        public string nimi;
        public int syntymavuosi;
        public string ryhma = "";

        string id = "";
        public Opiskelja (string nimi, int syntymavuosi)
        {
            this.nimi = nimi;
            this.syntymavuosi = syntymavuosi;
            Aseta_id();
            Aseta_ryhma();
        }
        public void PrintData()
        {
            Console.WriteLine("Opiskeljan nimi: " + nimi);
            Console.WriteLine("Syntymävuosi: " + syntymavuosi);
            Console.WriteLine("Ryhmä: " + ryhma);
            Console.WriteLine("ID: " + id);
            Console.WriteLine();

        }
        void Aseta_id()
        {
            Console.Write("Anna id: ");
            
            this.id = Console.ReadLine();
        }
        void Aseta_ryhma()
        {
            Console.Write("Ryhmä: ");

            this.ryhma = Console.ReadLine();
        }
    }
}
