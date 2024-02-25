using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Bike : Vehicle
    {
        static Bike()
        {
            AmountChassis = 2;
            MaxSpeed = 40;
            Weight = 10;
            Height = 0.5;
            Length = 1.5;
            Width = 0.35;
    }
    }
}
