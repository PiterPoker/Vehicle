using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Bus : Vehicle
    {
        public static string EngineType { get; set; }
        public static string Fuel { get; set; }
        public static string BodyType { get; set; }
        public static int AmountDoors { get; set; }
        public static int EnginePower { get; set; }
        public static int FuelConsumption { get; set; }
        static Bus()
        {
            AmountChassis = 6;
            MaxSpeed = 120;
            Weight = 25000;
            Height = 2.5;
            Length = 14;
            Width = 2;
            EngineType = "YC6K Series Gas Engine";
            Fuel = "Biodiesel";
            BodyType = "Large Body Buses";
            AmountDoors = 2;
            EnginePower = 375;
            FuelConsumption = 19;
        }
    }
}
