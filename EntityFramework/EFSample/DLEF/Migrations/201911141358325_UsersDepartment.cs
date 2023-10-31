namespace DLEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersDepartment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 255),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        DepartmentID = c.Int(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 255),
                        OrderBy = c.Int(nullable: false),
                        IsDefault = c.Boolean(nullable: false),
                        Disabled = c.Boolean(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "DepartmentID" });
            DropTable("dbo.Departments");
            DropTable("dbo.Users");
        }
    }
}
