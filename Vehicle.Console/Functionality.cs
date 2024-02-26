using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicle.Console
{
    internal static class Functionality
    {
        #region Task 3.1
        internal static void WriteEveryVehicleTypeAndSorted()
        {
            var sortedTypes = InstanceService<Vehicle>.GetInstances()
                .Select(t => t.GetType().Name)
                .OrderBy(t => t);

            System.Console.WriteLine($"Vehicle type name, sorted alphabetically:");
            foreach (var type in sortedTypes)
            {
                System.Console.WriteLine($"Type: {type}");
            }
        }
        #endregion

        #region Task 3.2
        static bool IsMatchMask(string value, string mask)
        {
            bool result = Regex.IsMatch(value, mask, RegexOptions.IgnoreCase);
            return result;
        }

        internal static IEnumerable<T> SearchForTypesByName<T>(string mask)
        {
            return InstanceService<T>.GetInstances()
                .Select(t => new
                {
                    TypeName = t.GetType().Name,
                    Type = t,
                })
                .Where(t => IsMatchMask(t.TypeName, mask))
                .OrderBy(t => t.TypeName)
                .Select(t => t.Type);
        }

        internal static void RunSearchConsole()
        {
            try
            {
                string typeName = string.Empty;
                bool isExite = false;
                var result = string.Empty;
                do
                {
                    System.Console.Write($"You can use button \"Enter\" for exit. Search for name: {typeName}{result}");
                    var key = System.Console.ReadKey();

                    switch (key.Key)
                    {
                        case ConsoleKey.Enter:
                            result = $"{typeName}\n";
                            var types = SearchForTypesByName<Vehicle>(typeName);

                            if (types.Any())
                            {
                                foreach (var type in types)
                                {
                                    result += $"Type name {type.GetType().Name}\n";
                                }
                            }
                            else
                            {
                                result += $"Type not found\n";
                            }
                            typeName = string.Empty;
                            break;
                        case ConsoleKey.Escape:
                            isExite = true;
                            break;
                        case ConsoleKey.Backspace:
                            {
                                result = string.Empty;
                                if (!string.IsNullOrWhiteSpace(typeName))
                                    typeName = typeName.Remove(typeName.Length - 1);
                                System.Console.Clear();
                                break;
                            }
                        default:
                            {
                                result = string.Empty;
                                typeName += key.KeyChar;
                                System.Console.Clear();
                                break;
                            }
                    }

                } while (!isExite);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }
        #endregion

        #region Task 3.3

        static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        internal static void WriateInstancesToDisk()
        {
            var types = InstanceService<Vehicle>.GetInstances()
                .ToList();

           var arrayByte = ObjectToByteArray(types);
            string path = Directory.GetCurrentDirectory();
            string fullPath = $"{path}\\data.dat";

            if (File.Exists(path))
            {
                File.Delete(path);
            }


            using (FileStream fstream = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                fstream.Write(arrayByte, 0, arrayByte.Length);
                System.Console.WriteLine($"The all instances recorded to disk \n Path: {path}");
            }
        }

        #endregion
    }
}
