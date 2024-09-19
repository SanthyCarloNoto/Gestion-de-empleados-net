using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using GestionEmpleadosWebApp.Data; // Ajusta el espacio de nombres
using GestionEmpleadosWebApp.Services; // Ajusta el espacio de nombres

var builder = WebApplication.CreateBuilder(args);

// Configura la cadena de conexión para la base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 29)))); // Ajusta la versión de MySQL según tu configuración

// Registra EmpleadoService
builder.Services.AddScoped<EmpleadoService>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configura el pipeline de la aplicación
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
