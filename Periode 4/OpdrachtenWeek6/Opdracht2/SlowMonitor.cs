﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class SlowMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("displaying stuff very poor...");
        }
    }
}
