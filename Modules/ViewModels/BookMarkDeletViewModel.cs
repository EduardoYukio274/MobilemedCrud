using MobilemedCrud.Database.Entity;
using MobilemedCrud.Database.Services;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Registry.ViewModels
{
    public class BookMarkDeletViewModel: BindableBase
    {
        private readonly IBookMarkInterface _bookMarkInterface;
        public List<BookMarkModel> BookMarkModels { get; set; }
        public BookMarkDeletViewModel(IBookMarkInterface bookMarkInterface)
        {
            _bookMarkInterface = bookMarkInterface;

            BookMarkModels = _bookMarkInterface.ListAllBookMark();

            

        }

        
    }
}
