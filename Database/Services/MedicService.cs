using Microsoft.EntityFrameworkCore;
using MobilemedCrud.Database.Data;
using MobilemedCrud.Database.DTO;
using MobilemedCrud.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Services
{
    public class MedicService : IMedicInterface
    {

        private readonly AppDbContext _context;
        public MedicService(AppDbContext context)
        {
            _context = context;
        }


        public Task<MedicModel> CreatNewMedic(MedicDTO medicDTO)
        {
            public async Task<MedicModel> CreatNewMedic(MedicDTO medicDTO)
            {
                try
                {
                    var Medic = new MedicModel()
                    {
                        Name = medicDTO.Name,

                        CPF = medicDTO.CPF,

                        RG = medicDTO.RG,

                        Phone = medicDTO.Phone,

                        Email = medicDTO.Email,

                        Address = medicDTO.Address,

                        City = medicDTO.City,

                        State = medicDTO.State,

                        ZipCode = medicDTO.ZipCode,

                        Country = medicDTO.Country,

                        CRM = medicDTO.CRM,

                        BirthDate = medicDTO.BirthDate,

                    };

                    _context.Add(Medic);
                    await _context.SaveChangesAsync();

                    await _context.Medic.ToListAsync();
                }

                catch
                {


                }
            }
        }
    }
}
