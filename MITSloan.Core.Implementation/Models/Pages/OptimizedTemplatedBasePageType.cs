using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using MITSloan.Core.Implementation.Models.Tabs;
using MITSloan.Core.Models.Interfaces.Pages.Characteristics;

namespace MITSloan.Core.Implementation.Models.Pages
{
    using EPiServer.DataAbstraction;
    using EPiServer.Web;

    public class OptimizedTemplatedBasePageType : TemplatedBasePageType, IHasSeoMetaData, IHasOverlaySetting
    {
        #region SEO common settings
        [CultureSpecific]
        [Display(Order = 1, GroupName = CoreTabNames.SeoSocialLinks)]
        public virtual string SeoTitle { get; set; }

        [CultureSpecific]
        [Display(Order = 2, GroupName = CoreTabNames.SeoSocialLinks)]
        public virtual string SeoKeywords { get; set; }

        [CultureSpecific]
        [Display(Order = 3, GroupName = CoreTabNames.SeoSocialLinks)]
        public virtual string SeoDescription { get; set; }

        #endregion SEO common settings
        #region Social Link settings

        [Display(Name = "Social Share Page Image", GroupName = CoreTabNames.SeoSocialLinks, Order = 4)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference SocialSharePageImage { get; set; }

        #endregion Social Link settings

        [CultureSpecific]
        [Display(Name ="Overlay setting for navigation", Order = 4, GroupName = SystemTabNames.Content)]
        public virtual bool IsOverlayInNavigation { get; set; }
    }
}
