using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Model.Entity
{
    public class Class2 : Patient
    {
        void A()
        {
            var ls = new List<FamilyMember>();
            ls.Add(new Adult() { Name = "Pedro"});
            ls.Add(new Child() { Name = "Maria"});
        }
    }
}
