using Microsoft.EntityFrameworkCore;
using RecupeParcial1.Models;

namespace RecupeParcial1.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Prestamo> prestamo { get; set; }
    }
}
