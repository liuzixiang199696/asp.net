namespace _17bangMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zx : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RegisterModels", "captcha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RegisterModels", "captcha", c => c.String());
        }
    }
}
