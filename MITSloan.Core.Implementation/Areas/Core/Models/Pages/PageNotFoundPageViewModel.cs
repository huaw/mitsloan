using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Pages
{
    public class PageNotFoundPageViewModel
    {
        public string Heading { get; set; }

        public string SubHeading { get; set; }

        public IHtmlString Body { get; set; }
    }
}
