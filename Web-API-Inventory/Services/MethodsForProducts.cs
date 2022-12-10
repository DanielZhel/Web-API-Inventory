using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using Web_API_Inventory.Model;

namespace Web_API_Inventory.Services
{
    public class MethodsForProducts
    {
        InventoryService inventoryService;
        public MethodsForProducts(InventoryService inventoryService)
        {
            this.inventoryService = inventoryService; 
        }

        public List<Product> ViewAllProducts()
        {
            return inventoryService.products;
        }

        public void AddProduct(Product product)
        {
            inventoryService.products.Add(product);
        }

        public List<Product> SortByType(string product)
        {
            List<Product> sortedProducts = new List<Product>();
            for (int i = 0; i < inventoryService.products.Count; i++)
            {
                if (inventoryService.products[i].TypeOfProduct == product)
                    sortedProducts.Add(inventoryService.products[i]);
            }
            return sortedProducts;
        }

        public decimal PriceSum()
        {
            decimal price = 0;
            
            foreach(Product p in inventoryService.products)
            {
                price += p.PriceOfProduct;
            }
            return price;
        }
        //public List<Product> ModifiedProduct(string TypeOfProduct)
        //{
        //    foreach(Product p in inventoryService.products)
        //    {
        //        if (p.TypeOfProduct == TypeOfProduct)
        //        {
        //            inventoryService.products.Remove(p);
        //        }
        //    }
           
        //    inventoryService.products.Add();
        //    return inventoryService.products;
        //}

        public List<Product> DeleteProduct(string productName)
        {
            List<Product> newListOFPRoduct;

            foreach (Product product in inventoryService.products)
            {
                if (product.ProductName == productName)
                {
                    inventoryService.products.Remove(product);
                    break;
                }
            }
            return newListOFPRoduct = inventoryService.products;
        }
    }
}
