﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(0, this.Count - 1);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
