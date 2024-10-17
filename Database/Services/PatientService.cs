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

        public async Task<PatientModel> CreatNewPatient(PatientDTO patientDTO)
        {
            try
            {
                var Patient = new PatientModel()
                {
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
            }

            catch 
            { 
            
            
            }

        }

        public async Task<PatientModel> SearchPatientWithId(int Id)
        {
            try
            {
                var Patient = await _context.Patient.FirstOrDefaultAsync (PatientBank => PatientBank.Id == Id);

                if ( Patient == null)
                {
                    

                }

            }

            catch 
            { 
            
            
            }
        }

        public async Task<PatientModel> SearchPatientWithName(string Name)
        {
            try
            {
                var Patient = await _context.Patient.FirstOrDefaultAsync(PatientBank => PatientBank.Name == Name);

                if (Patient == null)
                {


                }

            }

            catch
            {



            }
        }
    }
}
