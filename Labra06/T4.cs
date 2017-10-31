using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labra06
{
    class T4
    {
        public static void Test()
        {
            List<TvOhjelma> lista = new List<TvOhjelma>();
            lista.Add(new TvOhjelma("Huutokauppakeisari", 4, "22:30", "23:45", "Katsojien rakastamassa Suomen huutokauppakeisarissa seurataan Aki ja Heli Palsanmäen huutokaupan vaiherikasta ja leppoisaa arkea Hirvaskankaalla. Tällä kaudella luvassa on mm. erikoisjakso Espanjan lämpimän auringon alta. Mukana häärää tietenkin myös käsistään näppärä Markku, joka tuunaa tavarat uuteen uskoon. Kotimainen sarja."));
            lista.Add(new TvOhjelma("Haluatko Miljonääriki?", 4, "21:00", "22:40", "Visailuohjelma, jossa kilpailijoilla on mahdollisuus voittaa suuria rahasummia vastaamalla oikein monivalintakysymyksiin. Ohjelman juontaa kotisohvien suosikki Jaajo Linnonmaa! Kotimainen visailuohjelma."));
            lista.Add(new TvOhjelma("Talent Suomi", 1, "20:00", "22:00", "Talent Suomi on huikea viihdeshow, jossa etsitään Suomen mielettömintä talenttia. Syksyn koukuttavimman show'n takaavat upeiden talenttien lisäksi tuomaristossa istuvat huippunimet Jari Sillanpää, Sami Hedberg ja Sara Forsberg! Ohjelman juontavat Heikki Paasonen ja Elina Kottonen. Kotimainen viihdeohjelma."));
            string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file = filupath + @"\TvOhjelmat.txt";
            try
            {
                StreamWriter sw = new StreamWriter(file);
                foreach (TvOhjelma ohjelma in lista)
                {
                    sw.WriteLine(ohjelma.ToString());
                }
                sw.Close();
                StreamReader sr = new StreamReader(file);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
    class TvOhjelma
    {
        string Nimi { get; set; }
        int Kanava { get; set; }
        string Alkaa { get; set; }
        string Loppuu { get; set; }
        string Info { get; set; }
        public TvOhjelma(string nimi, int kanava, string alkaa, string loppuu, string info)
        {
            Nimi = nimi;
            Kanava = kanava;
            Alkaa = alkaa;
            Loppuu = loppuu;
            Info = info;
        }
        public override string ToString()
        {
            return "\nTv ohjelman nimi: " + Nimi + ", kanavan numero: " + Kanava + ", alkaa: " + Alkaa + ", loppuu: " + Loppuu + ", info: " + Info;
        }
    }
}
