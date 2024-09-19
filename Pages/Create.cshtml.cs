using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GestionEmpleadosWebApp.Models;
using GestionEmpleadosWebApp.Services;
using System.Threading.Tasks;

namespace GestionEmpleadosWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly EmpleadoService _empleadoService;

        public CreateModel(EmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
            Empleado = new Empleado(); // Inicializa la propiedad aquí
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _empleadoService.AddEmpleadoAsync(Empleado);

            return RedirectToPage("Index");
        }
    }
}
