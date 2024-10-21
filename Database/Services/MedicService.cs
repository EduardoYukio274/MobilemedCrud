using Azure;
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

        //Create a new Medic
        public async Task<ResponseModel<List<MedicModel>>> CreatNewMedic(MedicDTO medicDTO)
        {

            ResponseModel<List<MedicModel>> response = new ResponseModel<List<MedicModel>>();
            try
            {
                var Medic = new MedicModel()
                {
                    Id = medicDTO.Id,   

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

                return response;



            }
            catch(Exception ex) 
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }
        }

        //Delet a Medic
        public async Task<ResponseModel<List<MedicModel>>> DeletMedic(int Id)
        {
            ResponseModel<List<MedicModel>> response = new ResponseModel<List<MedicModel>>();
            
            try
            {
                var Medic = await _context.Medic.FirstOrDefaultAsync(MedicBank => MedicBank.Id == Id);

                if (Medic == null)
                {
                    response.Menssage = "Medico não localizado";
                    return response;
                }
                _context.Remove(Medic);
                await _context.SaveChangesAsync();

                response.Data =  await _context.Medic.ToListAsync();
                return response;

            }
            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }

        }

        public List<MedicModel> ListAllMedic()
        {

            return _context.Medic.ToList();
        }

        //Search a Medic with his/her Id
        public async Task<ResponseModel<MedicModel>> SearchMedicWithId(int Id)
        {
            ResponseModel<MedicModel> response = new ResponseModel<MedicModel>();
            try
            {
                var Medic = await _context.Medic.FirstOrDefaultAsync(MedicBank => MedicBank.Id == Id);

                if (Medic == null)
                {
                    response.Menssage = "Medico não localizado";
                    return response;
                }
                response.Data = Medic;
                return response;
            

            }

            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }

        }

        //Search a Medic with his/her Name
        public async Task<ResponseModel<MedicModel>> SearchMedicWithName(string Name)
        {
            ResponseModel<MedicModel> response = new ResponseModel<MedicModel>();
            try
            {
                var Medic = await _context.Medic.FirstOrDefaultAsync(MedicBank => MedicBank.Name == Name);

                if (Medic == null)
                {
                    response.Menssage = "Medico não localizado";
                    return response;
                }
                response.Data = Medic;
                return response;
            }

            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }
        }
    }
}