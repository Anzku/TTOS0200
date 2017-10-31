using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class T1
    {
        public static void Test()
        {
            // 
            
                string nimi;
                //string filupath = @"D:\K8993";
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\test.txt";
                // kirjoitetaan käyttäjän antamat rivit tiedostoon
                // luodaan StreamWriter tyyppinen olio, johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa):");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine("\nTeksti tiedosta: " + filu);
                    Console.WriteLine(teksti); 
                }
            
        }
    }
}
