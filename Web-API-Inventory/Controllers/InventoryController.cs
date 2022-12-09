using Microsoft.AspNetCore.Mvc;

namespace Web_API_Inventory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly InventorySettings _settings;
        private readonly ILogger<InventoryController> _logger;

        public InventoryController(ILogger<InventoryController> logger, InventorySettings settings)
        {
            _logger = logger;
            _settings = settings;
        }

        [HttpGet]
        public IEnumerable<InventorySettings> Get()
        {
            return Enumerable.Range(1,1).Select(index => new InventorySettings()
            {
                TypeOfProduct = _settings.TypeOfProduct,
                ProductName = _settings.ProductName,
                PriceOfProduct = _settings.PriceOfProduct
            })
            .ToArray();
        }
    }
}