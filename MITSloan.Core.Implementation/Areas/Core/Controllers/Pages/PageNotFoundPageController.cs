using System.Web.Mvc;
using EPiServer.Editor;
using EPiServer.Web.Mvc;
using MITSloan.Core.Implementation.Areas.Core.Models.Pages;
using MITSloan.Core.Implementation.Models.Pages;


namespace MITSloan.Core.Implementation.Areas.Core.Controllers.Pages
{
    public class PageNotFoundPageController : PageController<PageNotFoundPageType>
    {
        public ActionResult Index(PageNotFoundPageType currentPage)
        {
            PageNotFoundPageViewModel pageViewModel = new PageNotFoundPageViewModel
            {
                Heading = currentPage.Heading,
                SubHeading = currentPage.SubHeading,
                Body = currentPage.Body
            };
            if (!PageEditing.PageIsInEditMode)
                Response.StatusCode = 404;

            return View(pageViewModel);
        }
    }
}
