using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Product
    {

        private double price;
        private string name;
        private int quantity;

        public Product() { }

        public Product(string name,double price, int quantity) 
        {
        
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name} : price : {price} quantity : {quantity}");
        }


    }
}
