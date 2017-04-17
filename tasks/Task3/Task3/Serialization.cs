using System;
using System.IO;
using Newtonsoft.Json;

namespace Task3
{
    class Serialization
    {

        public static void Run_item(IItem [] items)
        {

            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            var text = JsonConvert.SerializeObject(items,settings);

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<IItem[]>(textFromFile, settings);

            Console.WriteLine("\n\nAfter: \n");
            foreach (var x in items)
            {     
                Console.WriteLine("{0} {1} {2}", x.Description.Truncate(2), x.GetPieces, x.GetPrice);
            }

        }

    
        










    }
}
