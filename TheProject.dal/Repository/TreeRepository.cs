using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.core.Entity;
using TheProject.dal.IRepository;

namespace TheProject.dal.Repository
{
    public class TreeRepository : GenericRepository<Tree>, ITreeRepository
    {
        private DbContext _dbContext;
        private DbSet<Tree> _dbSet;
        public TreeRepository(TheProjectContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Tree>();
        }

        public async Task<Tree> GetByParentIdAsync(int parentId)
        {
          
            return await _dbSet.FindAsync(parentId);
        }
    }
}
