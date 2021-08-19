using System;
using System.Collections.Generic;

namespace Inventory_Management
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Management System");
            FileReader fileReader = new FileReader();
            
           var inventories= fileReader.GetInventry();
            foreach(var inventory in inventories)
            {
                Console.WriteLine($"{ inventory.Name}");
                Console.WriteLine($"{inventory.Price * inventory.Weight}");
            }
            Console.ReadKey();
        }
    }
}
