namespace TheProject.dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Text;

    public partial class AddMoreRecordsWithSqlScript : DbMigration
    {
        /// <summary>
        /// This method is just to show ability to use custom Sql in Migrations
        /// </summary>
        public override void Up()
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("INSERT INTO[dbo].[Tree] (PARENTID, DESCRIPTION)");
            strSql.Append("VALUES(0, 'Music')     ");
            strSql.Append(",(0, 'Movies')         ");
            strSql.Append(",(2, 'Comedy')         ");
            strSql.Append(",(2, 'Horror')         ");
            strSql.Append(", (1, 'Jazz')          ");
            strSql.Append(",(1, 'Rap')                   ");

            Sql(strSql.ToString());

        }

        public override void Down()
        {
           //TODO : ROLLBACK
        }
    }
}
