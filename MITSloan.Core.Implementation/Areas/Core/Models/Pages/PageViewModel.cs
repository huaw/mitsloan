using MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Pages
{
    public class SocialLinksPageViewModel : ISocialLinksPageViewModel
    {
        public SocialLinksPageViewModel()
        {
            this.Layout = new LayoutViewModel();
            this.Header = new HeaderViewModel();
            this.Footer = new FooterViewModel();
        }

        public LayoutViewModel Layout { get; set; }

        public HeaderViewModel Header { get; set; }

        public string SeoDescription { get; set; }

        public string SeoKeywords { get; set; }

        public FooterViewModel Footer { get; set; }

        public string ApiLanguage { get; set; }

        public string ApiNode { get; set; }

        public Uri CanonicalUrl { get; set; }

        public string SeoTitle { get; set; }

        public string SeoTrackingScript { get; set; }

        public Uri SocialSharePageImage { get; set; }
    }
}
