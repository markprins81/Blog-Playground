using Microsoft.AspNetCore.Mvc;

namespace Arlanet.Optimizely.ProductMarkets.Controllers
{
    public class ProductMarketsController : Controller
    {
        [HttpGet]
        [Route("episerver/productmarkets/index", Name = "ProductMarkets")]
        public ActionResult Index()
        {
            return View("Arlanet.Optimizely.ProductMarkets/Views/Index.cshtml");
        }
    }
}
