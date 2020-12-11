namespace PineappleV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Condition = c.String(),
                        cpu_Id = c.Int(),
                        hdd_name = c.String(maxLength: 128),
                        monitor_name = c.String(maxLength: 128),
                        motherboard_name = c.String(maxLength: 128),
                        mouse_name = c.String(maxLength: 128),
                        printer_name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CPUs", t => t.cpu_Id)
                .ForeignKey("dbo.HDDs", t => t.hdd_name)
                .ForeignKey("dbo.Monitors", t => t.monitor_name)
                .ForeignKey("dbo.Motherboards", t => t.motherboard_name)
                .ForeignKey("dbo.Mice", t => t.mouse_name)
                .ForeignKey("dbo.Printers", t => t.printer_name)
                .Index(t => t.cpu_Id)
                .Index(t => t.hdd_name)
                .Index(t => t.monitor_name)
                .Index(t => t.motherboard_name)
                .Index(t => t.mouse_name)
                .Index(t => t.printer_name);
            
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
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Position = c.String(),
                        Department = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Peripheries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Condition = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
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
            DropTable("dbo.Positions");
            DropTable("dbo.Peripheries");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Printers");
            DropTable("dbo.Mice");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Monitors");
            DropTable("dbo.HDDs");
            DropTable("dbo.CPUs");
            DropTable("dbo.Computers");
        }
    }
}
