using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labra06
{
    class T3
    {
        public static void Test()
        {

            try
            {

                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filuInt = filupath + @"\IntNumbers.txt";
                string filuDob = filupath + @"\DobNumbers.txt";
                StreamWriter swInt = new StreamWriter(filuInt);
                StreamWriter swDob = new StreamWriter(filuDob);
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
                        swInt.WriteLine(number);
                    }
                    else
                    {
                        
                        Console.WriteLine("Attempted conversion of '{0}' failed.",
                                           number == null ? "<null>" : number);
                        Console.WriteLine("Lisätään tiedostoon DobNumbers");
                        swDob.WriteLine(number);
                    }

                    
                } while (number.Length != 0);

                swDob.Close();
                swInt.Close();
                Console.WriteLine("\nContents of " + filuInt);
                StreamReader sr = new StreamReader(filuInt);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\nContents of " + filuDob);
                sr = new StreamReader(filuDob);
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
