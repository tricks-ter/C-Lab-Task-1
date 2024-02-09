using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Room
    {

        private string code;
        private int seats;

        public Room(string code, int seats)
        {
            this.code = code;
            this.seats = seats;
        }
    }
}
