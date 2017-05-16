﻿using _2015147463_ENT;
using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
    public class TipoPagoRepository : Repository<TipoPago>, ITipoPagoRepository
    { 
        
        private readonly Class Context;

        public TipoPagoRepository()
        {

        }
        public TipoPagoRepository(Class context)
        {
            Context = context;
        }
    }
}
