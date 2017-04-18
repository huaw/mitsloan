using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MITSloan.Core.Implementation.Models.Pages
{
    [AdministrationSettings(
           ContentTypeFields = ContentTypeFields.AvailableInEditMode,
           PropertyDefinitionFields = PropertyDefinitionFields.None,
           GroupName = CoreGroupNames.PageTypeGroupName)]
    [ContentType(DisplayName = "404",
        AvailableInEditMode = false,
        GUID = "2905ca3e-2421-4a9e-8b78-7793127b0666",
        GroupName = CoreGroupNames.PageTypeGroupName)]
    public class PageNotFoundPageType : OptimizedTemplatedBasePageType
    {
        public override string BodyCssClass
        {
            get { return "error-page"; }
        }

        [CultureSpecific(true)]
        [Display(Name = "Heading", GroupName = SystemTabNames.Content, Order = 0)]
        public virtual string Heading { get; set; }

        [CultureSpecific(true)]
        [Display(Name = "Sub Heading", GroupName = SystemTabNames.Content, Order = 5)]
        public virtual string SubHeading { get; set; }

        [CultureSpecific(true)]
        [Display(Name = "Body", GroupName = SystemTabNames.Content, Order = 10)]
        public virtual XhtmlString Body { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            this.VisibleInMenu = false;
        }
    }
}