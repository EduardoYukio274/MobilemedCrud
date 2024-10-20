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
    public class BookMarkService : IBookMarkInterface
    {

        private readonly AppDbContext _context;
        public BookMarkService(AppDbContext context)
        {
            _context = context;
        }

        //Creat new BookMark
        public async Task<ResponseModel<List<BookMarkModel>>> CreatNewBookMark(BookMarkModel bookMarkModel)
        {
            ResponseModel<List<BookMarkModel>> response = new ResponseModel<List<BookMarkModel>>();
            try
            {
                var BookMark = new BookMarkModel()
                {
                    Patient = bookMarkModel.Patient,

                    Medic = bookMarkModel.Medic,

                    Hour = bookMarkModel.Hour,

                };

                _context.Add(BookMark);
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

        //Delet a BookMark
        public async Task<ResponseModel<List<BookMarkModel>>> DeletBookMark(int Id)
        {
            ResponseModel<List<BookMarkModel>> response = new ResponseModel<List<BookMarkModel>>();
            try
            {
                var BookMark = await _context.BookMark.FirstOrDefaultAsync(BookMarkBank => BookMarkBank.Id == Id);

                if (BookMark == null)
                {
                    response.Menssage = "Nenhum consulta não localizado";
                    return response;
                }
                _context.Remove(BookMark);
                await _context.SaveChangesAsync();

                response.Data = await _context.BookMark.ToListAsync();
                return response;

            }
            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }
        }

        //Search for a BookMark with some MedicId
        public async Task<ResponseModel<List<BookMarkModel>>> SearchMedicForIdBookMark(int MedicId)
        {
            ResponseModel<List<BookMarkModel>> response = new ResponseModel<List<BookMarkModel>>();
            try
            {
                var BookMark = await _context.BookMark.Include(BookMark => MedicId).
                    Where(BookMarkBank => BookMarkBank.Medic.Id == MedicId).ToListAsync();

                if (BookMark == null)
                {
                    response.Menssage = "Nenhum consulta com esse Medico foi localizado";
                    return response;
                }
                response.Data = BookMark;
                return response;


            }

            catch (Exception ex)
            {
                response.Menssage = ex.Message;
                response.Status = false;
                return response;

            }
        }

        //Search for a BookMark with some PatientId
        public async Task<ResponseModel<List<BookMarkModel>>> SearchPatientForIdBookMark(int PatientId)
        {
            ResponseModel<List<BookMarkModel>> response = new ResponseModel<List<BookMarkModel>>();
            try
            {
                var BookMark = await _context.BookMark.Include(BookMark => PatientId).
                Where(BookMarkBank => BookMarkBank.Patient.Id == PatientId).ToListAsync();

                if (BookMark == null)
                {
                    response.Menssage = "Nenhum consulta com esse Paciente foi localizado";
                    return response;
                }
                response.Data = BookMark;
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
