using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials
{
    public class FooterViewModel
    {
        public FooterLinksViewModel Column1 { get; set; }
        public FooterLinksViewModel Column2 { get; set; }
        public FooterLinksViewModel Column3 { get; set; }
        public FooterLinksViewModel Column4 { get; set; }
        public FooterLinksViewModel SocialFollowColumn { get; set; }

        public IEnumerable<LinkViewModel> SecondaryLinksDesktop { get; set; }
        public IEnumerable<LinkViewModel> SecondaryLinksMobile { get; set; }

        public string CopyrightStatement { get; set; }
    }
}
