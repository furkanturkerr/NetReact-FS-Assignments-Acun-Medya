﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class ProgrammingLanguage: BaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ProgrammingLanguage()
        {

        }


        public ProgrammingLanguage(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
