namespace EFCodeFirst.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asad : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "Department_DepartmentId", newName: "DeptID");
            RenameIndex(table: "dbo.Users", name: "IX_Department_DepartmentId", newName: "IX_DeptID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "IX_DeptID", newName: "IX_Department_DepartmentId");
            RenameColumn(table: "dbo.Users", name: "DeptID", newName: "Department_DepartmentId");
        }
    }
}
