namespace _17bangMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class z1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterModels", "Money", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterModels", "Money");
        }
    }
}
