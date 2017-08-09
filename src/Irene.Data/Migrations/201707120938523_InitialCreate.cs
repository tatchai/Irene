namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 30),
                        PasswordHash = c.String(),
                        PIN = c.String(maxLength: 6),
                        StatusText = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedByUserName = c.String(),
                        LastVisibleDate = c.DateTime(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true)
                .Index(t => t.PIN, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "PIN" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropTable("dbo.Users");
        }
    }
}
