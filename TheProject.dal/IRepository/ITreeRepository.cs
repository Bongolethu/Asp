using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.core.Entity;
using TheProject.dal.IRepository;

namespace TheProject.dal.IRepository
{
    public interface ITreeRepository  : IGenericRepository<Tree> 
    {
         Task<Tree> GetByParentIdAsync(int parentId);
    }
}
