using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Gauge
    {
       
            public int Value { get; set; }

            // Constructor to initialize value to 0
            public Gauge()
            {
                Value = 0;
            }

            // Method to increase the value by one, not beyond five
            public void Increase()
            {
                if (Value < 5)
                    Value++;
            }

            // Method to decrease the value by one, not below zero
            public void Decrease()
            {
                if (Value > 0)
                    Value--;
            }

            // Method to check if the value is full (i.e., equal to 5)
            public bool Full()
            {
                return Value == 5;
            }
        }
}
