using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Consultar_tarjeta_T1.Models
{
    public class Datos_griviewContext : DbContext
    {

        public Datos_griviewContext() : base("Consultar_tarjeta_T1")
        {
        }
        public DbSet<Tipo_Doc> Tipo_Docs { get; set; }
        public DbSet<Datos_griview> Datos_Griviews { get; set; }
    }
}