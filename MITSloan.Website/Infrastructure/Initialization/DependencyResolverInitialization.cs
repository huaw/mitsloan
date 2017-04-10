﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Security;
using EPiServer.UI;
using StructureMap;
using MITSloan.Core.Implementation.Bootstrapper;
using MITSloan.UserAndIdentity.Implementation.Bootstrapper;
using MITSloan.Website.Bootstrapper;
using MITSloan.Website.Infrastructure.Mvc.DependencyInjection;

namespace MITSloan.Website.Infrastructure.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);

            StructureMapDependencyResolver resolver = new StructureMapDependencyResolver(context.Container);

            DependencyResolver.SetResolver(resolver);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            //Register Core
            container.AddRegistry<CoreImplementationBootstrapper>();
            
            //Register User & Identity
            container.AddRegistry<UserAndIdentityImplementationBootstrapper>();
			
            //Default Overrides
            container.AddRegistry<DefaultBootstrapper>();
            
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}