namespace _2015147463_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrativo", "Nombre", c => c.String());
            AddColumn("dbo.Administrativo", "Apellido", c => c.String());
            AddColumn("dbo.Administrativo", "Descripción", c => c.String());
            AddColumn("dbo.Administrativo", "VentaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Administrativo", "VentaID");
            AddForeignKey("dbo.Administrativo", "VentaID", "dbo.Venta", "VentaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administrativo", "VentaID", "dbo.Venta");
            DropIndex("dbo.Administrativo", new[] { "VentaID" });
            DropColumn("dbo.Administrativo", "VentaID");
            DropColumn("dbo.Administrativo", "Descripción");
            DropColumn("dbo.Administrativo", "Apellido");
            DropColumn("dbo.Administrativo", "Nombre");
        }
    }
}
