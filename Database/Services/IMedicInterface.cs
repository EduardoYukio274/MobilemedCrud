using MobilemedCrud.Database.DTO;
using MobilemedCrud.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Services
{
    public interface IMedicInterface
    {
        Task<ResponseModel<List<MedicModel>>> CreatNewMedic(MedicDTO medicDTO);

        Task<ResponseModel<MedicModel>> SearchMedicWithId(int Id);

        Task<ResponseModel<MedicModel>> SearchMedicWithName(string Name);

        Task<ResponseModel<List<MedicModel>>> DeletMedic(int Id);
    }
}
