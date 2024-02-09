using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Dalmatian
    {
       
        public string Name { get; set; }
        public int Spots { get; set; }

        public Dalmatian() { }

        // Constructor to initialize name and spots


        public Dalmatian(string name, int spots)
        {
            Name = name;
            Spots = spots;
        }
    }
}

