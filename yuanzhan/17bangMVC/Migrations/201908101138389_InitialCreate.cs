namespace _17bangMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProblemModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegisterModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        PassWord = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                        IsMan = c.Boolean(nullable: false),
                        description = c.String(),
                        Incity = c.Int(),
                        captcha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterModels");
            DropTable("dbo.ProblemModels");
        }
    }
}
