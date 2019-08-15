namespace _17bangMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zx : DbMigration
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
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Body = c.String(),
                        ProblemModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProblemModels", t => t.ProblemModelId, cascadeDelete: true)
                .Index(t => t.ProblemModelId);
            
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
                        Money = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "ProblemModelId", "dbo.ProblemModels");
            DropIndex("dbo.Posts", new[] { "ProblemModelId" });
            DropTable("dbo.RegisterModels");
            DropTable("dbo.Posts");
            DropTable("dbo.ProblemModels");
        }
    }
}
