using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra03
{
    class T4
    {
        public static void Tehtava()
        {
            Employee person1 = new Employee();
            person1.Name = "Kirsi Kernel";
            person1.Profession = "Teacher";
            person1.Salary = 1200;
            Console.WriteLine(person1);
            Boss person2 = new Boss("Jussi Jurkka", "Head of Institute",9000,"Audi",5000);
            Console.WriteLine(person2);
            person1.Profession = "Principal Teacher";
            person1.Salary = 2200;
            Console.WriteLine(person1);
        }
    }
    class Employee
    {
        private string name { get; set; }
        private string profession { get; set; }
        private int salary { get; set; }

        public Employee(string name, string profession, int salary)
        {
            this.name = name;
            this.profession = profession;
            this.salary = salary;
        }
        public Employee()
        {

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public override string ToString()
        {
           
            return "\n"+this.GetType().Name+":\n- Name: "+name+", Profession: "+profession+", Salary: "+salary;
        }
         
    }
    class Boss : Employee
    {
        private string car { get; set; }
        private int bonus { get; set; }

        public Boss(string name, string profession, int salary, string car, int bonus)

            : base(name, profession, salary)
        {
            this.car = car;
            this.bonus = bonus;
        }
        public override string ToString()
        {
            return base.ToString() + ", Car: "+car+", Bonus: "+bonus;
        }


    }
    
}
