using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class DecreasingCounter
    {

        private int value; // a variable that remembers the value of the counter
        
        public DecreasingCounter() { }
        
        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }
        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }
        public void decrement()
        {
            if (this.value > 0)
            {
                this.value--;
                PrintValue();
            }
            else
            {
                Console.WriteLine("Value should be greater then 0");
            }
            
        }
        public void Reset()
        {
            value = 0;
            PrintValue();
        }
        
    }
}

    

