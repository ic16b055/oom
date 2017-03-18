using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new IItem[]
            {
                new Computer("Asus","Zenbook UX330UA",22, 1200),
                new Computer("Lenovo","ThinkPad T460s",10,1500),
                new Computer("Apple", "MacBook Pro 2016",2,2200),
                new Printer ("HP","LaserJet Pro",5,600),
                new Printer ("Canon","PIXMA",2,250)
             };

          Console.WriteLine("\nBefore: \n");

            foreach (var x in items)
            {
                Console.WriteLine("{0} {1} {2}", x.Description.Truncate(2), x.GetPieces, x.GetPrice);
            }



           
            
           
            Serialization.Run_item(items);
           
        }      

    }
}
