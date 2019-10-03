namespace EFCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phonenodelete : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "PhoneNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PhoneNo", c => c.String());
        }
    }
}
