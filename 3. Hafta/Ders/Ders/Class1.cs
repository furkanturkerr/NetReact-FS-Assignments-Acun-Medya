using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    class Class1
    {
        private string name;



        public int id { get; set; }

        public string Name { 
            get { return name;  }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty!");
            }
        }

        public double UnitPrice { get; set; }
    }
}
