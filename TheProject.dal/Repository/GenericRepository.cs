using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TheProject.dal.IRepository;

namespace TheProject.dal.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;

        protected readonly DbContext _context;
        /// <summary>
        /// Constructor injecting the context
        /// </summary>
        /// <param name="_context"></param>
        public GenericRepository(TheProjectContext context)
        {
            this._context = context;
            this._dbSet = _context.Set<T>();

        }
        /// <summary>
        /// Only method being implemented due to the requirement and that this is an assessment
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {            
            return _dbSet;
        }
        // TODO : this class would also include async calls,
    }
}
