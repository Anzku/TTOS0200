using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class T5
    {
        public static void Tehtava()
        {
            Paper lot1 = new Paper("lot1", 52);
            lot1.SetStoragePlace("Paper container");
            Paper lot2 = new Paper("lot2", 13);
            lot2.Recycling();
            Plastic lot3 = new Plastic("lot3", 24);
            lot3.SetStoragePlace("Warehouse2");
            SoftPlastic lot4 = new SoftPlastic("lot4", 31);
            lot4.Recycling();
            Aluminum lot5 = new Aluminum("lot5", 68);
            Copper lot6 = new Copper("lot6", 95);




        }
    }
    abstract class Material
    {
        public abstract void Recycling();
        private string storagePlace = "not marked";
        protected double kg;
        protected string lot;
        public void SetStoragePlace(string place)
        {
            this.storagePlace = place;
            Console.WriteLine("Set storage place: " + place);
        }
        public string GetStoragePlace()
        {
            return this.storagePlace;
        }
        public Material(string lot, int kg)
        {
            this.lot = lot;
            this.kg = kg;
        }
    }
    class Plastic : Material
    {
        
        
        public Plastic(string lot, int kg)
            : base(lot, kg)
        {
            Console.WriteLine(this);
        }
        public override void Recycling()
        {
            Console.WriteLine(GetType().Name + " - " + this.lot + ", kg: " + this.kg + " was moved to general plastic recycling");
        }
        public override string ToString()
        {
            return GetType().Name + " - lot: " + this.lot + ", kg: " + this.kg + ", storage place: " + this.GetStoragePlace();
        }
    }
    class SoftPlastic : Plastic
    {

        public SoftPlastic(string lot, int kg)
            : base(lot, kg)
        {

            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return GetType().Name + " - lot: " + this.lot + ", kg: " + this.kg + ", storage place: " + this.GetStoragePlace();
        }
    }
    class HardPlastic : Plastic
    {
        public HardPlastic(string lot, int kg)
            : base(lot, kg)
        {

            Console.WriteLine(GetType().Name + " - lot: " + this.lot + ", kg: " + this.kg);
        }
        public override string ToString()
        {
            return GetType().Name + " - lot: " + this.lot + ", kg: " + this.kg + ", storage place: " + this.GetStoragePlace();
        }

    }
    class Metal : Material
    {

        public Metal(string lot, int kg)
            : base(lot, kg)
        {
            Console.WriteLine(this);
        }
        public override void Recycling()
        {
            Console.WriteLine(GetType().Name + " - " + this.lot + " was moved to general metal recycling container");
        }
        public override string ToString()
        {
            return GetType().Name + " - lot: " + this.lot + ", kg: " + this.kg + ", storage place: " + this.GetStoragePlace();
        }
    }

    class Aluminum : Metal
    {

        public Aluminum(string lot, int kg)
            : base(lot, kg)
        {

            Console.WriteLine(this);
            this.SetStoragePlace("Remelting of metal section.");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Iron : Metal
    {
        public Iron(string lot, int kg)
            : base(lot, kg)
        {
            Console.WriteLine(this);
        }

    }
    class Copper : Metal
    {
        public Copper(string lot, int kg)
            : base(lot, kg)
        {

            Console.WriteLine(this);
        }
        public override void Recycling()
        {
            Console.WriteLine(GetType().Name + " - " + this.lot + " was sold and moved to Copper Oy warehous");
        }
    }
    class Paper : Material
    {

        public Paper(string lot, int kg)
            : base(lot, kg)
        {
            Console.WriteLine(this);
        }
        public override void Recycling()
        {
            Console.WriteLine(GetType().Name + " - " + this.lot + " is moved to eneral paper recycling");
        }

        public override string ToString()
        {
            return GetType().Name + " - lot: " + this.lot + ", kg: " + this.kg + ", storage place: " + this.GetStoragePlace();
        }
    }
}
