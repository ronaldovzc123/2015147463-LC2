namespace _2015147463_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceAdded11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bus", "Placa", c => c.String());
            AddColumn("dbo.Bus", "cantidad", c => c.Int(nullable: false));
            AddColumn("dbo.Bus", "color", c => c.String());
            AddColumn("dbo.Bus", "Transporte1_TransporteID", c => c.Int());
            AddColumn("dbo.Bus", "Tripulacion_TripulacionID", c => c.Int());
            AddColumn("dbo.Bus", "Tripulaciones1_TripulacionID", c => c.Int());
            AddColumn("dbo.Encomienda", "Bus_BusID", c => c.Int());
            CreateIndex("dbo.Bus", "Transporte1_TransporteID");
            CreateIndex("dbo.Bus", "Tripulacion_TripulacionID");
            CreateIndex("dbo.Bus", "Tripulaciones1_TripulacionID");
            CreateIndex("dbo.Encomienda", "Bus_BusID");
            AddForeignKey("dbo.Encomienda", "Bus_BusID", "dbo.Bus", "BusID");
            AddForeignKey("dbo.Bus", "Transporte1_TransporteID", "dbo.Transporte", "TransporteID");
            AddForeignKey("dbo.Bus", "Tripulacion_TripulacionID", "dbo.Tripulacion", "TripulacionID");
            AddForeignKey("dbo.Bus", "Tripulaciones1_TripulacionID", "dbo.Tripulacion", "TripulacionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bus", "Tripulaciones1_TripulacionID", "dbo.Tripulacion");
            DropForeignKey("dbo.Bus", "Tripulacion_TripulacionID", "dbo.Tripulacion");
            DropForeignKey("dbo.Bus", "Transporte1_TransporteID", "dbo.Transporte");
            DropForeignKey("dbo.Encomienda", "Bus_BusID", "dbo.Bus");
            DropIndex("dbo.Encomienda", new[] { "Bus_BusID" });
            DropIndex("dbo.Bus", new[] { "Tripulaciones1_TripulacionID" });
            DropIndex("dbo.Bus", new[] { "Tripulacion_TripulacionID" });
            DropIndex("dbo.Bus", new[] { "Transporte1_TransporteID" });
            DropColumn("dbo.Encomienda", "Bus_BusID");
            DropColumn("dbo.Bus", "Tripulaciones1_TripulacionID");
            DropColumn("dbo.Bus", "Tripulacion_TripulacionID");
            DropColumn("dbo.Bus", "Transporte1_TransporteID");
            DropColumn("dbo.Bus", "color");
            DropColumn("dbo.Bus", "cantidad");
            DropColumn("dbo.Bus", "Placa");
        }
    }
}
