﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_ENT.IRepositories
{
    public interface IBusRepository : IRepository<Bus>
    {
         IEnumerable<Bus> GetAdministrativoWhitEncomienda(int pageIndex, int pageSize);

    }
}
