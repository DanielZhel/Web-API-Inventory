using System;
using Web_API_Inventory.Model;
using System.Text.Json;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Web_API_Inventory.Services
{
    public class InventoryService
    {
        public List<Product> products = new List<Product>();
        public InventoryService(string jsonPath)
        {
            string jsonstring = File.ReadAllText(jsonPath);
            products = JsonConvert.DeserializeObject<List<Product>>(jsonstring);
        }
    }
}
