using MobilemedCrud.Database.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilemedCrud.Database.Commands
{
    public class CommandsCrud : AppDbContext
    {


        public static void AddOrUpdate <TEntity> (this System.Data.Entity.IDbSet<TEntity> set, params TEntity[] entities) where TEntity : class;




    }
}
