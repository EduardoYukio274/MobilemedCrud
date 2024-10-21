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
    public class PatientSearchViewModel: BindableBase
    {
        private readonly IPatientInterface _patientInterface;
        public List<PatientModel> PatientModels { get; set; }
        public PatientSearchViewModel(IPatientInterface patientInterface)
        {
            _patientInterface = patientInterface;

            PatientModels = _patientInterface.ListAllPatient();

        }
    }
}
