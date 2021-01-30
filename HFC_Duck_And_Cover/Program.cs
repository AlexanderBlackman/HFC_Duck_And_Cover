using System;
using System.Collections.Generic;

namespace HFC_Duck_And_Cover
{
    class Program
    {
         
        static void Main(string[] args)
        {


            DuckComparer comparer = new DuckComparer();
            List<Duck> myFlock = new List<Duck>()
            {
                new Duck(){Size=12, Kind= Duck.KindOfDuck.Loon},
                new Duck(){Size=15, Kind = Duck.KindOfDuck.Peking},
                new Duck(){Size=19, Kind = Duck.KindOfDuck.Muscovy},
                new Duck(){Size = 10, Kind = Duck.KindOfDuck.Mallard},
                new Duck(){Size = 14, Kind = Duck.KindOfDuck.Muscovy},
                new Duck(){Size = 15, Kind = Duck.KindOfDuck.Loon}
            };



            Console.WriteLine("\nSorting by kind then size\n");
            comparer.SortBy = SortCriteria.KindThenSize;
            myFlock.Sort(comparer);
            PrintDucks(myFlock);
            Console.WriteLine("\nSorting by size, then kind\n" );
            comparer.SortBy = SortCriteria.SizeThenKind;
            myFlock.Sort(comparer);
            PrintDucks(myFlock);

        }
        
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"A {duck.Size}\" {duck.Kind}");
            }
        }
        
    }
}
