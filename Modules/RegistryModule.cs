using Microsoft.Identity.Client;
using MobilemedCrud.Core;
using MobilemedCrud.Database.Services;
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
            containerRegistry.RegisterForNavigation<PatientSearch>(NavigationRoutes.PatientSearch);
            containerRegistry.RegisterForNavigation<MedicSearch>(NavigationRoutes.MedicSearch);
            containerRegistry.RegisterForNavigation<BookMarkSearch>(NavigationRoutes.BookMarkSearch);
            containerRegistry.RegisterForNavigation<MedicDelet>(NavigationRoutes.MedicDelet);
            containerRegistry.RegisterForNavigation<BookMarkDelet>(NavigationRoutes.BookMarkDelet);
            containerRegistry.Register<IMedicInterface, MedicService>();
            containerRegistry.Register<IPatientInterface, PatientService>();
            containerRegistry.Register<IBookMarkInterface, BookMarkService>();

        }



    }
}