using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public abstract class Vehicle
    {
        public static int AmountChassis { get; set; }
        public static int MaxSpeed { get; set; }
        public static double Weight { get; set; }
        public static double Height { get; set; }
        public static double Length { get; set; }
        public static double Width { get; set; }
    }
}
