namespace Natura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductoCategoriaLinea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Lineas",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.IdLinea);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Codigo = c.Int(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                        IdLinea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Categorias", t => t.IdCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Lineas", t => t.IdLinea, cascadeDelete: true)
                .Index(t => t.IdCategoria)
                .Index(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productoes", "IdLinea", "dbo.Lineas");
            DropForeignKey("dbo.Productoes", "IdCategoria", "dbo.Categorias");
            DropIndex("dbo.Productoes", new[] { "IdLinea" });
            DropIndex("dbo.Productoes", new[] { "IdCategoria" });
            DropTable("dbo.Productoes");
            DropTable("dbo.Lineas");
            DropTable("dbo.Categorias");
        }
    }
}
