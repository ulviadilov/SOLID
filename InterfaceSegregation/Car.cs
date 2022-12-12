using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Car : IVehicle , IwithEngine
    {
        public string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double LBS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
