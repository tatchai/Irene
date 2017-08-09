namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_cars : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "User_Id", c => c.Guid());
            CreateIndex("dbo.Cars", "User_Id");
            AddForeignKey("dbo.Cars", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "User_Id", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "User_Id" });
            DropColumn("dbo.Cars", "User_Id");
        }
    }
}
