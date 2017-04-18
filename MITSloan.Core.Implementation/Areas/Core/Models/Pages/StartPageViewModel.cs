using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Pages
{
    public class StartSocialLinksPageViewModel : SocialLinksPageViewModel
    {
        public string FirstContentAreaTitle { get; set; }
        public ContentArea FirstContentArea { get; set; }

    }
}
