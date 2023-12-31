﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldGeometry.Model
{
    public sealed class Circle
    {
        public Point Center {  get; set; }
        public double Radius { get; set; }
        public  double Surface { get => Math.PI * Radius * Radius; }
    }
}
