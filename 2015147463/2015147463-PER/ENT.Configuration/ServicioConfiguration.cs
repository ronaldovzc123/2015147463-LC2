﻿using _2015147463_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015147463_PER.ENT.Configuration
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            ToTable("Servicio");
            HasKey(cl => cl.ServicioID);
            Property(cl => cl.DescripcionServicio).IsRequired();
            Property(cl => cl.cantidad).IsRequired();
            Property(cl => cl.Tipo).IsRequired();

          //  Map<Transporte>(m => m.Requires("Discriminator").HasValue("Transporte"));
            //Map<Encomienda>(m => m.Requires("Discriminator").HasValue("Encomienda"));
        }
    }
}
