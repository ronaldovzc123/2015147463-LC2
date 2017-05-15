namespace _2015147463_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evento", "Nombres", c => c.String());
            AddColumn("dbo.Evento", "Apellidos", c => c.String());
            AddColumn("dbo.Evento", "DNI", c => c.String());
            AddColumn("dbo.Evento", "VentaID", c => c.Int(nullable: false));
            AddColumn("dbo.Evento", "TransporteID", c => c.Int(nullable: false));
            CreateIndex("dbo.Evento", "VentaID");
            CreateIndex("dbo.Evento", "TransporteID");
            AddForeignKey("dbo.Evento", "TransporteID", "dbo.Transporte", "TransporteID", cascadeDelete: true);
            AddForeignKey("dbo.Evento", "VentaID", "dbo.Venta", "VentaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evento", "VentaID", "dbo.Venta");
            DropForeignKey("dbo.Evento", "TransporteID", "dbo.Transporte");
            DropIndex("dbo.Evento", new[] { "TransporteID" });
            DropIndex("dbo.Evento", new[] { "VentaID" });
            DropColumn("dbo.Evento", "TransporteID");
            DropColumn("dbo.Evento", "VentaID");
            DropColumn("dbo.Evento", "DNI");
            DropColumn("dbo.Evento", "Apellidos");
            DropColumn("dbo.Evento", "Nombres");
        }
    }
}
