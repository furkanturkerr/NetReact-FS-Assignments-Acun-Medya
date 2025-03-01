using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders
{
    class Category
    {
        public int Id { get; set; }
        public int Name { get; set; }

        //yapıcı metod

        public Category()
        {
            Console.WriteLine("Yapcı blok çalıştı.");
            Name = string.Empty!;
            Id++;
        }

        public Category(string name)
        {
            Name = name;
        }
    }
}
