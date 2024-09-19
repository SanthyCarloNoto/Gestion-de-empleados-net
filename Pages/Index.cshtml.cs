using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using GestionEmpleadosWebApp.Services; // Ajusta el espacio de nombres según sea necesario
using GestionEmpleadosWebApp.Models; // Ajusta el espacio de nombres según sea necesario

namespace GestionEmpleadosWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly EmpleadoService _empleadoService;

        public IndexModel(ILogger<IndexModel> logger, EmpleadoService empleadoService)
        {
            _logger = logger;
            _empleadoService = empleadoService;
            Empleados = new List<Empleado>(); // Inicializa la propiedad
        }

        public IList<Empleado> Empleados { get; set; }

        public async Task OnGetAsync()
        {
            Empleados = await _empleadoService.GetEmpleadosAsync();
        }
    }
}
