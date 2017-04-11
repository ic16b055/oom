using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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

            var select = 0;


            do
            {
                Console.WriteLine("\n**** Please select: ****\n");
                Console.WriteLine(" 1  Serialization\n");
                Console.WriteLine(" 2  Pull\n");
                Console.WriteLine(" 0  EXIT\n");

                Console.WriteLine("************************\n");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                case 1: serial(items); break;
                case 2: Pull.Run(); break;

                }
                if (select < 0 || select > 2) Console.WriteLine("Wrong input!\n");


            } while (select != 0);

 

        }
        private static void serial(IItem [] items)
            { 
                Console.WriteLine("\nBefore: \n");

                foreach (var x in items)
                {
                Console.WriteLine("{0} {1} {2}", x.Description.Truncate(2), x.GetPieces, x.GetPrice);
                }   
                
             Serialization.Run_item(items);
            }
             

    }
}
