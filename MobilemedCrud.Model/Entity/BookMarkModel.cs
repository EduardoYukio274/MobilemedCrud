using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Model.Entity
{
    public class BookMarkModel
    {
        public int Id { get; set; }

        public MedicModel Medic { get; set; }

        public PatientModel Patient { get; set; }

    }
}
