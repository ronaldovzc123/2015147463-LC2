﻿using _2015147463_ENT;
using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
    class TipoComprobanteRepository : Repository<TipoComprobante>, ITipoComprobanteRepository
    {
         private readonly Class Context; 

        public TipoComprobanteRepository()
        {

        }
        public TipoComprobanteRepository(Class context)
        {
            Context = context;
        }
    }
}
