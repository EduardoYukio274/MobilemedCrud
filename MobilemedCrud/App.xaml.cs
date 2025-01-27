﻿using Microsoft.Identity.Client;
using MobilemedCrud.Database.Services;
using MobilemedCrud.Registry;
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

            MobilemedCrud.Database.Data.AppDbContext.UpdateDatabase();

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
           

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<RegistryModule>();
        }

        
    }
}
