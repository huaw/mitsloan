using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.Cache;
using StructureMap;
using MITSloan.Core.Infrastructure.Lazy;
using MITSloan.Core.Models.Interfaces.Pages;

namespace MITSloan.Core.Implementation.Infrastructure.Lazy
{
	public class LazySiteSettings<TSettings, TAbstraction> : Lazy<TAbstraction> where TSettings : class, TAbstraction, IContentData, new() where TAbstraction : ISiteSettings
    {
		public LazySiteSettings(IContainer container)
			: base(container)
        {
            
        }

		public override TAbstraction Load(IContainer container)
        {
            ILazy<IStartPage> startPage = container.GetInstance<ILazy<IStartPage>>();

            if (startPage == null || ContentReference.IsNullOrEmpty(startPage.Service.SettingsPageReference))
				return new TSettings();

            var contentLoader = container.GetInstance<IContentLoader>();

			return contentLoader.Get<TSettings>(startPage.Service.SettingsPageReference) ?? new TSettings();
        }
    }
}
