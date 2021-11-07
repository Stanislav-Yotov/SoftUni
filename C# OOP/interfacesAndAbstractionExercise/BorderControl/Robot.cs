﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IIdentifiable, IRobot
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Id { get; }
        public string Model { get; }
    }
}