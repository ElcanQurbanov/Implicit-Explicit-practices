﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Explicit.Models
{
    public class Dollar
    {
        public double Usd { get; set; }

        public Dollar(double usd)
        {
            Usd = usd;
        }
    }
}