using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates
{
    public class LinkViewModel
    {
        public string CssClass { get; set; }
        public bool Enabled { get; set; }
        public Uri LinkUrl { get; set; }
        public bool NewWindow { get; set; }
        public string Text { get; set; }
        public bool IsOverLayNavigationPage { get; set; }
    }
}
