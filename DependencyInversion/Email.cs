﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class Email : IMessageSender
    {
        public void Send()
        {
            Console.WriteLine("Sent from email");
        }
    }
}
