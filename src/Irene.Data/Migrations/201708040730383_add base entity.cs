namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbaseentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Comment");
        }
    }
}
