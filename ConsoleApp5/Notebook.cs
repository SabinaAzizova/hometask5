using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Notebook:Product
    {
        
    public byte ram;
        public int storage;
        public NoteBook(string name, int count, double price, byte ram) : base(name, count, price)
        {

            this.ram = ram;
        }
        public NoteBook(string name, int count, double price, byte ram, int storage) : base(name, count, price)
        {
            this.ram = ram;
            this.storage = storage;
        }


        public void Sale()
        {
            if (count > 0)
            {
                count--;
                Console.WriteLine($"name:{name},count:{count},price:{price},byte:{ram}");
            }
            else
            {
                Console.WriteLine("stokda mehsul yoxdur");
            }
        }
        public void Showfulldata()
        {
            if (count > 0)
            {
                count--;
                Console.WriteLine($"name:{name}, description:{description},count:{count},price:{price},byte:{ram},storage:{storage}");
            }
            else
            {
                Console.WriteLine("stokda mehsul yoxdur");
            }
        }
    }
}
