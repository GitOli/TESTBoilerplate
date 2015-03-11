using System.Web.Mvc;

namespace TESTBoilerplate.Web.Controllers
{
    public class HomeController : TESTBoilerplateControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}