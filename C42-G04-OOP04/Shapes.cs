using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G04_OOP04
{
    internal abstract class Shapes
    {
        public double Width { get; set; }
        public double height { get; set; }
        public abstract double GetArea();
        public abstract double perimeter { get; }
    }
    internal class Rectangler : Shapes
    {

        public override double GetArea()
        {
            return Width * height;
        }
        public override double perimeter { get { return ((Width+height)*2); } }
    }

}
