using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_ENT
{
    public class TipoComprobante
    {
        public int TipoComprobanteID { get; set; }
        public double Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }


    }
}
