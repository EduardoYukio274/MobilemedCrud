using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilemedCrud.Registry.ViewModels
{
    public class PatientRegistryViewModel : BindableBase
    {

        string xablau = "123";


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set
            {
                if (value <= 0)
                    myVar = 1;
                else
                    myVar = value;
            }
        }

        public PatientRegistryViewModel()
        {

        }
    }
}
