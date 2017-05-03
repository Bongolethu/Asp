using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProject.core.Entity;

namespace TheProject.dal
{
    public class TheProjectContext : DbContext
    {
        public TheProjectContext() : base("name=DBConnectionString") 
        {
            Configuration.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }

        public DbSet<Tree> Tree { get; set; }
        
    }
}
