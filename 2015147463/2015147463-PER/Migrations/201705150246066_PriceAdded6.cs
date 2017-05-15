namespace _2015147463_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Bus",
                c => new
                    {
                        BusID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.BusID);
            
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Encomienda",
                c => new
                    {
                        EncomiendaID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EncomiendaID);
            
            CreateTable(
                "dbo.LugarViaje",
                c => new
                    {
                        LugarViajeID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.LugarViajeID);
            
            CreateTable(
                "dbo.Servicio",
                c => new
                    {
                        ServicioID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ServicioID);
            
            CreateTable(
                "dbo.TipoComprobante",
                c => new
                    {
                        TipoComprobanteID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoComprobanteID);
            
            CreateTable(
                "dbo.TipoLugar",
                c => new
                    {
                        TipoLugarID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoLugarID);
            
            CreateTable(
                "dbo.TipoTripulacion",
                c => new
                    {
                        TipoTripulacionID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoTripulacionID);
            
            CreateTable(
                "dbo.TipoViaje",
                c => new
                    {
                        TipoViajeID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoViajeID);
            
            CreateTable(
                "dbo.Transporte",
                c => new
                    {
                        TransporteID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TransporteID);
            
            CreateTable(
                "dbo.Tripulacion",
                c => new
                    {
                        TripulacionID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TripulacionID);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        VentaID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VentaID);
            
            CreateTable(
                "dbo.TipoPago",
                c => new
                    {
                        TipoPagoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoPagoID);
            
            CreateTable(
                "dbo.Administrativo",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false),
                        AdministrativoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID)
                .Index(t => t.EmpleadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administrativo", "EmpleadoID", "dbo.Empleado");
            DropIndex("dbo.Administrativo", new[] { "EmpleadoID" });
            DropTable("dbo.Administrativo");
            DropTable("dbo.TipoPago");
            DropTable("dbo.Venta");
            DropTable("dbo.Tripulacion");
            DropTable("dbo.Transporte");
            DropTable("dbo.TipoViaje");
            DropTable("dbo.TipoTripulacion");
            DropTable("dbo.TipoLugar");
            DropTable("dbo.TipoComprobante");
            DropTable("dbo.Servicio");
            DropTable("dbo.LugarViaje");
            DropTable("dbo.Encomienda");
            DropTable("dbo.Evento");
            DropTable("dbo.Bus");
            DropTable("dbo.Empleado");
        }
    }
}
