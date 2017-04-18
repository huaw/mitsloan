using System.Web.Mvc;
using MITSloan.Core.Implementation.Areas.Core.Models.Pages;

namespace MITSloan.Core.Implementation.Areas.Core.Controllers.Pages
{
    public class UnexpectedErrorPageController : Controller
    {
        public ActionResult Index()
        {
            var model = new PlainPageViewModel { SeoTitle = "Unexpected Error" };
            Response.StatusCode = 500;
            return View(model);
        }
    }
}
