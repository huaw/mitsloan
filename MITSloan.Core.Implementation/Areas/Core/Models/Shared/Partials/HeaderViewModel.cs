using EPiServer.Core;
using System.Collections.Generic;

using MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials
{
    public class HeaderViewModel
    {
        public HeaderViewModel()
        {            
            this.NavigationLinks = new List<LinkViewModel>();
        }

        public string SearchboxPlaceholder { get; set; }

        public string SearchBoxButtonLink { get; set; }        

        public IEnumerable<LinkViewModel> NavigationLinks { get; set; }                      

        public ContentArea ModalContentArea { get; set; }
    }
}
