﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
            
        }
        public string Name { get; set; }
    }
}
