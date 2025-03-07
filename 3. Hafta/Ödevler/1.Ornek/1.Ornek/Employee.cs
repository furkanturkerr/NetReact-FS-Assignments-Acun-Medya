using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1.Ornek
{
    class Employee
    {
        private int id1;
        private double salary1;

        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, double salary, string departent)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.Department = departent;
        }

        public virtual double CalculateBonus()
        {
            return 50000; 
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}, Ad: {name}, Maaş: {salary}, Departman: {Department}, Prim: {CalculateBonus()}");
        }
    }
}
