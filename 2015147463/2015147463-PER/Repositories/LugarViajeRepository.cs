﻿using _2015147463_ENT;
using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
    class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {
        IEnumerable<Administrativo> ILugarViajeRepository.GetAdministrativoWhiTransporte(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> ILugarViajeRepository.GetAdministrativoWhitEncomienda(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Add(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.AddRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }

        LugarViaje IRepository<LugarViaje>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<LugarViaje> IRepository<LugarViaje>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<LugarViaje> IRepository<LugarViaje>.Find(System.Linq.Expressions.Expression<Func<LugarViaje, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Update(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.UpdateRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.Delete(LugarViaje entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LugarViaje>.DeleteRange(IEnumerable<LugarViaje> entities)
        {
            throw new NotImplementedException();
        }
    }
}
