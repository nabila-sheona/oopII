﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_B_alter
{
    public class horror: Icalculation
    {
        public double calcbill(double price)
        {
            return price * .8;
        }

    }
}