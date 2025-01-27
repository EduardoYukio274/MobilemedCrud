﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Entity
{
    public class PatientModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public string Medications { get; set; }
        public string Notes { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
