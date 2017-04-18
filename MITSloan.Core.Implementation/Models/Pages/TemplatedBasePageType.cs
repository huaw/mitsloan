using EPiServer.Core;
using EPiServer.DataAnnotations;
using MITSloan.Core.Models.Interfaces.Pages.Characteristics;

namespace MITSloan.Core.Implementation.Models.Pages
{

    public class TemplatedBasePageType : PageData, IHasBodyCssClass
    {
        [Ignore]
        public virtual string BodyCssClass { get; }
    }
}