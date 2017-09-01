namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class autoid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "User_Id", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
            AddForeignKey("dbo.Cars", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "User_Id", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
            AddForeignKey("dbo.Cars", "User_Id", "dbo.Users", "Id");
        }
    }
}
