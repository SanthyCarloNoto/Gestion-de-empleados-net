using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GestionEmpleadosWebApp.Services;

namespace GestionEmpleadosWebApp.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly EmpleadoService _empleadoService;

        public EmpleadoController(EmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        public async Task<IActionResult> Index()
        {
            var empleados = await _empleadoService.GetEmpleadosAsync();
            return View(empleados);
        }
    }
}
