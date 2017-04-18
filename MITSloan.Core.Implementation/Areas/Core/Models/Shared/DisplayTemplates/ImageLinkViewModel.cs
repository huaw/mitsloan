using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates
{
    public class ImageLinkViewModel
    {
        //public ImageLinkViewModel();

        public Uri LinkUrl { get; set; }
        public bool NewWindow { get; set; }
    }
}
