using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    internal class PerimeterCalculator
    {
        public double PerimeterCalculate(Figure figure)
        {
            return figure.Perimeter();
        }
    }
}
