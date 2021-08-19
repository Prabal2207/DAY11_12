using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Inventory_Management
{
    public class FileReader
    {
        public List<Inventory> inventories = new List<Inventory>();
       // public Dictionary<string, Inventory> inventories = new Dictionary<string, Inventory>();

        public List<Inventory> GetInventry()
        {
            string text = File.ReadAllText("/Users/prabalrai/Projects/Inventory_Management/Inventory_Management/data.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);



            //int sumTotal = inventories.Sum(inventories => inventories.Price);
            //Console.WriteLine(sumTotal);


            return inventories;

            
        }

    }
}
