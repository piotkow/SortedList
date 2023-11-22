using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var customCollection = new CustomSortedCollection<int, string>();

        customCollection.AddElement(3, "Three");
        customCollection.AddElement(1, "One");
        customCollection.AddElement(2, "Two");
        customCollection.AddElement(5, "Five");
        customCollection.AddElement(8, "Eight");
        customCollection.AddElement(9, "Nine");

        customCollection.DisplayElements();

        Console.WriteLine("Greater than 4 with LINQ: ");
        var fileredItems = customCollection.Where(x => x.Key > 4);
        foreach (var item in fileredItems)
        {
            Console.WriteLine(item);
        }

        bool removed = customCollection.RemoveElement(1);
        Console.WriteLine($"\nRemoved element with key 1: {removed}");

        customCollection.DisplayElements();
    }
}
