using System;

namespace oop_mid_6115261014
{
    class Program
    {
        static void Main(string[] args)
        {
            Village a = new Village("a", 10000);
            Village b = new Village("b", 50000);
            Village c = new Village("c", 100000);
            Decoration Gangnam = new Decoration("Gangnam", 100000);
            Decoration Ascard = new Decoration("Ascard", 20000);
            Decoration Winterfell = new Decoration("Winterfell", 1000000);
            House h1 = new House(1, 1, 100, Gangnam, a);
            House h2 = new House(2, 2, 150, Ascard, a);
            House h3 = new House(3, 3, 400, Ascard, b);
            House h4 = new House(4, 4, 600, Winterfell, b);
            House h5 = new House(5, 5, 1000, Winterfell, a);
            Console.WriteLine(h1.ToString());
            Console.WriteLine(h2.ToString());
            Console.WriteLine(h3.ToString());
            Console.WriteLine(h4.ToString());
            Console.WriteLine(h5.ToString());
   
         }
        }

    }

    
