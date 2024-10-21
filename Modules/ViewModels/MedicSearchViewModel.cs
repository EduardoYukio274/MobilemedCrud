using MobilemedCrud.Database.Entity;
using MobilemedCrud.Database.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MobilemedCrud.Registry.ViewModels
{
    public class MedicSearchViewModel: BindableBase
    {
        private readonly IMedicInterface _medicInterface;
        public List<MedicModel> MedicModels { get; set; }
        public MedicSearchViewModel(IMedicInterface medicInterface)
        {
            _medicInterface = medicInterface;

            MedicModels = _medicInterface.ListAllMedic();

        }

    }
}
