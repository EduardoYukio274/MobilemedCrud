using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Entity
{
    public class ResponseModel<T>
    {
        public T? Data { get; set; }
        public string Menssage { get; set; }
        public bool Status { get; set; }

    }
}   
