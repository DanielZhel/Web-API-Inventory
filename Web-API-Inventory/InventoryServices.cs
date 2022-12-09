using System.Text.Json;

namespace Web_API_Inventory
{
    public class InventoryServices
    {
        public List<InventorySettings> prods = new List<InventorySettings>();
        public InventoryServices(string jsonPath)
        {
            string jsonString = File.ReadAllText(jsonPath);
            prods = JsonSerializer.Deserialize<List<InventorySettings>>(jsonString);

        }
    }
}
