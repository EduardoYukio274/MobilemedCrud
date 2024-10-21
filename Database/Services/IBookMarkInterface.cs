using MobilemedCrud.Database.DTO;
using MobilemedCrud.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MobilemedCrud.Database.Services
{
    public interface IBookMarkInterface
    {

        Task<ResponseModel<List<BookMarkModel>>>CreatNewBookMark(BookMarkModel bookMarkModel);

        Task<ResponseModel<List<BookMarkModel>>> SearchPatientForIdBookMark(int PatientId);

        Task<ResponseModel<List<BookMarkModel>>> SearchMedicForIdBookMark(int MedicId);

        Task<ResponseModel<List<BookMarkModel>>> DeletBookMark(int Id);
        List<BookMarkModel> ListAllBookMark();
    }
}
