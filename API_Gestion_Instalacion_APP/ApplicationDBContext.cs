using API_Gestion_Instalacion_APP.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Gestion_Instalacion_APP
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet <Telefonos> Telefono { get; set; }
        public DbSet<Sensores> Sensor { get; set; }
        public DbSet<Operarios> Operario { get; set; }
        public DbSet<Apps> App { get; set; }
        public DbSet<Instalaciones> Instalacion { get; set; }


    }
}
