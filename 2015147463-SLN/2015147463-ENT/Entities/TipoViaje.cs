﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_ENT
{
    public class TipoViaje
    {
        public int TipoViajeId { get; set; }
        public string Nombre { get; set; }

        public virtual int ServicioId { get; set; }
        public virtual Servicio Servicio { get; set; }

        public TipoViaje()
        {

        }
    }
}
