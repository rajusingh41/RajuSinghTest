using System.Web.Mvc;

namespace SPA.APIV2._0
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return RedirectToAction("", "Swagger", new { area = "" });
        }
    }
}
