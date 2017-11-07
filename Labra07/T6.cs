using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra07
{
    class T6
    {
        public static void Test()
        {
            List<Item> ostokset = new List<Item>();
            ostokset.Add(new Item("Milk", 1.75, 1));
            ostokset.Add(new Item("Beer", 5.25, 1));
            ostokset.Add(new Item("Butter", 2.5, 2));
            ostokset.Add(new Item("Bread", 1.25, 3));
            Invoice invoice1 = new Invoice("Kirsi Kapustamäki", ostokset);
            Console.WriteLine(invoice1);
        }
    }
    class Item
    {
        string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
        public double Total { get; set; }
        public Item(string n, double p, int q) {
            Name = n;
            Price = p;
            Quantity = q;
            Total = p*q;
        }
        public override string ToString()
        {
            return Name+"\t"+Price+" eur\t"+Quantity+" pieces\t"+Total+" eur\n";
        }


    }
    class Invoice
    {
        List<Item> Ostoslista { get; set; }
        double Total { get; set; }
        string Name { get; set; }
        public Invoice(string name, List<Item> ostoslista)
        {
            Name = name;
            Ostoslista = ostoslista;
            Total = CalcTotal();
        }

        private double CalcTotal()
        {
            
            double result = 0;
            foreach (Item list in Ostoslista)
            {
                result += list.Total;
                
            }
            return result;
        }
        
        public override string ToString()
        {
            string text = "";
            text += "Customer " + Name + "'s invoice:\n";
            text += "==========================================\n";
            foreach (Item list in Ostoslista)
            {
                text += list.ToString();
            }
            text += "==========================================\n";
            text += "Total: " + Total + " euros";
            return text;
        }
    }
}
