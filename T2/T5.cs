using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace Labra05
{
    class T5
    {
        
        static Random rnd = new Random();
        public static void Test()
        {
            List<Person> listOfPersons = new List<Person>();
            listOfPersons = MakePersons(10000);
            FindPersons(1000, listOfPersons);

        }
        public static void FindPersons(int count, List<Person> list)
        {
            int found = 0;
            Console.WriteLine("\nFinding persons in collection(by firstname):");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i<count; i++)
            {
                string nimi = uusiNimi();
                foreach (Person henkilo in list)
                {
                    if (henkilo.Nimi == nimi)
                    {
                        Console.WriteLine("-Found person with " + nimi + " firstname: " + henkilo);
                        found++;
                    }
                }
                
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0}", ts.Milliseconds);
            Console.WriteLine("\n- Persons tried to find : " + count);
            Console.WriteLine("- Found : " + found);
            Console.WriteLine("- Total finding time : "+elapsedTime+" ms");

        }
        public static List<Person> MakePersons(int count)
        {
            List<Person> list = new List<Person>();
            Stopwatch stopWatch = new Stopwatch();
            
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
                string nimi = uusiNimi();
                //Console.WriteLine(nimi);
                string sukunimi = uusiSukunimi();
                list.Add(new Person(nimi, sukunimi));
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0}", ts.Milliseconds);
            Console.WriteLine("List Collection:");
            Console.WriteLine("- Adding time : "+elapsedTime+" ms");
            Console.WriteLine("- Persons count : " + count);
            Random rnd = new Random();
            int index = rnd.Next(0, count - 1);
            Console.WriteLine("- Random person : " + list[index]);
            return list;
        }
       

        public static string uusiNimi()
        {
            
            string text = "";
            char[] letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i<4; i++)
            {
                int num = rnd.Next(0,letter.Length);
                text += letter[num];
            }
            return text;
        }
        public static string uusiSukunimi()
        {
            
            string text = "";
            char[] letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(letter.Length);
                text += letter[num];
            }
            return text;
        }
    }
    class Person
    {
        public string Nimi { get; set; }
        string Sukunimi { get; set; }
        public Person(string nimi, string sukunimi)
        {
            Nimi = nimi;
            Sukunimi = sukunimi;
        }
        public override string ToString()
        {
            return Nimi + " " + Sukunimi;
        }
    }
}
