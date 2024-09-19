using GestionEmpleadosWebApp.Data;
using GestionEmpleadosWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionEmpleadosWebApp.Services
{
    public class EmpleadoService
    {
        private readonly AppDbContext _context;

        public EmpleadoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddEmpleadoAsync(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Empleado>> GetEmpleadosAsync()
        {
            return await _context.Empleados.ToListAsync();
        }
    }
}
