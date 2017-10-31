using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class T2a
    {
        public static void Test()
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string file = path + @"\nimet.txt";
                string line;
                bool notFound = true;

                List<string> names = new List<string>();
                List<string> file_names = new List<string>();
                //Dictionary<string, int> listOfNames = new Dictionary<string, int>();
                if (File.Exists(file))
                {
                    string alltext = File.ReadAllText(file);
                    Console.WriteLine(alltext);

                    StreamReader sr = new StreamReader(file);
                    line = sr.ReadLine();
                    file_names.Add(line);
                    names.Add(line); // lisätty ensimmäinen nimi
                    Console.WriteLine(names[0]);
                    while ((line = sr.ReadLine()) != null) // luetaan seuraava rivi
                    {
                        file_names.Add(line);
                        notFound = true;
                        foreach (string name in names)

                        {

                            if (line == name)
                            {
                                notFound = false;
                                //continue;
                            }

                        }
                        if (notFound)
                        {
                            names.Add(line);
                            Console.WriteLine(line);
                        }


                    }
                    Console.WriteLine("Löytyi " + file_names.Count + " riviä, ja " + names.Count + " nimeä.");
                    foreach (string name in names)
                    {
                        int k = 0;
                        foreach (string f_name in file_names)
                        {
                            if (f_name == name) k++;
                        }
                        Console.WriteLine("Nimi " + name + " - " + k + " kertaa");
                    }



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
