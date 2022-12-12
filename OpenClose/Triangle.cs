using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal class Triangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }


        public override double Perimeter()
        {
            double perimeter = Side1+ Side2+ Side3;
            return perimeter;
        }
    }
}
