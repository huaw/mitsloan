using System.Collections.Generic;
using EPiServer.Core;
using MITSloan.Core.Manager.Navigation.Entities;

namespace MITSloan.Core.Manager.Navigation
{
    public interface INavigationManager
    {
        IEnumerable<INavigationLink> GetMainNavigation(PageReference current);       
    }
}
