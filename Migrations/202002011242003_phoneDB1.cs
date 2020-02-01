namespace PhoneApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phoneDB1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Phones", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
