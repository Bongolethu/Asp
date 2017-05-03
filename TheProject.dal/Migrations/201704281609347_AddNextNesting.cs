namespace TheProject.dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Text;

    public partial class AddNextNesting : DbMigration
    {
        public override void Up()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendLine("INSERT INTO[Tree](ParentId, Description)");
            strSql.AppendLine("VALUES(3, 'Title')                            ");
            strSql.AppendLine("     ,(3,'Actors')                            ");
            strSql.AppendLine("                                              ");
            strSql.AppendLine("INSERT INTO[Tree](ParentId, Description)");
            strSql.AppendLine("VALUES(5, 'Title')                            ");
            strSql.AppendLine("     ,(5,'Artists')                           ");

            Sql(strSql.ToString());
        }
        /// <summary>
        /// This is where the rollback would be
        /// </summary>
        public override void Down()
        {

        }
    }
}
