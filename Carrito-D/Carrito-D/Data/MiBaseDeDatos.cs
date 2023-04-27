using Estacionamiento_D.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_D.Data
{
    public class MiBaseDeDatos : DbContext
    {
        public MiBaseDeDatos(DbContextOptions options) : base(options)
        {
            
        }


        public DbSet<Persona> Personas { get; set; }

        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<Telefono> Telefonos { get; set; }

    }
}
