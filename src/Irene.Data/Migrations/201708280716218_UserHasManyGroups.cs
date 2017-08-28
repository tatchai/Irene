namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserHasManyGroups : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UserGroup_Id", "dbo.UserGroups");
            DropIndex("dbo.Users", new[] { "UserGroup_Id" });
            CreateTable(
                "dbo.UserUserGroups",
                c => new
                    {
                        User_Id = c.Guid(nullable: false),
                        UserGroup_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.UserGroup_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.UserGroup_Id);
            
            DropColumn("dbo.Users", "UserGroup_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserGroup_Id", c => c.Int());
            DropForeignKey("dbo.UserUserGroups", "UserGroup_Id", "dbo.UserGroups");
            DropForeignKey("dbo.UserUserGroups", "User_Id", "dbo.Users");
            DropIndex("dbo.UserUserGroups", new[] { "UserGroup_Id" });
            DropIndex("dbo.UserUserGroups", new[] { "User_Id" });
            DropTable("dbo.UserUserGroups");
            CreateIndex("dbo.Users", "UserGroup_Id");
            AddForeignKey("dbo.Users", "UserGroup_Id", "dbo.UserGroups", "Id");
        }
    }
}
