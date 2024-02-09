using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Whistle
    {
        private string sound;

        public Whistle() { }

        public Whistle(string s) 
        { 
        
            this.sound = s;

        }

        public void Sound()
        {
            Console.WriteLine(sound);
        }

    }
}
