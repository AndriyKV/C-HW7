using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    abstract class Shape : IComparable<Shape>
    {
        public int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print()
        {
            Console.WriteLine("Name = {0}", name);
        }
    }
}
