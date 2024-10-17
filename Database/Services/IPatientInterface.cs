using MobilemedCrud.Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Services
{
    public interface IPatientInterface
    {
        Task<Entity.PatientModel> SearchPatientWithId(int Id);

        Task<Entity.PatientModel> SearchPatientWithName(string Name);

        Task<Entity.PatientModel> CreatNewPatient(PatientDTO patientDTO);

    }
}
