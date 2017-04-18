using EPiServer;
using EPiServer.Core;
using EPiServer.SpecializedProperties;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MITSloan.Core.Implementation.Areas.Core.Models.Pages;
using MITSloan.Core.Implementation.Areas.Core.Models.Shared.Partials;
using MITSloan.Core.Manager.Navigation;
using MITSloan.Core.Models.Interfaces.Pages;
using MITSloan.Core.Implementation.Areas.Core.Models.Shared.DisplayTemplates;
using EPiServer.Framework.Localization;
using MITSloan.Core.Infrastructure.Lazy;
using EPiServer.ServiceLocation;

namespace MITSloan.Core.Implementation.Infrastructure.Mvc.Filters.LayoutFilters
{
    class HeaderResultFilter : IResultFilter
    {
        private readonly ILazy<IStartPage> _startPage;
        private readonly INavigationManager _navigationManager;
        private readonly UrlResolver _urlResolver;

        public HeaderResultFilter()            
        {
            this._navigationManager = ServiceLocator.Current.GetInstance<INavigationManager>();
            this._urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            this._startPage = ServiceLocator.Current.GetInstance<ILazy<IStartPage>>();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //Get the viewModel from the context
            ISocialLinksPageViewModel model = filterContext.Controller.ViewData.Model as ISocialLinksPageViewModel;

            if (model == null)
                return;

           

            model.Header = new HeaderViewModel();
            model.Header.NavigationLinks = MakeLinksList();            
            model.Header.SearchboxPlaceholder = LocalizationService.Current.GetString("/core/global/placeholders/searchboxplaceholder");
            
            
   
        }

        private IEnumerable<LinkViewModel> MakeLinksList()
        {
            IEnumerable < INavigationLink > navigationLinks = this._navigationManager.GetMainNavigation(_startPage.Service.ContentLink.ToPageReference());
            return navigationLinks.Select(link => this.CreateLinkViewModel(link.Url,link.Name,link.NewWindow,string.Empty,link.IsOverlayOn)).ToList();
        }

        private LinkViewModel CreateLinkViewModel(Uri link, string text, bool newWindow, string cssClass, bool isOverlay)
        {
            if (link == null || string.IsNullOrEmpty(text))
                return null;

            string rewritten = this._urlResolver.GetUrl(link.OriginalString);

            return new LinkViewModel()
            {
                Text = text,
                LinkUrl = new Url(rewritten).Uri,
                NewWindow = newWindow,
                CssClass = cssClass,
                Enabled = true,
                IsOverLayNavigationPage = isOverlay
            };
        }

    }
}
