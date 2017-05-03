namespace TheProject.dal.Migrations
{
    using core.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    /// <summary>
    /// The seed is implement to add data upon create database, for demonstartion perposes
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<TheProject.dal.TheProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
          
        }
        /// <summary>
        /// Alternative to sql in migration
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(TheProject.dal.TheProjectContext context)
        {

            //var treeItems = new List<Tree>
            //{
            //    new Tree {ParentId = 0, Description = "Music" },
            //    new Tree {ParentId = 0, Description = "Movies" },
            //    new Tree {ParentId = 2, Description = "Comedy" },
            //    new Tree {ParentId = 2, Description = "Horror" },
            //    new Tree {ParentId = 1, Description = "Jazz" }
            //};

            //treeItems.ForEach(s => context.Tree.AddOrUpdate(p => p.Description,s));
            //context.SaveChanges();
        }
    }
}
