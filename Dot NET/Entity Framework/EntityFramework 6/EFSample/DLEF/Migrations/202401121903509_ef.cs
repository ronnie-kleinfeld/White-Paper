namespace DLEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ef : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "DepartmentID", "dbo.Departments");
            AddForeignKey("dbo.Users", "DepartmentID", "dbo.Departments", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "DepartmentID", "dbo.Departments");
            AddForeignKey("dbo.Users", "DepartmentID", "dbo.Departments", "ID", cascadeDelete: true);
        }
    }
}
