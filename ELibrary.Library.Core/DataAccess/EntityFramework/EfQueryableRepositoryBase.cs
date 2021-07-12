using ELibrary.Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Library.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepositoryBase<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {

        private DbContext _context;
        private IDbSet<T> _entities;
        public EfQueryableRepositoryBase(DbContext context)
        {
            _context = context;
        }
        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
        public IQueryable<T> Table => this.Entities;
    }
}
