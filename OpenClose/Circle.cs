using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }

        public override double Perimeter()
        {
            return Radius*Math.PI*2;
        }
    }
}
