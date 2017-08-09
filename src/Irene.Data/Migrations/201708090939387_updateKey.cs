namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Comment", c => c.String());
            AddColumn("dbo.UserGroups", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserGroups", "Comment");
            DropColumn("dbo.Roles", "Comment");
        }
    }
}
