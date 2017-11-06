using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra07
{
    class T3
    {
        public static void Test()
        {
            Fisherman henkilo1 = new Fisherman("Kirsi Kernel", "020-12345678");
            henkilo1.GotFish(new Fish("pike", 35, 2.9F, new Location("The Lake of Jyväskylä", "Jyväskylä")));
            henkilo1.GotFish(new Fish("salmon", 50, 5.0F, new Location("River Teno", "The Northern edge of Finland")));
            henkilo1.GotFish(new Fish("pike", 40, 3.5F,new Location("The Lake of Jyväskylä", "Jyväskylä")));
            henkilo1.GotFish(new Fish("salmon", 56, 5.2F, new Location("River Teno", "The Northern edge of Finland")));
            
            Console.WriteLine("\nAll fishes in register:");
            Console.WriteLine("\nFisherman {0} has got following fishes:", henkilo1.Nimi);
            henkilo1.PrintList();
            Console.WriteLine("\nAll fishes in sorted register (from the biggest):");
            henkilo1.SortedList();
            Console.WriteLine("\nAll fishes in sorted register (from the smallest):");
            henkilo1.SortedList2();
        }
    }
    class Fisherman
    {
        public string Nimi { get; set; }
        string Phone { get; set; }
        List<Fish> Fishes = new List<Fish>();
        public Fisherman (string nimi, string phone)
        {
            Nimi = nimi;
            Phone = phone;
            Console.WriteLine("A new fisherman added to register:");
            Console.WriteLine(" - Fisherman: " + Nimi + " Phone: " + Phone);
        }
        public void GotFish(Fish fish)
        {
            Fishes.Add(fish);
            Console.WriteLine("\nFisher : {0} got a new fish\n{1}", Nimi,fish.ToString());
        }
        public void SortedList()
        {
            Fish apu;
            int j = Fishes.Count-1;
            while (j > 0)
            {
                 for (int i = 0; i < j; i++)
                 {
                    if (Fishes[i].Weight < Fishes[j].Weight) {
                         apu = Fishes[i];
                         Fishes[i] = Fishes[j];
                         Fishes[j] = apu;
                     }
                  }
                  j--;
            }
            PrintList();
        }
        public void SortedList2() // from smallest to biggest
        {
            Fishes.Sort((x, y) => x.Weight.CompareTo(y.Weight));
            PrintList();
        }
        public void PrintList ()
        {
            foreach (Fish fish in Fishes) Console.WriteLine(fish);
        }

    }
    class Fish
    {
        string Specie { get; set; }
        int Pituus { get; set; }
        public float Weight { get; set; }
        Location Place { get; set; }
        
        public Fish (string specie, int pituus, float weight, Location place)
        {
            Specie = specie;
            Pituus = pituus;
            Weight = weight;
            Place = place;

        }
        public override string ToString()
        {
            return "\n - specie : "+Specie+" "+Pituus+" cm "+Weight+" kg\n"+Place;
        }
    }
    class Location
    {
        string Name { get; set; }
        string Place { get; set; }
        public Location (string name, string place)
        {
            Name = name;
            Place = place;
        }
        public override string ToString()
        {
            return " - place: "+Name+"\n - location: "+Place;
        }
    }
   
}
