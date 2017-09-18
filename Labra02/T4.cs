using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra02
{
    class T4
    {
        public static void Tehtava()
        {
            Console.WriteLine("Tehtävä: toteuta Vehicle-luokan ohjelmointi");
            Console.Write("Vehicle name > ");
            string name = Console.ReadLine();
            Console.Write("Tyres > ");
            int tyres = Convert.ToInt32(Console.ReadLine());
            Vehicle vehicle = new Vehicle(name, tyres);
            Menu(vehicle);
            
           
        }
        public static void Menu(Vehicle vehicle)
        {
            string valinta = "";
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. vaihda nimi");
                Console.WriteLine("2. vaihda nopeus");
                Console.WriteLine("3. tyres");
                
                Console.Write("Sinun valinta > ");
                valinta = Console.ReadLine();
                switch (valinta)
                {
                    case "1":
                        Console.Write("Anna uusi nimi >");
                        string nimi = Console.ReadLine();
                        vehicle.name = nimi;
                        Console.WriteLine("Uudet tiedot: ");
                        vehicle.PrintData();

                        break;
                    case "2":
                        vehicle.Speed();
                        

                        break;
                    case "3":
                        Console.Write("Anna uusi arvo > ");
                        int tyres = Convert.ToInt32(Console.ReadLine());
                        vehicle.tyres = tyres;
                        Console.WriteLine(vehicle);
                        
                        

                        break;
                    

                    default:
                        Menu(vehicle);
                        break;

                }
            } while (valinta != "5");

        }
    }
    class Vehicle
    {
        public string name;
        public int tyres; 
        int speed;
        public Vehicle(string name, int tyres)
        {
            this.name = name;
            this.tyres = tyres;
            this.speed = 0;
            PrintData();

        }
        public void PrintData()
        {
            Console.WriteLine("Vehicle name: {0}.", this.name);
            Console.WriteLine("Vehicle speed: {0} km/h",this.speed);
            Console.WriteLine("Tyres: {0}", this.tyres);
        }
        public override string ToString()
        {
            return "Vehicle name: " + this.name + ". Vehicle speed: " + this.speed + " km/h. Tyres: " + this.tyres;           
        }
        public void Speed()
        {
            Console.WriteLine("Paina gaasua (Enter) tai stop (s)");
            string valinta = "";
            do
            {
                Console.WriteLine("Speed: " + this.speed + " km/h");
                this.speed++;
                valinta = Console.ReadLine();
                
            } while (valinta != "s");
            this.speed--;
            PrintData();
        }
        

    }
}
