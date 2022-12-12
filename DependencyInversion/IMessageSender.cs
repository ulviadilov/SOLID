﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal interface IMessageSender
    {
        public void Send();
    }
}
