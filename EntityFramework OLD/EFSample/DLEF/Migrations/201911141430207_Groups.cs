namespace DLEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Groups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(nullable: false, maxLength: 255),
                        CreatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UsersGroups",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.GroupID })
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.GroupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersGroups", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.UsersGroups", "UserID", "dbo.Users");
            DropIndex("dbo.UsersGroups", new[] { "GroupID" });
            DropIndex("dbo.UsersGroups", new[] { "UserID" });
            DropTable("dbo.UsersGroups");
            DropTable("dbo.Groups");
        }
    }
}
