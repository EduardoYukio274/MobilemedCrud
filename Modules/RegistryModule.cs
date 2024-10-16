using MobilemedCrud.Core;
using MobilemedCrud.Registry.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Navigation.Regions;

namespace MobilemedCrud.Registry
{
    public class RegistryModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public RegistryModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "Home");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Home>("Home");
            containerRegistry.RegisterForNavigation<PatientRegistry>(NavigationRoutes.PatientRegistry);
            containerRegistry.RegisterForNavigation<BookmarkRegistry>(NavigationRoutes.BookmarkRegistry);
            containerRegistry.RegisterForNavigation<MedicRegistry>(NavigationRoutes.MedicRegistry);
        }
    }
}