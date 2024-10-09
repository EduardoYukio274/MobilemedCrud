using MobilemedCrud.Modules.ModuleName;
using MobilemedCrud.Services;
using MobilemedCrud.Services.Interfaces;
using MobilemedCrud.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace MobilemedCrud
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
       
    }
}
