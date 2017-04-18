using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.DataAbstraction;
using EPiServer.Globalization;
using EPiServer.Licensing.Services;
using EPiServer.SpecializedProperties;
using EPiServer.Web.Routing;
using MITSloan.Core.Infrastructure.Lazy;
using MITSloan.Core.Implementation.Models.Pages;
using MITSloan.Core.Manager.Navigation;
using MITSloan.Core.Manager.Navigation.Entities;
using MITSloan.Core.Models.Interfaces.Pages;
using MITSloan.Core.Models.Interfaces.Pages.Characteristics;

namespace MITSloan.Core.Implementation.Manager.Navigation
{
    class NavigationManager : INavigationManager
    {
        private readonly UrlResolver _urlResolver;
        private readonly IContentRepository _contentRepository;
        private readonly IEnumerable<IPageFilter> _navigationPageFilters;
        //private readonly ILazy<IHeaderSettings> _headerSettings;        
        private readonly ILazy<ISiteSettings> _siteSettings;


        public NavigationManager(UrlResolver urlResolver, IContentRepository contentRepository, IEnumerable<IPageFilter> navigationPageFilters, ILazy<ISiteSettings> siteSettings)
        {
            this._urlResolver = urlResolver;
            this._contentRepository = contentRepository;
            this._navigationPageFilters = navigationPageFilters;
            this._siteSettings = siteSettings;                       
        } 

        private IEnumerable<TemplatedBasePageType> GetFilteredChildPages(PageReference pageReference)
        {
            IEnumerable<TemplatedBasePageType> childPages = this._contentRepository.GetChildren<TemplatedBasePageType>(pageReference);

            PageDataCollection collection = new PageDataCollection(childPages);

            foreach (IPageFilter filter in this._navigationPageFilters)
                filter.Filter(collection);

            return collection.OfType<TemplatedBasePageType>();

        }

        private INavigationLink CreateNavigationLink(string name, PageData page)
        {
            Uri uri = new Url(page.PageLink.ToString()).Uri;

            NavigationLink link = new NavigationLink()
            {
                Name = name,
                Url = uri,
                NewWindow = false,
            };

            if (page is IHasOverlaySetting)
            {
                IHasOverlaySetting overlayPage = page as IHasOverlaySetting;

                link.IsOverlayOn = overlayPage.IsOverlayInNavigation;
            }

            return link;
        }

        private INavigationLink CreateNavigationLink(string name, PageReference reference)
        {
            PageData linkedPage = this._contentRepository.Get<TemplatedBasePageType>(reference);

            return this.CreateNavigationLink(name, linkedPage);

        }

        private INavigationLink CreateNavigationLink(TemplatedBasePageType page)
        {
            string name = page.Name;
            bool isOverlay = false;
       
            IHasPageTitle pageWithTitle = page as IHasPageTitle;
            if (pageWithTitle != null)
            {
                name = pageWithTitle.PageTitle;
            }

            //overlay setting
            IHasOverlaySetting pageWithOverlay = page as IHasOverlaySetting;
            if (pageWithOverlay != null)
            {
                isOverlay = pageWithOverlay.IsOverlayInNavigation;
            }

            NavigationLink link = new NavigationLink()
            {
                Name = name,
                Url = new Url(this._urlResolver.GetUrl(page.PageLink)).Uri,
                NewWindow = false,
                IsOverlayOn = isOverlay
            };

            return link;
        }

        public IEnumerable<INavigationLink> GetMainNavigation(PageReference current)
        {
           IEnumerable<TemplatedBasePageType> navigationPages = this.GetFilteredChildPages(current);
           return navigationPages.Select(page => this.CreateNavigationLink(page)).ToList();
        }

        private IEnumerable<INavigationLink> ExtractColumnLinks(IEnumerable<LinkItem> links)
        {
            if (links == null)
                return null;

            return links.Select(l =>
            {
                Uri uri = GetUri(l.Href);

                return new NavigationLink()
                {
                    Name = l.Text,
                    Url = uri,
                    NewWindow = l.Target == "_blank"
                };
            });
        }

        private static bool TryResolveCurrentForNonPage(string rewrittenPageUrl, LanguageBranch languageBranch)
        {
            Url rewrittenUrl = new Url(rewrittenPageUrl);

            //Get the current url from our request
            Url currentUrl = new Url(HttpContext.Current.Request.Url);

            //Are any of the segments equal, then assume the menu item is selected
            return currentUrl.Segments.Any(segment => rewrittenUrl.Segments.Contains(segment) && !segment.Equals("/") && !segment.Equals(String.Format("{0}/", languageBranch.CurrentUrlSegment)));
        }

        private Uri GetUri(ContentReference contentReference)
        {
            return contentReference == null ? null : GetUri(_urlResolver.GetUrl(contentReference));
        }

        private Uri GetUri(string link)
        {
            Url url = this._urlResolver.GetUrl(link);

            if (url == null || String.IsNullOrWhiteSpace(url.OriginalString))
                return null;

            return string.IsNullOrEmpty(link) ? null : url.Uri;
        }
    }
}
