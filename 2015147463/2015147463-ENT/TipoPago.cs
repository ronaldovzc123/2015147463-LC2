using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_ENT
{
    public class TipoPago
    {
        public int TipoPagoID { get; set; }
        public string NombreTipoPago { get; set; }
        public int VentaID { get; set; }
        public Venta Venta { get; set; }

    }
}
