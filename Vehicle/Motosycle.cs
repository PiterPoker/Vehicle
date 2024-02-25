using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Motosycle : Vehicle
    {
        public static string EngineType { get; set; }
        public static string Fuel { get; set; }
        public static int EnginePower { get; set; }
        public static int FuelConsumption { get; set; }

        static Motosycle()
        {
            AmountChassis = 2;
            MaxSpeed = 130;
            Weight = 150;
            Height = 0.7;
            Length = 2;
            Width = 0.4;
            EngineType = "Single engines";
            Fuel = "Petrol";
            EnginePower = 320;
            FuelConsumption = 8;
    }
    }
}
