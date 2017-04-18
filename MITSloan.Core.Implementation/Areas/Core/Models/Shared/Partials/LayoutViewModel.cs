using MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials
{
    public class LayoutViewModel
    {
        //public LayoutViewModel();

        public string ApplicationTitle { get; set; }
        public string BodyCssClass { get; set; }
        public ImageLinkViewModel Logo { get; set; }
        public string TwoLetterLanguageCode { get; set; }
    }
}
