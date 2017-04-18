using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.Validation;
using nJupiter.Configuration;
using StructureMap.Configuration.DSL;
using MITSloan.Core.Implementation.Infrastructure.Lazy;
using MITSloan.Core.Implementation.Models.Pages;
using MITSloan.Core.Infrastructure.Lazy;
using MITSloan.Core.Models.Interfaces.Pages;
using MITSloan.Core.Manager.Navigation;
using MITSloan.Core.Implementation.Manager.Navigation;

namespace MITSloan.Core.Implementation.Bootstrapper
{
    public class CoreImplementationBootstrapper : Registry
    {
        public CoreImplementationBootstrapper()
        {
            //Managers
            this.For<INavigationManager>().Use<NavigationManager>();

            this.For<ILazy<IStartPage>>().Use<LazyStartPage<StartPageType>>();

            //Settings
            this.For<ILazy<ISiteSettings>>().Use<LazySiteSettings<SiteSettingsPageType, ISiteSettings>>();
            
            //Repositories
            this.For<IConfigRepository>().Use(ConfigRepository.Instance);

        }
    }
}
