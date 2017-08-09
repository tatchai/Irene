namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usebaseID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
