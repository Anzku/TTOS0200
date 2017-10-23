using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace Labra05
{
    class T5Dictionary
    {
        
        static Random rnd = new Random();
        public static void Test()
        {
            Dictionary<string, string> listOfPersons = new Dictionary<string, string>();
            listOfPersons = MakePersons(10000);
            FindPersons(1000, listOfPersons);

        }
        public static void FindPersons(int count, Dictionary<string, string> list)
        {
            int found = 0;
            Console.WriteLine("\nFinding persons in collection(by firstname):");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i<count; i++)
            {
                string nimi = uusiNimi();
                foreach (KeyValuePair<string,string> henkilo in list)
                {
                    if (henkilo.Key == nimi)
                    {
                        Console.WriteLine("-Found person with " + nimi + " firstname: " + nimi + " " + henkilo.Value);
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
        public static Dictionary<string,string> MakePersons(int count)
        {
            Dictionary<string,string> list = new Dictionary<string, string>();
            string nimi = uusiNimi();
            string sukunimi = uusiSukunimi();
            list.Add(nimi, sukunimi);
            //Console.WriteLine(nimi + " " + sukunimi);
            Stopwatch stopWatch = new Stopwatch();
            
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
                bool notAdded;
                do {
                    notAdded = false;
                    nimi = uusiNimi();
                    //Console.WriteLine("Uusi nimi: " + nimi);
                    foreach (KeyValuePair<string,string> kvp in list)
                    {
                        if (nimi == kvp.Key)
                        {
                            notAdded = true;
                            //Console.WriteLine("kvp.Key = " + kvp.Key);
                        }
                    }
                } while (notAdded); 
                
                sukunimi = uusiSukunimi();
                list.Add(nimi, sukunimi);
                //Console.WriteLine(nimi + " " + sukunimi);
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0}", ts.Milliseconds);
            Console.WriteLine("Dictionary Collection:");
            Console.WriteLine("- Adding time : "+elapsedTime+" ms");
            
            
            Console.WriteLine("- Persons count : " + count);
            bool notFound;
            string rndName;
            do
            {
                rndName = uusiNimi();
                notFound = true;
                foreach (KeyValuePair<string,string> kvp in list)
                {
                    if (kvp.Key == rndName)
                    {
                        notFound = false;
                    }
                }
            } while (notFound);
            Console.WriteLine("- Random person : " + rndName + " " + list[rndName]);
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
    
}
