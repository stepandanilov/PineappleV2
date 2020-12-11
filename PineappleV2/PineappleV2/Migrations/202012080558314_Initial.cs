namespace PineappleV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Employees", "PositionID", "dbo.Positions");
            DropForeignKey("dbo.Computers", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Computers", "SettingId", "dbo.CompSettings");
            DropForeignKey("dbo.Peripheries", "CompID", "dbo.Computers");
            DropForeignKey("dbo.Peripheries", "SettingID", "dbo.PerSettings");
            DropIndex("dbo.Computers", new[] { "SettingId" });
            DropIndex("dbo.Computers", new[] { "EmployeeID" });
            DropIndex("dbo.Employees", new[] { "PositionID" });
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropIndex("dbo.Peripheries", new[] { "SettingID" });
            DropIndex("dbo.Peripheries", new[] { "CompID" });
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        frequency = c.String(),
                        name = c.String(),
                        manufacturer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HDDs",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        manufacturer = c.String(),
                        space = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Monitors",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        manufacturer = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        manufacturer = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Mice",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        manufacturer = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        manufacturer = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            AddColumn("dbo.Computers", "cpu_Id", c => c.Int());
            AddColumn("dbo.Computers", "hdd_name", c => c.String(maxLength: 128));
            AddColumn("dbo.Computers", "monitor_name", c => c.String(maxLength: 128));
            AddColumn("dbo.Computers", "motherboard_name", c => c.String(maxLength: 128));
            AddColumn("dbo.Computers", "mouse_name", c => c.String(maxLength: 128));
            AddColumn("dbo.Computers", "printer_name", c => c.String(maxLength: 128));
            CreateIndex("dbo.Computers", "cpu_Id");
            CreateIndex("dbo.Computers", "hdd_name");
            CreateIndex("dbo.Computers", "monitor_name");
            CreateIndex("dbo.Computers", "motherboard_name");
            CreateIndex("dbo.Computers", "mouse_name");
            CreateIndex("dbo.Computers", "printer_name");
            AddForeignKey("dbo.Computers", "cpu_Id", "dbo.CPUs", "Id");
            AddForeignKey("dbo.Computers", "hdd_name", "dbo.HDDs", "name");
            AddForeignKey("dbo.Computers", "monitor_name", "dbo.Monitors", "name");
            AddForeignKey("dbo.Computers", "motherboard_name", "dbo.Motherboards", "name");
            AddForeignKey("dbo.Computers", "mouse_name", "dbo.Mice", "name");
            AddForeignKey("dbo.Computers", "printer_name", "dbo.Printers", "name");
            DropColumn("dbo.Computers", "SettingId");
            DropColumn("dbo.Computers", "EmployeeID");
            DropColumn("dbo.Employees", "PositionID");
            DropColumn("dbo.Employees", "DepartmentID");
            DropColumn("dbo.Peripheries", "SettingID");
            DropColumn("dbo.Peripheries", "CompID");
            DropTable("dbo.CompSettings");
            DropTable("dbo.PerSettings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PerSettings",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.CompSettings",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Name);
            
            AddColumn("dbo.Peripheries", "CompID", c => c.Int(nullable: false));
            AddColumn("dbo.Peripheries", "SettingID", c => c.String(maxLength: 128));
            AddColumn("dbo.Employees", "DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "PositionID", c => c.Int(nullable: false));
            AddColumn("dbo.Computers", "EmployeeID", c => c.Int(nullable: false));
            AddColumn("dbo.Computers", "SettingId", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Computers", "printer_name", "dbo.Printers");
            DropForeignKey("dbo.Computers", "mouse_name", "dbo.Mice");
            DropForeignKey("dbo.Computers", "motherboard_name", "dbo.Motherboards");
            DropForeignKey("dbo.Computers", "monitor_name", "dbo.Monitors");
            DropForeignKey("dbo.Computers", "hdd_name", "dbo.HDDs");
            DropForeignKey("dbo.Computers", "cpu_Id", "dbo.CPUs");
            DropIndex("dbo.Computers", new[] { "printer_name" });
            DropIndex("dbo.Computers", new[] { "mouse_name" });
            DropIndex("dbo.Computers", new[] { "motherboard_name" });
            DropIndex("dbo.Computers", new[] { "monitor_name" });
            DropIndex("dbo.Computers", new[] { "hdd_name" });
            DropIndex("dbo.Computers", new[] { "cpu_Id" });
            DropColumn("dbo.Computers", "printer_name");
            DropColumn("dbo.Computers", "mouse_name");
            DropColumn("dbo.Computers", "motherboard_name");
            DropColumn("dbo.Computers", "monitor_name");
            DropColumn("dbo.Computers", "hdd_name");
            DropColumn("dbo.Computers", "cpu_Id");
            DropTable("dbo.Printers");
            DropTable("dbo.Mice");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Monitors");
            DropTable("dbo.HDDs");
            DropTable("dbo.CPUs");
            CreateIndex("dbo.Peripheries", "CompID");
            CreateIndex("dbo.Peripheries", "SettingID");
            CreateIndex("dbo.Employees", "DepartmentID");
            CreateIndex("dbo.Employees", "PositionID");
            CreateIndex("dbo.Computers", "EmployeeID");
            CreateIndex("dbo.Computers", "SettingId");
            AddForeignKey("dbo.Peripheries", "SettingID", "dbo.PerSettings", "Name");
            AddForeignKey("dbo.Peripheries", "CompID", "dbo.Computers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Computers", "SettingId", "dbo.CompSettings", "Name");
            AddForeignKey("dbo.Computers", "EmployeeID", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "PositionID", "dbo.Positions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
