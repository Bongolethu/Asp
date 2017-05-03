namespace TheProject.dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tree",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Description = c.String(),
                        DateCreated = c.DateTime(nullable: false, defaultValueSql:"GETDATE()"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tree");
        }
    }
}
