using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Labra06
{
    class T2
    {
        public static void Test()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = path + @"\test.txt";
            StreamReader sr = new StreamReader(filename);
            if (File.Exists(filename))
            {
                string nimi = File.ReadLines(;
            }
        }
    }
}
