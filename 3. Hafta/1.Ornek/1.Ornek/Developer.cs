using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1.Ornek
{
    class Developer : Employee
    {
        public string About { get; set; }

        public Developer(int id, string name, double salary, string department, string about)
            : base(id, name, salary, department)
        {
            About = about;
        }
        public override double CalculateBonus()
        {
            return salary * 0.10;
        }

        public void DisplayDeveloperInfo()
        {
            Console.WriteLine($"ID: {id}, Ad: {name}, Maaş: {salary}, Departman: {Department}, Hakkında: {About}, Prim: {CalculateBonus()}");
        }
    }
}
