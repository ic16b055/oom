using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Task3
{

    public static class Pull
    {

        public static void Run()
        {
            WriteLine("IEnumerable array\n");
         
            IEnumerable<IItem> T = new IItem[] 
            
            {
                new Computer("Lenovo","ThinkPad T460s",10,1500),
                new Computer("Apple", "MacBook Pro 2016",2,2200),
                new Printer ("HP","LaserJet Pro",5,600),

            };

            foreach (var x in T)
            {
                Console.WriteLine("{0} {1} {2}", x.Description.Truncate(2), x.GetPieces, x.GetPrice);
            }

        }

    }

}