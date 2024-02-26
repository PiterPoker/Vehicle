using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Vehicle.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3.1
            Functionality.WriteEveryVehicleTypeAndSorted();

            //Task 3.2
            Functionality.RunSearchConsole();

            //Rask 3.3
            Functionality.WriateInstancesToDisk();
        }
    }
}
