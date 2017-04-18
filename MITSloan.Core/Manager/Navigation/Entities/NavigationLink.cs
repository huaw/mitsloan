using System;
using System.Collections.Generic;
using EPiServer.Core;

namespace MITSloan.Core.Manager.Navigation.Entities
{
    public class NavigationLink : INavigationLink
    {
        public string Name { get; set; }

        public Uri Url { get; set; }

        public bool NewWindow { get; set; }

        public bool IsOverlayOn { get; set; }
    }
}
