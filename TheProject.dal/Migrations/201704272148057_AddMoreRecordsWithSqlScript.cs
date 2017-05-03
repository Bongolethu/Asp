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
            strSql.Append("INSERT INTO TREE(PARENTID, DESCRIPTION)");
            strSql.Append("VALUES(1, 'Rap')                   ");

            Sql(strSql.ToString());

        }

        public override void Down()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM TREE");
            strSql.Append("WHERE DESCRIPTION = 'Rap'),         ");
            strSql.Append(" AND PARENTID = 1                     ");

            Sql(strSql.ToString());
        }
    }
}
