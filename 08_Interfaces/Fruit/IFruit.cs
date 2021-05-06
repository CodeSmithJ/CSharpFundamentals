﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    // Naming convention for interfaces: I______
    interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; }
        // Methods interfaces
        // Can only set the return type, name, and parameters
        string Peel();
    }
}
