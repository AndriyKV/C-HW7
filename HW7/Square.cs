using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Square : Shape
    {
        private double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return side * 4;
        }
        public override string ToString()
        {
            return String.Format("Square name is {0}\t|\tArea = {1:0.##}\t|\tPerimetr = {2:0.##}", Name, Area(), Perimeter());
        }
    }
}
