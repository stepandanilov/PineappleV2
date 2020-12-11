namespace PineappleV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class positions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Position_Id", c => c.Int());
            CreateIndex("dbo.Employees", "Position_Id");
            AddForeignKey("dbo.Employees", "Position_Id", "dbo.Positions", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            DropColumn("dbo.Employees", "Position_Id");
        }
    }
}
