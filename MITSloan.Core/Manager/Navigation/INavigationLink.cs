using System;
using EPiServer.Core;

namespace MITSloan.Core.Manager.Navigation
{
    public interface INavigationLink
    {
        string Name { get; }

        Uri Url { get; }

        bool NewWindow { get; }

        bool IsOverlayOn { get; }
    }
}
