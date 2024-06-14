using Microsoft.AspNetCore.Mvc;

namespace Foundation.CmsPlugin.Controllers
{
    public class PluginController : Controller
    {
        [HttpGet]
        [Route("episerver/plugin/index", Name = "Plugin")]
        public ActionResult Index()
        {
            return View("Foundation.CmsPlugin/Views/Index.cshtml");
        }
    }
}
