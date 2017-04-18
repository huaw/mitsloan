using EPiServer;
using EPiServer.Core;
using EPiServer.SpecializedProperties;

namespace MITSloan.Core.Models.Interfaces.Pages
{
    public interface IHeaderSettings
    {
        PageReference PageLink { get; }
        LinkItemCollection NavigationLinks { get; }
        ContentArea ModalContentArea { get; }
    }
}
