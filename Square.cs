using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPattern
{
    public class Square : Shape
    {
        public int side1;

        public Square(string color, int side)
        {
            Name = "Square";
            Color = color;
            side1 = side;
        }

        public override int GetArea()
        {
            return side1 * side1;
        }
    }
}
