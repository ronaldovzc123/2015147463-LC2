using _2015147463_ENT;
using _2015147463_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        private readonly Class Context; 

        public EncomiendaRepository()
        {

        }
        public EncomiendaRepository(Class context)
        {
            Context = context;
        }
        IEnumerable<Encomienda> IEncomiendaRepository.GetAdministrativoWhitLugarViaje(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<Encomienda>.Add(Encomienda entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Encomienda>.AddRange(IEnumerable<Encomienda> entities)
        {
            throw new NotImplementedException();
        }

        Encomienda IRepository<Encomienda>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Encomienda> IRepository<Encomienda>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Encomienda> IRepository<Encomienda>.Find(System.Linq.Expressions.Expression<Func<Encomienda, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Encomienda>.Update(Encomienda entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Encomienda>.UpdateRange(IEnumerable<Encomienda> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Encomienda>.Delete(Encomienda entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Encomienda>.DeleteRange(IEnumerable<Encomienda> entities)
        {
            throw new NotImplementedException();
        }
    }
}
