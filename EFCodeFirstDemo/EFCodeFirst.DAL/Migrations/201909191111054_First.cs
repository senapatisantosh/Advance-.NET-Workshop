namespace EFCodeFirst.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Long(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        EmailID = c.String(),
                        Department_DepartmentId = c.Long(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "Department_DepartmentId" });
            DropTable("dbo.Users");
            DropTable("dbo.Departments");
        }
    }
}
