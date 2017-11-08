using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra07
{
    class T4
    {
        public static void Test()
        {
            List<Shape> newlist = new List<Shape>();
            newlist.Add(new Circle("Small Circle", 1));
            newlist.Add(new Circle("Big Circle", 15));
            newlist.Add(new Circle("The Last Circle", 7));
            newlist.Add(new Rectangle("First Rectangle", 10.5F, 5));
            newlist.Add(new Rectangle("Second Rectangle", 3, 7));
            newlist.Add(new Rectangle("The Biggest Rectangle", 150, 400));
            Console.WriteLine(new Shapes(newlist).ToString());


        }
    }
    abstract class Shape
    {
        string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract float Area();
        public abstract float Circumference();
    }
    class Circle : Shape
    {
        int Radius { get; set; }
        string Name;
        public Circle(string name, int radius) : base (name)
        {
            Radius = radius;
        }
        public override float Area()
        {
            return 3.14F * Radius * Radius;
        }
        public override float Circumference()
        {
            return 3.14F * 2 * Radius;
        }
        public override string ToString()
        {
            return Name + " Radius=" + Radius + " Area=" + Area() + " Circumference=" + Circumference() + "\n";
        }
    }
    class Rectangle : Shape
    {
        float Width { get; set; }
        float Height { get; set; }
        string Name;
         
        public Rectangle(string name, float w, float h) : base(name)
        {
            Width = w;
            Height = h;
        }
        public override float Area()
        {
            return Width*Height;
        }
        public override float Circumference()
        {
            return 2*Width*Height;
        }
        public override string ToString()
        {
            return Name + " Width=" + Width + " Height=" +Height+" Area="+ Area() + " Circumference=" + Circumference() + "\n";
        }
    }
    class Shapes
    {
        public string Name { get; set; }
        List<Shape> forms = new List<Shape>();
        public Shapes(List<Shape> f)
        {
            forms = f;
        }
        public override string ToString()
        {
            string text = "";
            foreach (Shape shape in forms)
            {
                text += shape.ToString();
            }
            return text;
        }
       
    }
}
