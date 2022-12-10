namespace Web_API_Inventory.Model
{
    public class Product
    {
        public string TypeOfProduct { get; set; }
        public string ProductName { get; set; }
        public decimal PriceOfProduct { get; set; }
        public Product(string typeOfProduct, string productName, decimal priceOfProduct)
        {
            TypeOfProduct = typeOfProduct;
            ProductName = productName;
            PriceOfProduct = priceOfProduct;
        }
    }
}
