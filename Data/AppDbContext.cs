using Microsoft.EntityFrameworkCore;
using GestionEmpleadosWebApp.Models;

namespace GestionEmpleadosWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
