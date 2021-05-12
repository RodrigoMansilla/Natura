namespace Natura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductosEnCasas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductoEnCasas",
                c => new
                    {
                        IdProductoEncasa = c.Int(nullable: false, identity: true),
                        IdProducto = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        DondeEsta = c.String(maxLength: 50),
                        Comentario = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.IdProductoEncasa)
                .ForeignKey("dbo.Productoes", t => t.IdProducto, cascadeDelete: true)
                .Index(t => t.IdProducto);
            
            CreateTable(
                "dbo.Vencimientos",
                c => new
                    {
                        IdVencimiento = c.Int(nullable: false, identity: true),
                        IdProducto = c.Int(nullable: false),
                        FVencimiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdVencimiento)
                .ForeignKey("dbo.Productoes", t => t.IdProducto, cascadeDelete: true)
                .Index(t => t.IdProducto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vencimientos", "IdProducto", "dbo.Productoes");
            DropForeignKey("dbo.ProductoEnCasas", "IdProducto", "dbo.Productoes");
            DropIndex("dbo.Vencimientos", new[] { "IdProducto" });
            DropIndex("dbo.ProductoEnCasas", new[] { "IdProducto" });
            DropTable("dbo.Vencimientos");
            DropTable("dbo.ProductoEnCasas");
        }
    }
}
