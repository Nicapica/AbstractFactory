﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Genie : IDumb
    {
        string IDumb.getName()
        {
            string name = "Genie";
            Console.WriteLine(name);
            return name;
        }
    }
}
