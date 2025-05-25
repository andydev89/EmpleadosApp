
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EmpleadosApp.Data;
using EmpleadosApp.Models;
using EmpleadosApp.Repositories;

namespace EmpleadosApp.Pages;

public class CreateModel : PageModel
{
    private readonly IEmpleadoRepository _empleadoRepository;

    public CreateModel(IEmpleadoRepository empleadoRepository)
    {
        _empleadoRepository = empleadoRepository;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Empleado Empleado { get; set; } = default!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || Empleado == null)
        {
            return Page();
        }

        await _empleadoRepository.CreateAsync(Empleado);
        return RedirectToPage("./Index");
    }
}

