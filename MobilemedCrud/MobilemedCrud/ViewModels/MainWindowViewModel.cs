using MobilemedCrud.Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation.Regions;
using System.Threading.Tasks;

namespace MobilemedCrud.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "CRUD";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager _regionManager;


        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        private DelegateCommand<string> _Navigate;
        public DelegateCommand<string> Navigate =>
            _Navigate ?? (_Navigate = new DelegateCommand<string>(ExecuteNavigate));

        void ExecuteNavigate(string arg)
        {
            Title = arg;
            _regionManager.RequestNavigate(RegionNames.ContentRegion, arg);

        }
    }
}
