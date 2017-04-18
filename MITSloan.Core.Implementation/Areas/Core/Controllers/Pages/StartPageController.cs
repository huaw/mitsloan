using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using EPiServer.Globalization;
using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using MITSloan.Core.Implementation.Areas.Core.Models.Pages;
using MITSloan.Core.Implementation.Models.Pages;
using MITSloan.Core.Infrastructure.Lazy;

namespace MITSloan.Core.Implementation.Areas.Core.Controllers.Pages
{
    public class StartPageController : PageController<StartPageType>
    {
        public ActionResult Index(StartPageType currentPage)
        {

            var viewModel = new StartSocialLinksPageViewModel()
            {
                FirstContentAreaTitle = currentPage.FirstContentAreaTitle,
                FirstContentArea = currentPage.FirstContentArea,
            };

            return View(viewModel);
        }
    }
}
