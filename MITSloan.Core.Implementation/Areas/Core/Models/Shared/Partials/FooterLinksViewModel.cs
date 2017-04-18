using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials
{
    public class FooterLinksViewModel
    {
        public FooterLinksViewModel()
        {
            this.ColumnLinks = new List<LinkViewModel>();
        }
        public string ColumnTitle { get; set; }
        public IEnumerable<LinkViewModel> ColumnLinks { get; set; }
    }
}
