using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            var compDell = new Computer("Dell", "XPS 13", 4, 1500);
            var computer = new[]
            {
                new Computer("Asus","Zenbook UX330UA",22, 1200),
                new Computer("Lenovo","ThinkPad T460s",10,1500),
                new Computer("Apple", "MacBook Pro 2016",2,2200),
             };

            foreach (var x in computer)
            {
                Console.WriteLine("{0} {1} {2} {3}", x.Company, x.Model, x.Pieces, x.Price);
            }
          
            Console.WriteLine("{0} {1} {2} {3}", compDell.Company, compDell.Model, compDell.Pieces, compDell.Price);

            var pieces = computer.Select(x => x.Pieces).OrderBy(x => x);

            foreach (var x in pieces) Console.WriteLine(x);

           

        }

       
    }
   
    }

  
        

    
 
