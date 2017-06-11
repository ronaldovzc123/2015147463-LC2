using _2015147463_ENT;
using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        public TipoLugarRepository(DbContext context) : base(context)
        {
        }

    }
}
