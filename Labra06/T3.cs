using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class T3
    {
        public static void Test()
        {
            // 
            //try
            //{
                
                //string filupath = @"D:\K8993";
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filuInt = filupath + @"\IntNumbers.txt";
                string filuDob = filupath + @"\DobNumbers.txt";
                string number;
                do
                {
                    Console.Write("Give a number(enter or not a number ends) : ");
                    int i;
                    number = Console.ReadLine();
                
                bool result = Int32.TryParse(number, out i);
                if (result)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", i, number);
                    Console.WriteLine("Lisätään tiedostoon IntNumbers");
                }
                else
                {
                    //            if (value == null) value = ""; 
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       number == null ? "<null>" : number);
                    Console.WriteLine("Lisätään tiedostoon DobNumbers");
                }

                //sw.WriteLine(nimi);
            } while (number.Length != 0);
                // kirjoitetaan käyttäjän antamat rivit tiedostoon
                // luodaan StreamWriter tyyppinen olio, johon kirjoitetaan
               /* StreamWriter sw = new StreamWriter(filu);

                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine("\nTeksti tiedosta: " + filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }*/
        }
    }
}
