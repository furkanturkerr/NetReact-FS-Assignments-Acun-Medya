using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Technology : BaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  ProgrammingLanguage ProgrammingLanguage { get; set; }

        public Technology(int ıd, string name, ProgrammingLanguage programmingLanguage)
        {
            Id = ıd;
            Name = name;
            ProgrammingLanguage = programmingLanguage;
        }
    }
}
