using MobilemedCrud.Database.DTO;
using MobilemedCrud.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Services
{
    public interface IPatientInterface
    {
        Task<ResponseModel<PatientModel>> SearchPatientWithId(int Id);

        Task<ResponseModel<PatientModel>> SearchPatientWithName(string Name);

        Task<ResponseModel<List<PatientModel>>> CreatNewPatient(PatientDTO patientDTO);

    }
}
