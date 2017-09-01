namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrolesandGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserGroupRoles",
                c => new
                    {
                        UserGroup_Id = c.Int(nullable: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserGroup_Id, t.Role_Id })
                .ForeignKey("dbo.UserGroups", t => t.UserGroup_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.UserGroup_Id)
                .Index(t => t.Role_Id);
            
            AddColumn("dbo.Users", "UserGroup_Id", c => c.Int());
            CreateIndex("dbo.Users", "UserGroup_Id");
            AddForeignKey("dbo.Users", "UserGroup_Id", "dbo.UserGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserGroup_Id", "dbo.UserGroups");
            DropForeignKey("dbo.UserGroupRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserGroupRoles", "UserGroup_Id", "dbo.UserGroups");
            DropIndex("dbo.UserGroupRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserGroupRoles", new[] { "UserGroup_Id" });
            DropIndex("dbo.Users", new[] { "UserGroup_Id" });
            DropColumn("dbo.Users", "UserGroup_Id");
            DropTable("dbo.UserGroupRoles");
            DropTable("dbo.UserGroups");
            DropTable("dbo.Roles");
        }
    }
}
