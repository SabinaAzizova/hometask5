using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Student : Person
        {
  private string name; // field

  public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }
    
        public byte StudentId;
        public double Point;
        public Student(string name, string surname, byte age, byte StudentId, double Point) : base(name, surname, age)
        {
            StudentId = StudentId;
            Point = Point;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }  
    }
}
