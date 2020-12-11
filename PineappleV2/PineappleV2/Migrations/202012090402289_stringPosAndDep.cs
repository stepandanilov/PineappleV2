namespace PineappleV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringPosAndDep : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            AddColumn("dbo.Employees", "Position", c => c.String());
            AddColumn("dbo.Employees", "Department", c => c.String());
            DropColumn("dbo.Employees", "Department_Id");
            DropColumn("dbo.Employees", "Position_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Position_Id", c => c.Int());
            AddColumn("dbo.Employees", "Department_Id", c => c.Int());
            DropColumn("dbo.Employees", "Department");
            DropColumn("dbo.Employees", "Position");
            CreateIndex("dbo.Employees", "Position_Id");
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Position_Id", "dbo.Positions", "Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
