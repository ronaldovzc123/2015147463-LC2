﻿using _2015147463_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.ENT.Configuration
{

    public class TipoComprobanteConfiguration : EntityTypeConfiguration<TipoComprobante>
    {
        public TipoComprobanteConfiguration()
        {
            ToTable("TipoComprobante");
            HasKey(cl => cl.TipoComprobanteID);
        }
    }
}
