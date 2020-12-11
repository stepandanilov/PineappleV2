namespace PineappleV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentsToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Department_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropColumn("dbo.Employees", "Department_Id");
        }
    }
}
