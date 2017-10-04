using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class kapselointi
    {
        public static void T()
        {
            Thing t = new Thing();
            //t.Name = "jotakin";
            Console.WriteLine(t.Name);
            Console.WriteLine(t);
        }
    }
    public class Thing
    {

        public string Name; // "jotakin" // julkinen jäsenmuuttuja != ominaisuus
        //public string Name { get; set; } // "jotakin" // parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
        private string name;

        
       
        //CONSTRUCTOR
        public Thing()
        {
            Name = "nobody here";
        }
        public override string ToString()
        {
            return "nimeni on: " + Name;
        }

    }
}
