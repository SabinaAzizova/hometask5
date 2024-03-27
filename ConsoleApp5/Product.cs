using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Product
    {
        
   public string name;
        public string description;
        public int count;
        public bool isstock;
        public double price;
        public Product(string name, int count, double price)
        {
            this.name = name;
            this.count = count;
            this.price = price;
        }



    }
}

