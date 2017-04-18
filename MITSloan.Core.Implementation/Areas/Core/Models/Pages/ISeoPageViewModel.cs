using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Pages
{
    using EPiServer.Core;

    public interface ISeoSocialLinksPageViewModel
    {
        string SeoDescription { get; set; }

        string SeoKeywords { get; set; }

        Uri CanonicalUrl { get; set; }

        string SeoTitle { get; set; }

        string SeoTrackingScript { get; set; }

        Uri SocialSharePageImage { get; set; }
    }
}
