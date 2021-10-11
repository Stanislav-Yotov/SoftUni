﻿using System;
using System.Collections.Generic;
using System.Text;

namespace genericSwapMethodString
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            return $"{typeof(T)}: {Value}";
        }
    }
}
