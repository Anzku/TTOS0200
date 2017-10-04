using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04
{
    class Student
    {
        //PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioID { get; set; }
        //CONSTRUCTORS
        public Student() { }
        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
        public Student(string fname, string lname, string id)
        {
            FirstName = fname;
            LastName = lname;
            AsioID = id;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " asio: " + AsioID;
        }
        public static void Test()
        {
            Student s = new Student();
            s.FirstName = "Esa";
            s.LastName = "Salmikangas";
            Student s2 = new Student("Jaska", "Jokinen");
            // luodaan kokoelma student-olioita, käytetään List
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaltonen"));
            students.Add(new Student("Anzku", "Banzku", "K8993"));
            students.Add(new Student());
            //näytetään oppilaat
            Console.WriteLine("Luokan oppilaat: ");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
            //testataan Group-luokka
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Aurinko"));
            Console.WriteLine(luokka.ToString());
        }
        public class Group
        {
            public string Name { get; set; }
            public List<Student> Students;
            //CONSTRUCTOR
            public Group()
            {
                Students = new List<Student>();
                //luettaisiin esimerkiksi tietokannasta ne oppilaitten tiedot
                Students.Add(new Student("Pelle", "Peloton"));
                Students.Add(new Student("Aku", "Ankka"));
                Students.Add(new Student("Mikki", "Hiiri"));
            }
            public override string ToString()
            {
                string retval = "Luokka "+Name+" sisältä oppilaat\n";
                foreach (Student item in Students)
                {
                    retval += item.ToString();
                    retval += "\n";
                }
                return retval;
            }
        }
    }
    
}
