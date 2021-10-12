using System;
using System.Collections.Generic;
using System.Text;

namespace genericCountMethodDouble
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }



        public override string ToString()
            => $"{typeof(T)}: {Value}";
    }
}
