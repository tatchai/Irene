namespace Irene.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrentalcar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "BahtPerDay", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Cars", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Discriminator");
            DropColumn("dbo.Cars", "BahtPerDay");
        }
    }
}
