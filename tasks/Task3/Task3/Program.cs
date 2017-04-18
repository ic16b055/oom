using System;

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
                Console.WriteLine(" 1  Tesla Aktienkurs\n");
                Console.WriteLine(" 2  Serialization\n");
                Console.WriteLine(" 3  Pull\n");
                Console.WriteLine(" 4  Push Mouse movement\n");
                Console.WriteLine(" 5  Asynchrony\n");
                Console.WriteLine(" 0  EXIT\n");

                Console.WriteLine("************************\n");
                select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1: Web.GetValue(); break;
                    case 2: serial(items); break;
                    case 3: Pull.Run(); break;
                    case 4: Push.Run(); break;
                    case 5: Asynchrony.Run(); break;
                    
                }
                if (select < 0 || select > 5) Console.WriteLine("Wrong input!\n");


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
