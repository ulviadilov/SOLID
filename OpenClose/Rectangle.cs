using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal class Rectangle : Figure
    {
        public double Heigth { get; set; }
        public double Wigth { get; set; }

        public override double Perimeter()
        {
            return (Heigth+Wigth)*2;
        }
    }
}
