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
    public class PatientService : IPatientInterface
    {
        private readonly AppDbContext _context;
        public PatientService(AppDbContext context)
        {
            _context = context;
        }

        //Creat a new Patient
        public async Task<ResponseModel<List<PatientModel>>> CreatNewPatient(PatientDTO patientDTO)
        {
            ResponseModel<List<PatientModel>> response = new ResponseModel<List<PatientModel>>();
            try
            {
                var Patient = new PatientModel()
                {
                    Id = patientDTO.Id,

                    Name = patientDTO.Name,

                    CPF = patientDTO.CPF,

                    RG = patientDTO.RG,

                    Phone = patientDTO.Phone,

                    Email = patientDTO.Email,

                    Address = patientDTO.Address,

                    City = patientDTO.City,

                    State = patientDTO.State,

                    ZipCode = patientDTO.ZipCode,

                    Country = patientDTO.Country,

                    BloodType = patientDTO.BloodType,

                    Allergies = patientDTO.Allergies,

                    Medications = patientDTO.Medications,

                    Notes = patientDTO.Notes,

                    BirthDate = patientDTO.BirthDate,

                };

                _context.Add(Patient);
                await _context.SaveChangesAsync();

                await _context.Medic.ToListAsync();

                return response;
            }

            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }

        }

        public List<PatientModel> ListAllPatient()
        {
            return _context.Patient.ToList();
        }

        //Search a Patient with his/her Id
        public async Task<ResponseModel<PatientModel>> SearchPatientWithId(int Id)
        {
            ResponseModel<PatientModel> response = new ResponseModel<PatientModel>();
            try
            {
                var Patient = await _context.Patient.FirstOrDefaultAsync (PatientBank => PatientBank.Id == Id);

                if ( Patient == null)
                {
                    response.Menssage = "Paciente não localizado";
                    return response;
                }
                response.Data = Patient;
                return response;
            }

            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }
        }

        //Search a Patient with his/her Name
        public async Task<ResponseModel<PatientModel>> SearchPatientWithName(string Name)
        {
            ResponseModel<PatientModel> response = new ResponseModel<PatientModel>();
            try
            {
                var Patient = await _context.Patient.FirstOrDefaultAsync(PatientBank => PatientBank.Name == Name);

                if (Patient == null)
                {
                    response.Menssage = "Paciente não localizado";
                    return response;
                }
                response.Data = Patient;
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
