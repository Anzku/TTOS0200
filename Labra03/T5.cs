using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T5
    {
        public static void Tehtava()
        {
            Bike bike = new Bike("Jopo", "Street", 2016, "Blue", false, "");
            Bike bike2 = new Bike("Tunturi", "StreetPower", 2010, "Black", true, "Shimano");
            Boat boat = new Boat("Suvi", "S900", 1990, "White", 3, "Rowboat");
            Boat boat2 = new Boat("Yamaha", "Model 1000", 2010, "Yellow", 5, "Motorboat");
            Console.WriteLine("Bike " + bike);
            Console.WriteLine("Bike2 " + bike2);
            Console.WriteLine("Boat " + boat);
            Console.WriteLine("Boat2 " + boat2);               
        }
    }
    class Kulkuneuvo
    {
        private string name { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private string color { get; set; }
        public Kulkuneuvo (string name, string model, int year, string color )
        {
            this.name = name;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return "info\n- Name: "+name+", Model: "+model+", ModelYear: "+year+", Color: "+color;
        }
    }
    class Boat : Kulkuneuvo
    {
        private int seatCount { get; set; }
        private string type { get; set; }
        public Boat (string name, string model, int year, string color, int seatCount, string type) 
            : base (name,model,year,color)
        {
            this.seatCount = seatCount;
            this.type = type;
        }
        public override string ToString()
        {
            return base.ToString() + ", Seat count: " + seatCount + ", Type: " + type;
        }
    }
    class Bike : Kulkuneuvo
    {
        private bool gearWheels { get; set; }
        private string gearName { get; set; }
        public Bike (string name, string model, int year, string color, bool gearWheels, string gearName)
            : base (name,model,year,color)
        {
            this.gearName = gearName;
            this.gearWheels = gearWheels;
        }
        public override string ToString()
        {
            return base.ToString()+", Gear Wheels: "+gearWheels+", Gear Name: "+gearName;
        }
    }
}
