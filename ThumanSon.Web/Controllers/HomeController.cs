using System.Web.Mvc;

namespace ThumanSon.Web.Controllers
{
    public class HomeController : ThumanSonControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}