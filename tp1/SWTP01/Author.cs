using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTP01
{
    class Author{
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author(){
            Email = "void";
            Gender = '#';
        }
    }
}
