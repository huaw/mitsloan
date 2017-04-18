using MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials;

namespace MITSloan.Core.Implementation.Areas.Core.Models.Pages
{
    /// <summary>
    /// The SocialLinksPageViewModel interface.
    /// </summary>
    public interface ISocialLinksPageViewModel : ISeoSocialLinksPageViewModel, ICommonPageViewModel
    {
        LayoutViewModel Layout { get; set; }

        HeaderViewModel Header { get; set; }

        FooterViewModel Footer { get; set; }        
    }
}
