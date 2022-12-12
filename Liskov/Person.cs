﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    abstract class Person
    {
        public abstract string GetFullname();
        public abstract byte GetAge();
    }
}
