using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Entity
{
    public class BookMarkModel
    {
        public int Id { get; set; }

        public MedicModel Medic { get; set; }

        public PatientModel Patient { get; set; }

        public DateTime Hour {  get; set; }

    }
}
