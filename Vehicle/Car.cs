namespace Vehicle
{
    internal class Car : Vehicle
    {
        public static string EngineType { get; set; }
        public static string Fuel { get; set; }
        public static string BodyType { get; set; }
        public static int AmountDoors { get; set; }
        public static int EnginePower { get; set; }
        public static int FuelConsumption { get; set; }
        static Car()
        {
            AmountChassis = 4;
            MaxSpeed = 150;
            Weight = 2500;
            Height = 1.5;
            Length = 3.5;
            Width = 1.5;
            EngineType = "V engine";
            Fuel = "Petrol";
            BodyType = "Sedan";
            AmountDoors = 5;
            EnginePower = 650;
            FuelConsumption = 10;
        }
    }
}
