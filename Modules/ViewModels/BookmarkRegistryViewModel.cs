using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using MobilemedCrud.Database.Data;
using MobilemedCrud.Database.Entity;
using MobilemedCrud.Database.Services;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilemedCrud.Registry.ViewModels
{
    public class BookmarkRegistryViewModel : BindableBase
    {

        SqlCommand cmd = new SqlCommand();

        private readonly IBookMarkInterface _bookMarkInterface;
        public BookmarkRegistryViewModel(IBookMarkInterface bookMarkInterface)
        {
            _bookMarkInterface = bookMarkInterface;
        }


        public BookmarkRegistryViewModel(int MedicId, int PatientId, DateTime hour )
        {
            


    }
}
}
