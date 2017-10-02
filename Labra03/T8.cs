using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T8
    {
        public static void Tehtava()
        {
            Book staff1 = new Book("Phylosophy", 352);
            staff1.SetStoragePlace("Book shelf");
            Newspaper staff2 = new Newspaper("Keskisuomalainen", 2011);
            staff2.Recycling();
            BluRay staff3 = new BluRay("Game of thrones");

            staff3.SetStoragePlace("Disk shelf");
            Console.WriteLine(staff3);
            CD staff4 = new CD("Empty CD");
            staff4.Recycling();
            Phone staff5 = new Phone("iPhone7");
            Console.WriteLine(staff5);
            staff5.Recycling();
            Tablet staff6 = new Tablet("Lenovo");
            staff6.Broken();
            Console.WriteLine(staff6);
            staff6.Recycling();
            Notebook staff7 = new Notebook("ASUS");
            Console.WriteLine(staff7);
            staff7.SetStoragePlace("Bookshelf");


        }
    }
    abstract class StudentsStaff
    {
        public abstract void Recycling();
        private string storagePlace = "not marked";
        public void SetStoragePlace(string place)
        {
            this.storagePlace = place;
            Console.WriteLine("Set storage place: " + place);
        }
        public string GetStoragePlace()
        {
            return this.storagePlace;
        }
    }
    class Printing : StudentsStaff
    {
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public Printing(string name)
        {
            this.name = name;
        }
        public override void Recycling()
        {
            Console.WriteLine(GetType().Name + " - " + this.name + " was moved to paper recycling");
        }
        public override string ToString()
        {
            return GetType().Name + " - name: " + this.name + ", storage place: " + this.GetStoragePlace();
        }
    }
    class Book : Printing
    {
        private int pages;
        public Book(string name, int pages)
            : base(name)
        {
            this.pages = pages;
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return GetType().Name + " - name: " + this.Name + ", pages: " + this.pages + ", storage place: " + this.GetStoragePlace();
        }
    }
    class Newspaper : Printing
    {
        private int year;
        public Newspaper(string name, int year)
            : base(name)
        {
            this.year = year;
            Console.WriteLine(GetType().Name + " - name: " + this.Name + ", year: " + this.year);
        }
        public override string ToString()
        {
            return GetType().Name + " - name: " + this.Name + ", year: " + this.year;
        }

    }
    class Disk : StudentsStaff
    {
        private string name;
        public Disk(string name)
        {
            this.name = name;
        }
        public override void Recycling()
        {
            Console.WriteLine(GetType().Name + " - " + this.name + " was moved to general recycling container");
        }
        public override string ToString()
        {
            return GetType().Name + " - name: " + this.name + ", storage place: " + this.GetStoragePlace();
        }
    }

    class BluRay : Disk
    {

        public BluRay(string name)
            : base(name)
        {

            Console.WriteLine(this);
            this.SetStoragePlace("BluRay disk shelf");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class CD : Disk
    {
        public CD(string name)
            : base(name)
        {
            Console.WriteLine(this);
        }

    }
    class DVD : Disk
    {
        public DVD(string name)
            : base(name)
        {
            this.SetStoragePlace("TV-taso");
            Console.WriteLine(this);
        }
    }
    class ElectronicDevice : StudentsStaff
    {
        protected string model;
        private bool working = true;
        public ElectronicDevice(string model)
        {
            this.model = model;
        }
        public override void Recycling()
        {
            if (this.working) Console.WriteLine(GetType().Name + " - " + this.model + " is working good, so it shold be sold on Tori.fi");
            else Console.WriteLine(GetType().Name + " - " + this.model + " is moved to electronic device recycling, because it's not working.");
        }
        public void Broken()
        {
            this.working = false;
        }
        public override string ToString()
        {
            return GetType().Name + " - model: " + this.model + ", storage place: " + this.GetStoragePlace() + ", working: " + this.working;
        }
    }
    class Phone : ElectronicDevice
    {
        public Phone(string model)
            : base(model)
        {

        }

    }
    class Tablet : ElectronicDevice
    {
        public Tablet(string model)
            : base(model)
        {

        }

    }
    class Notebook : ElectronicDevice
    {
        public Notebook(string model)
            : base(model)
        {

        }

    }
}
