using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Runtime;
using System.Runtime.CompilerServices;
using Web_API_Inventory.Model;
using Web_API_Inventory.Services;

namespace Web_API_Inventory.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly MethodsForProducts _settings;
        private readonly ILogger<ProductController> _logger;
 
        public ProductController(ILogger<ProductController> logger, MethodsForProducts settings)
        {
            _logger = logger;
            _settings = settings;
            
        }

        [HttpGet]
        public ActionResult ViewProductsList()
        {
            return Ok(_settings.ViewAllProducts());
        }

        [HttpGet]
        public ActionResult SortByType(string productType)
        {
            return Ok(_settings.SortByType(productType));
        }

        [HttpGet]
        public ActionResult GetPriceOfAllPRoduct()
        {
            return Ok(_settings.PriceSum());
        }

        [HttpGet]
        public ActionResult DeleteProductByName(string productName)
        {
            return Ok(_settings.DeleteProduct(productName));
        }

        //[HttpPost]
        //public ActionResult ModifyProduct(string productType)
        //{
        //    _settings.ModifiedProduct(productType);
        //    return Ok();
        //}

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _settings.AddProduct(product);
            return Ok();
        }
    }
}