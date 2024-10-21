using MobilemedCrud.Database.Entity;
using MobilemedCrud.Database.Services;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Registry.ViewModels
{
    public class MedicDeletViewModel : BindableBase
    {
        private readonly IMedicInterface _medicInterface;
        public List<MedicModel> MedicModels { get; set; }
        public MedicDeletViewModel(IMedicInterface medicInterface)
        {
            _medicInterface = medicInterface;

            MedicModels = _medicInterface.ListAllMedic();

        }

    }

}
