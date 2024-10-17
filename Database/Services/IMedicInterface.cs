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
        Task<MedicModel> CreatNewMedic(MedicDTO medicDTO);
    }
}
