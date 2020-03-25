namespace SpaceConquest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDb1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resources", "ResourceType", c => c.Int(nullable: false));
            AddColumn("dbo.Resources", "ResourceGenerator_Id", c => c.Long());
            AlterColumn("dbo.Buildings", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.Planets", "Name", c => c.String(maxLength: 20));
            AlterColumn("dbo.SolarSystems", "Name", c => c.String(maxLength: 20));
            CreateIndex("dbo.Resources", "ResourceGenerator_Id");
            AddForeignKey("dbo.Resources", "ResourceGenerator_Id", "dbo.Buildings", "Id");
            DropColumn("dbo.Resources", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resources", "Name", c => c.Int(nullable: false));
            DropForeignKey("dbo.Resources", "ResourceGenerator_Id", "dbo.Buildings");
            DropIndex("dbo.Resources", new[] { "ResourceGenerator_Id" });
            AlterColumn("dbo.SolarSystems", "Name", c => c.String());
            AlterColumn("dbo.Planets", "Name", c => c.String());
            AlterColumn("dbo.Buildings", "Name", c => c.String());
            DropColumn("dbo.Resources", "ResourceGenerator_Id");
            DropColumn("dbo.Resources", "ResourceType");
        }
    }
}
