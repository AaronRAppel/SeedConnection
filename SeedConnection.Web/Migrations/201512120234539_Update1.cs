namespace SeedConnection.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Name = c.String(),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                        Quantity = c.Int(),
                        DataAvailable = c.DateTime(),
                        Selling = c.Boolean(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
    }
}
