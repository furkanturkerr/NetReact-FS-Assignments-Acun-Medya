using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1.Ornek
{
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(int id, string name, double salary, string department, int teamSize) : base(id, name, salary, department)
        {
            TeamSize = teamSize;
        }

        public override double CalculateBonus()
        {
            return salary * 0.20;
        }

        public void DisplayManagerInfo()
        {
            Console.WriteLine($"ID: {id}, Ad: {name}, Maaş: {salary}, Departman: {Department}, Takım Büyüklüğü: {TeamSize}, Prim: {CalculateBonus()}");
        }
    }
}
