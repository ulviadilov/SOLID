﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal interface IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
