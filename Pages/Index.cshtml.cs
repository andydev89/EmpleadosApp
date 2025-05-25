
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmpleadosApp.Models;
using EmpleadosApp.Repositories;

namespace EmpleadosApp.Pages;

public class IndexModel : PageModel
{
    private readonly IEmpleadoRepository _empleadoRepository;

    public IndexModel(IEmpleadoRepository empleadoRepository)
    {
        _empleadoRepository = empleadoRepository;
    }

    public IList<Empleado> Empleados { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Empleados = await _empleadoRepository.GetAllAsync();
    }
}
